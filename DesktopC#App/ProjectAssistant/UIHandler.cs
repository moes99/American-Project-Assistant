using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error populating list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
