namespace ProjectAssistant
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderButton = new FontAwesome.Sharp.IconButton();
            infoButton = new FontAwesome.Sharp.IconButton();
            templateButton = new FontAwesome.Sharp.IconButton();
            infoPane = new FlowLayoutPanel();
            projectStatusBox = new GroupBox();
            projectStatusTable = new TableLayoutPanel();
            newRButton = new RadioButton();
            existingRButton = new RadioButton();
            folderPathLabel = new Label();
            projectPathTBox = new TextBox();
            controlGroup = new GroupBox();
            controlTable = new TableLayoutPanel();
            datasheetButton = new FontAwesome.Sharp.IconButton();
            infoPane.SuspendLayout();
            projectStatusBox.SuspendLayout();
            projectStatusTable.SuspendLayout();
            controlGroup.SuspendLayout();
            controlTable.SuspendLayout();
            SuspendLayout();
            // 
            // folderButton
            // 
            folderButton.Dock = DockStyle.Fill;
            folderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderButton.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            folderButton.IconColor = Color.Black;
            folderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            folderButton.IconSize = 35;
            folderButton.ImageAlign = ContentAlignment.MiddleLeft;
            folderButton.Location = new Point(3, 49);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(188, 40);
            folderButton.TabIndex = 1;
            folderButton.Text = "Folders";
            folderButton.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            infoButton.Dock = DockStyle.Fill;
            infoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            infoButton.IconColor = Color.Black;
            infoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            infoButton.IconSize = 30;
            infoButton.ImageAlign = ContentAlignment.MiddleLeft;
            infoButton.Location = new Point(3, 3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(188, 40);
            infoButton.TabIndex = 3;
            infoButton.Text = "Project Info";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // templateButton
            // 
            templateButton.Dock = DockStyle.Fill;
            templateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            templateButton.IconChar = FontAwesome.Sharp.IconChar.File;
            templateButton.IconColor = Color.Black;
            templateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            templateButton.IconSize = 30;
            templateButton.ImageAlign = ContentAlignment.MiddleLeft;
            templateButton.Location = new Point(3, 95);
            templateButton.Name = "templateButton";
            templateButton.Size = new Size(188, 40);
            templateButton.TabIndex = 2;
            templateButton.Text = "Templates";
            templateButton.UseVisualStyleBackColor = true;
            // 
            // infoPane
            // 
            infoPane.Controls.Add(projectStatusBox);
            infoPane.Dock = DockStyle.Fill;
            infoPane.FlowDirection = FlowDirection.TopDown;
            infoPane.Location = new Point(200, 0);
            infoPane.Name = "infoPane";
            infoPane.Size = new Size(1003, 664);
            infoPane.TabIndex = 3;
            infoPane.Visible = false;
            infoPane.WrapContents = false;
            infoPane.SizeChanged += infoPane_SizeChanged;
            // 
            // projectStatusBox
            // 
            projectStatusBox.Controls.Add(projectStatusTable);
            projectStatusBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectStatusBox.Location = new Point(3, 0);
            projectStatusBox.Margin = new Padding(3, 0, 3, 3);
            projectStatusBox.Name = "projectStatusBox";
            projectStatusBox.Size = new Size(1000, 68);
            projectStatusBox.TabIndex = 0;
            projectStatusBox.TabStop = false;
            projectStatusBox.Text = "Project Status";
            // 
            // projectStatusTable
            // 
            projectStatusTable.ColumnCount = 4;
            projectStatusTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            projectStatusTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            projectStatusTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            projectStatusTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            projectStatusTable.Controls.Add(newRButton, 1, 0);
            projectStatusTable.Controls.Add(existingRButton, 0, 0);
            projectStatusTable.Controls.Add(folderPathLabel, 2, 0);
            projectStatusTable.Controls.Add(projectPathTBox, 3, 0);
            projectStatusTable.Dock = DockStyle.Fill;
            projectStatusTable.Location = new Point(3, 25);
            projectStatusTable.Name = "projectStatusTable";
            projectStatusTable.RowCount = 1;
            projectStatusTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            projectStatusTable.Size = new Size(994, 40);
            projectStatusTable.TabIndex = 1;
            // 
            // newRButton
            // 
            newRButton.Anchor = AnchorStyles.None;
            newRButton.AutoSize = true;
            newRButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newRButton.Location = new Point(93, 3);
            newRButton.MinimumSize = new Size(63, 34);
            newRButton.Name = "newRButton";
            newRButton.Size = new Size(63, 34);
            newRButton.TabIndex = 1;
            newRButton.TabStop = true;
            newRButton.Text = "New";
            newRButton.UseVisualStyleBackColor = true;
            newRButton.CheckedChanged += newRButton_CheckedChanged;
            // 
            // existingRButton
            // 
            existingRButton.Anchor = AnchorStyles.None;
            existingRButton.AutoSize = true;
            existingRButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            existingRButton.Location = new Point(8, 3);
            existingRButton.MinimumSize = new Size(73, 34);
            existingRButton.Name = "existingRButton";
            existingRButton.Size = new Size(73, 34);
            existingRButton.TabIndex = 0;
            existingRButton.TabStop = true;
            existingRButton.Text = "Existing";
            existingRButton.UseVisualStyleBackColor = true;
            existingRButton.CheckedChanged += existingRButton_CheckedChanged;
            // 
            // folderPathLabel
            // 
            folderPathLabel.AutoSize = true;
            folderPathLabel.Dock = DockStyle.Fill;
            folderPathLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPathLabel.Location = new Point(163, 3);
            folderPathLabel.Margin = new Padding(3);
            folderPathLabel.MinimumSize = new Size(93, 34);
            folderPathLabel.Name = "folderPathLabel";
            folderPathLabel.Size = new Size(94, 34);
            folderPathLabel.TabIndex = 3;
            folderPathLabel.Text = "Project Path:";
            folderPathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // projectPathTBox
            // 
            projectPathTBox.Dock = DockStyle.Fill;
            projectPathTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectPathTBox.Location = new Point(263, 3);
            projectPathTBox.Multiline = true;
            projectPathTBox.Name = "projectPathTBox";
            projectPathTBox.PlaceholderText = "Project Path";
            projectPathTBox.ShortcutsEnabled = false;
            projectPathTBox.Size = new Size(728, 34);
            projectPathTBox.TabIndex = 4;
            // 
            // controlGroup
            // 
            controlGroup.Controls.Add(controlTable);
            controlGroup.Dock = DockStyle.Left;
            controlGroup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlGroup.Location = new Point(0, 0);
            controlGroup.Name = "controlGroup";
            controlGroup.Size = new Size(200, 664);
            controlGroup.TabIndex = 4;
            controlGroup.TabStop = false;
            controlGroup.Text = "Controls";
            // 
            // controlTable
            // 
            controlTable.ColumnCount = 1;
            controlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlTable.Controls.Add(datasheetButton, 0, 3);
            controlTable.Controls.Add(infoButton, 0, 0);
            controlTable.Controls.Add(templateButton, 0, 2);
            controlTable.Controls.Add(folderButton, 0, 1);
            controlTable.Dock = DockStyle.Fill;
            controlTable.Location = new Point(3, 25);
            controlTable.Name = "controlTable";
            controlTable.RowCount = 5;
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            controlTable.Size = new Size(194, 636);
            controlTable.TabIndex = 0;
            // 
            // datasheetButton
            // 
            datasheetButton.Dock = DockStyle.Fill;
            datasheetButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datasheetButton.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            datasheetButton.IconColor = Color.Black;
            datasheetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            datasheetButton.IconSize = 30;
            datasheetButton.ImageAlign = ContentAlignment.MiddleLeft;
            datasheetButton.Location = new Point(3, 141);
            datasheetButton.Name = "datasheetButton";
            datasheetButton.Size = new Size(188, 40);
            datasheetButton.TabIndex = 4;
            datasheetButton.Text = "Datasheets";
            datasheetButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 664);
            Controls.Add(infoPane);
            Controls.Add(controlGroup);
            MinimumSize = new Size(1000, 700);
            Name = "mainForm";
            Text = "Project Assistant";
            infoPane.ResumeLayout(false);
            projectStatusBox.ResumeLayout(false);
            projectStatusTable.ResumeLayout(false);
            projectStatusTable.PerformLayout();
            controlGroup.ResumeLayout(false);
            controlTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton folderButton;
        private FontAwesome.Sharp.IconButton templateButton;
        private FontAwesome.Sharp.IconButton infoButton;
        private FlowLayoutPanel infoPane;
        private GroupBox projectStatusBox;
        private RadioButton existingRButton;
        private TableLayoutPanel projectStatusTable;
        private RadioButton newRButton;
        private GroupBox controlGroup;
        private TableLayoutPanel controlTable;
        private Label folderPathLabel;
        private TextBox projectPathTBox;
        private FontAwesome.Sharp.IconButton datasheetButton;
    }
}
