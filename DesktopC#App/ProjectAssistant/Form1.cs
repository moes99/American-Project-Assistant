namespace ProjectAssistant
{
    using FontAwesome.Sharp;
    using System.IO;
    using System.Windows.Forms;

    public partial class mainForm : Form
    {
        TableLayoutPanel currentPane = new TableLayoutPanel();
        public mainForm()
        {
            InitializeComponent();
            currentPane = infoPane;
            this.Shown += mainForm_Shown;
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
            string itemText = scopeList.Items[e.Index].ToString();
            switch (itemText)
            {
                case "Mechanical":
                    mechDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    mechDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "Electrical":
                    elecDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    elecDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "Plumbing":
                    plumbDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    plumbDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "Fire Protection":
                    fireDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    fireDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "T24/Energy":
                    engDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    engDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "Structure":
                    structDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    structDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;

                case "Architecture":
                    archDevTBox.Enabled = e.NewValue == CheckState.Checked;
                    archDevLabel.Enabled = e.NewValue == CheckState.Checked;
                    break;
            }
        }
    }
}
