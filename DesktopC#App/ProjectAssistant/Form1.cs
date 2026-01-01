namespace ProjectAssistant
{
    using FontAwesome.Sharp;
    using System.IO;
    using System.Windows.Forms;
    using System.Text.Json;

    public partial class mainForm : Form
    {
        TableLayoutPanel currentPane = new TableLayoutPanel();
        string basePath = "C:/Users/Mohammad Omar Shehab/Desktop/American Project Assistant/DesktopC#App/Management/";
        public mainForm()
        {
            InitializeComponent();
            currentPane = infoPane;
            this.Shown += mainForm_Shown;

            //Get the list of countries from the JSON file and populate the countryList ComboBox
            countryList.SelectedIndex = 0;
            JsonElement addressJsonData = readJson(basePath + "addressInfo.json");
            JsonElement countries = addressJsonData.GetProperty("Countries");
            foreach (JsonElement country in countries.EnumerateArray())
            {
                countryList.Items.Add(country.GetString());
            }

            //Get the list of states from the JSON file and populate the stateList ComboBox
            stateList.SelectedIndex = 0;
            stateList.Enabled = false;
            JsonElement states = addressJsonData.GetProperty("States");
            foreach (JsonElement state in states.EnumerateArray())
            {
                stateList.Items.Add(state.GetString());
            }

            //Get the list of scopes of work from the JSON file and populate the scopeList CheckedListBox
            JsonElement scopeJsonData = readJson(basePath + "scopeOfWork.json");
            JsonElement scopes = scopeJsonData.GetProperty("ScopesOfWork");
            foreach (JsonElement scope in scopes.EnumerateArray())
            {
                scopeList.Items.Add(scope.GetString());
            }

            //Add labels and textboxes for each scope of work dynamically
            developersTable.RowCount = scopeList.Items.Count;
            for (int i = 0; i < scopeList.Items.Count; i++)
            {
                Label scopeLabel = new Label
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Enabled = false,
                    Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = scopeList.Items[i].ToString() + ":",
                    Name = scopeList.Items[i].ToString().ToLower() + "DevLabel",
                };
                TextBox scopeTBox = new TextBox
                {
                    Dock = DockStyle.Fill,
                    Enabled = false,
                    Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Multiline = true,
                    Name = scopeList.Items[i].ToString().ToLower() + "DevTBox",
                    PlaceholderText = scopeList.Items[i].ToString() + " Developer(s)"
                };
                developersTable.Controls.Add(scopeLabel, 0, i);
                developersTable.Controls.Add(scopeTBox, 1, i);
            }

            typeList.SelectedIndex = 0;
            functionList.SelectedIndex = 0;
            conditionList.SelectedIndex = 0;
        }

        // Method to change the visible panel
        private void changePanel(TableLayoutPanel newPane)
        {
            if (currentPane != null)
            {
                currentPane.Visible = false;
            }
            currentPane = newPane;
            currentPane.Visible = true;
        }

        private void newRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (newRButton.Checked)
            {
                projectPathTBox.Text = "\\\\192.168.1.224\\New8TB\\1-Projects In Hand";
                projectPathTBox.Enabled = false;
                folderPathLabel.Text = "Parent Path:";
                setPathButton.Enabled = false;
                projectInfoBox.Enabled = true;
            }
        }

        private void existingRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (existingRButton.Checked)
            {
                projectPathTBox.Text = "";
                projectPathTBox.Enabled = true;
                setPathButton.Enabled = true;
                folderPathLabel.Text = "Project Path:";
                projectInfoBox.Enabled = false;
                resetInfoButton.Enabled = false;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            changePanel(infoPane);
        }

        private void projectAddressTable_Paint(object sender, PaintEventArgs e)
        {

        }

        // Shown event handler: focus the infoButton after the form is displayed
        private void mainForm_Shown(object sender, System.EventArgs e)
        {
            this.Shown -= mainForm_Shown;
            this.BeginInvoke((System.Action)(() => infoButton.Focus()));
        }

        private void setPathButton_Click(object sender, EventArgs e)
        {
            if (projectPathTBox.Text != "")
            {
                if (Directory.Exists(projectPathTBox.Text))
                {
                    setPathButton.BackColor = System.Drawing.Color.LightGreen;
                    projectInfoBox.Enabled = true;
                    MessageBox.Show("Path has been set successfully.", "Valid Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setPathButton.BackColor = System.Drawing.Color.PaleVioletRed;
                    projectInfoBox.Enabled = false;
                    MessageBox.Show("The specified folder does not exist! Please enter a valid path.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void scopeList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemText = scopeList.Items[e.Index].ToString().ToLower();
            Control[] controls = developersTable.Controls.Find(itemText + "DevLabel", true);
            controls[0].Enabled = e.NewValue == CheckState.Checked;
            controls = developersTable.Controls.Find(itemText + "DevTBox", true);
            controls[0].Enabled = e.NewValue == CheckState.Checked;
        }

        private JsonElement readJson(string path)
        {
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                using var document = JsonDocument.Parse(jsonString);
                return document.RootElement.Clone();
            }
            else
            {
                MessageBox.Show("The JSON file at path: " + path + " does not exist!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new JsonElement();
            }
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryList.SelectedItem.ToString() == "USA")
            {
                stateList.Enabled = true;
            }
            else
            {
                stateList.Enabled = false;
                stateList.SelectedIndex = 0;
            }
        }
        private void resetInfoButton_Click(object sender, EventArgs e)
        {
            resetFields(projectInfoTable);
        }
        private void resetFields(Control item)
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
    }
}
