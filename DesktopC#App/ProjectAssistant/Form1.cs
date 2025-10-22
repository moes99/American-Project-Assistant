namespace ProjectAssistant
{
    using FontAwesome.Sharp;
    public partial class mainForm : Form
    {
        TableLayoutPanel currentPane = new TableLayoutPanel();
        public mainForm()
        {
            InitializeComponent();
            currentPane = infoPane;
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
            }
        }

        private void existingRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (existingRButton.Checked)
            {
                projectPathTBox.Text = "";
                projectPathTBox.Enabled = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            changePanel(infoPane);
        }
    }
}
