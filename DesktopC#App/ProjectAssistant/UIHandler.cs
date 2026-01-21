using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectAssistant
{
    public class UIHandler
    {
        private static TableLayoutPanel currentPane = new TableLayoutPanel();

        public static void changePanel(TableLayoutPanel newPane)
        {
            if (currentPane != null)
            {
                currentPane.Visible = false;
            }
            currentPane = newPane;
            currentPane.Visible = true;
        }

        public static void resetFields(Control item)
        {
            foreach (Control subItem in item.Controls)
            {
                resetFields(subItem);
            }
            if (item is TextBox tb)
            {
                tb.Text = "";
            }
            else if (item is ComboBox cb)
            {
                cb.SelectedIndex = cb.Items.Count > 0 ? 0 : -1;
            }
            else if (item is CheckedListBox clb)
            {
                for (int i = 0; i < clb.Items.Count; i++)
                {
                    clb.SetItemChecked(i, false);
                }
                clb.ClearSelected();
            }
            else if (item is ListBox lb)
            {
                lb.ClearSelected();
            }
            else if (item is RadioButton rb)
            {
                rb.Checked = false;
            }
        }

        public static void populateListFromJsonElement(Control list, JsonElement source, string property)
        {
            try
            {
                JsonElement items = source.GetProperty(property);
                foreach (JsonElement item in items.EnumerateArray())
                {
                    if (list is ComboBox cb)
                    {
                        cb.Items.Add(item.GetString());
                    }
                    else if (list is CheckedListBox clb)
                    {
                        clb.Items.Add(item.GetString());
                    }
                    else if (list is ListBox lb)
                    {
                        lb.Items.Add(item.GetString());
                    }
                }
            }
            catch (KeyNotFoundException ex)
            { 
                list.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void disableAllControlsInContainer(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = false;
            }
        }

        public static void enableAllControlsInContainer(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Enabled = true;
            }
        }

        public static void buildTreeViewFromJsonElement(TreeView treeView, JsonElement jsonElement)
        {
            treeView.Nodes.Clear();
            JsonElement rootName = jsonElement.GetProperty("Name");
            JsonElement rootChildren = jsonElement.GetProperty("Children");
            TreeNode rootNode = new TreeNode(rootName.GetString());
            buildTreeViewRecursive(rootNode, rootChildren);
            treeView.Nodes.Add(rootNode);
            treeView.ExpandAll();
        }

        private static void buildTreeViewRecursive(TreeNode parent, JsonElement children)
        {
            foreach (JsonElement child in children.EnumerateArray())
            {
                JsonElement childName = child.GetProperty("Name");
                TreeNode childNode = new TreeNode(childName.GetString());
                parent.Nodes.Add(childNode);
                if (child.TryGetProperty("Children", out JsonElement grandChildren))
                {
                    buildTreeViewRecursive(childNode, grandChildren);
                }
            }
        }

        public static void populateListViewFromList(ListView listView, List<string> items)
        {
            listView.BeginUpdate();
            listView.Items.Clear();
            foreach (string item in items)
            {
                listView.Items.Add(new ListViewItem(item));
            }
            listView.EndUpdate();
        }

        public static void populateTableWithListViewOfFiles(TableLayoutPanel table, List<string> fileDirectories)
        {
            // Clear previous contents and row styles to avoid overlapping/squeezed rows
            table.SuspendLayout();
            table.Controls.Clear();
            table.RowStyles.Clear();

            int count = fileDirectories?.Count ?? 0;
            if (count == 0)
            {
                table.RowCount = 0;
                table.ResumeLayout();
                return;
            }

            table.AutoScroll = true;
            table.RowCount = count;

            // Make each row autosize to its content so GroupBox/ListView get the space they need
            for (int r = 0; r < count; r++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < count; i++)
            {
                GroupBox gb = new GroupBox
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Margin = new Padding(3, 0, 3, 3),
                    Text = Path.GetFileName(fileDirectories[i]),
                    Name = $"templateGroupBox{i}"
                };

                ListView lv = new ListView
                {
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    View = View.LargeIcon,
                    Name = $"templateListView{i}",
                    MultiSelect = true,
                    Scrollable = true,
                    FullRowSelect = true,
                    HideSelection = false,
                    CheckBoxes = true
                };

                // Prepare image list for large icons
                var imageList = new ImageList
                {
                    ImageSize = new Size(50, 50),
                    ColorDepth = ColorDepth.Depth32Bit
                };

                List<string> fileNames = FolderHandler.getFileNamesInDirectory(fileDirectories[i]);

                lv.BeginUpdate();
                lv.LargeImageList = imageList;

                for (int fi = 0; fi < fileNames.Count; fi++)
                {
                    string fileName = fileNames[fi];
                    string fullPath = Path.Combine(fileDirectories[i], fileName);

                    Image img = null;
                    try
                    {
                        if (File.Exists(fullPath))
                        {
                            var icon = Icon.ExtractAssociatedIcon(fullPath);
                            if (icon != null)
                                img = icon.ToBitmap();
                        }
                    }
                    catch { /* ignore icon extraction errors */ }

                    if (img == null)
                    {
                        // fallback: small transparent bitmap
                        var bmp = new Bitmap(imageList.ImageSize.Width, imageList.ImageSize.Height);
                        using (var g = Graphics.FromImage(bmp))
                        {
                            g.Clear(Color.Transparent);
                        }
                        img = bmp;
                    }

                    string key = fileName; // keys should be unique per image; filenames are usually fine
                    if (!imageList.Images.ContainsKey(key))
                        imageList.Images.Add(key, img);

                    var lvi = new ListViewItem(fileName) { ImageKey = key };
                    lv.Items.Add(lvi);
                }

                lv.EndUpdate();

                // Give the listview a sensible height so it can show multiple items; scale with item count
                int estimatedHeight = Math.Min(400, Math.Max(100, fileNames.Count * 22));
                lv.Height = estimatedHeight;

                // Add controls
                table.Controls.Add(gb, 0, i);
                gb.Controls.Add(lv);
            }

            table.ResumeLayout();
        }
    }
}
