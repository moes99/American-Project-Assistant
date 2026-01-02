namespace ProjectAssistant
{
    using FontAwesome.Sharp;
    using System.IO;
    using System.Windows.Forms;
    using System.Text.Json;
    using DotNetEnv;

    public partial class mainForm : Form
    {
        string basePath = Environment.GetEnvironmentVariable("PathToManagementFolder");//"C:/Users/Mohammad Omar Shehab/Desktop/American Project Assistant/DesktopC#App/Management/";
        string mainProjectFolder = Environment.GetEnvironmentVariable("PathToProjectParentFolder");//"\\\\192.168.1.224\\New8TB\\1-Projects In Hand";
        JsonElement functionJsonData;
        ProjectInfoJson projectInfoJson;
        public mainForm()
        {
            InitializeComponent();
            this.Shown += mainForm_Shown;

            //Get the list of countries from the JSON file and populate the countryList ComboBox
            countryList.SelectedIndex = 0;
            JsonElement addressJsonData = JsonFileHandler.readJson(basePath + "addressInfo.json");
            UIHandler.populateListFromJsonElement(countryList, addressJsonData, "Countries");

            //Get the list of states from the JSON file and populate the stateList ComboBox
            stateList.SelectedIndex = 0;
            stateList.Enabled = false;
            UIHandler.populateListFromJsonElement(stateList, addressJsonData, "States");

            //Get the list of scopes of work from the JSON file and populate the scopeList CheckedListBox
            JsonElement scopeJsonData = JsonFileHandler.readJson(basePath + "scopeOfWork.json");
            UIHandler.populateListFromJsonElement(scopeList, scopeJsonData, "ScopesOfWork");

            //Get the list of functions from the JSON file and populate the functionList ComboBox
            functionJsonData = JsonFileHandler.readJson(basePath + "buildingFunction.json");

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

            saveInfoButton.Enabled = false;
            resetInfoButton.Enabled = false;
        }

        private void newRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (newRButton.Checked)
            {
                projectPathTBox.Text = mainProjectFolder;
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
                saveInfoButton.Enabled = false;
                resetInfoButton.Enabled = false;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            UIHandler.changePanel(infoPane);
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
                    projectInfoJson = JsonFileHandler.jsonToObject<ProjectInfoJson>(projectPathTBox.Text, "projectInfo.json");
                    if (projectInfoJson != null)
                    {
                        //Populate the fields with existing data
                        clientTBox.Text = projectInfoJson.Client;
                        directorTBox.Text = projectInfoJson.Director;
                        managerTBox.Text = projectInfoJson.Manager;
                        //Scope of Work
                        for (int i = 0; i < scopeList.Items.Count; i++)
                        {
                            string itemText = scopeList.Items[i].ToString();
                            if (projectInfoJson.ScopeOfWork.Contains(itemText))
                            {
                                scopeList.SetItemChecked(i, true);
                                Control[] controls = developersTable.Controls.Find(itemText.ToLower() + "DevTBox", true);
                                foreach (string tradeDev in projectInfoJson.TradeDevelopers)
                                {
                                    if (tradeDev.StartsWith(itemText + ":"))
                                    {
                                        controls[0].Text = tradeDev.Substring(tradeDev.IndexOf(":") + 1).Trim();
                                    }
                                }
                            }
                        }
                        projectNameTBox.Text = projectInfoJson.ProjectName;
                        countryList.SelectedItem = projectInfoJson.Country;
                        if (projectInfoJson.Country == "USA")
                        {
                            stateList.Enabled = true;
                            stateList.SelectedItem = projectInfoJson.State;
                        }
                        fullAddressTBox.Text = projectInfoJson.FullAddress;
                        typeList.SelectedItem = projectInfoJson.BuilidngType;
                        functionList.SelectedItem = projectInfoJson.BuildingFunction;
                        conditionList.SelectedItem = projectInfoJson.BuildingCondition;
                        saveInfoButton.Enabled = true;
                        resetInfoButton.Enabled = true;
                    }
                }
                else
                {
                    setPathButton.BackColor = System.Drawing.Color.LightCoral;
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
            UIHandler.resetFields(projectInfoTable);
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            if (DataValidator.validateControls(projectInfoTable))
            {
                //Get values from the form
                string client = clientTBox.Text;
                string director = directorTBox.Text;
                string manager = managerTBox.Text;
                List<string> scopeOfWork = scopeList.CheckedItems.Cast<string>().ToList();
                List<string> tradeDevelopers = new List<string>();
                foreach (string scope in scopeOfWork)
                {
                    Control[] controls = developersTable.Controls.Find(scope.ToLower() + "DevTBox", true);
                    tradeDevelopers.Add($"{scope}: {controls[0].Text}");
                }
                string projectName = projectNameTBox.Text;
                string country = countryList.SelectedItem.ToString();
                string state = stateList.Enabled ? stateList.SelectedItem.ToString() : "N/A";
                string fullAddress = fullAddressTBox.Text;
                string buildingType = typeList.SelectedItem.ToString();
                string buildingFunction = functionList.SelectedItem.ToString();
                string buildingCondition = conditionList.SelectedItem.ToString();

                //Determine project path
                string projectPath = "";

                if (projectPathTBox.Text == mainProjectFolder) //This is a new project
                {
                    JsonElement projectNumberingJsonData = JsonFileHandler.readJson(basePath + "projectNumbering.json");
                    string countryPrefix = projectNumberingJsonData.GetProperty("CountryPrefix").GetProperty(country).GetString();
                    int projectNumber = projectNumberingJsonData.GetProperty("CurrentProjectNumber").GetProperty(country).GetInt32() + 1;
                    projectPath = $"{mainProjectFolder}/{countryPrefix}.{projectNumber}_{client} {projectName} {fullAddress} {string.Join(", ", scopeOfWork)}".Trim();
                    projectPathTBox.Text = projectPath;
                    folderPathLabel.Text = "Project Path:";
                }
                else
                {
                    projectPath = projectPathTBox.Text;
                }
                projectInfoJson = new ProjectInfoJson(client, director, manager, scopeOfWork, tradeDevelopers, projectName, country, state, fullAddress, buildingType, buildingFunction, buildingCondition);
                bool writeResult = JsonFileHandler.writeJson(projectPath, "projectInfo.json", projectInfoJson);
                if (writeResult)
                {
                    MessageBox.Show("Project information has been saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the project information.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void typeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = typeList.SelectedItem.ToString();
            functionList.Items.Clear();
            functionList.Items.Add("Not Selected");
            functionList.SelectedIndex = 0;
            if (selectedType != "Not Selected")
            {
                UIHandler.populateListFromJsonElement(functionList, functionJsonData, selectedType);
            }
        }
    }
}
