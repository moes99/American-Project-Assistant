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
            projectPathBox = new GroupBox();
            projectPathTable = new TableLayoutPanel();
            newRButton = new RadioButton();
            existingRButton = new RadioButton();
            folderPathLabel = new Label();
            projectPathTBox = new TextBox();
            setPathButton = new FontAwesome.Sharp.IconButton();
            controlGroup = new GroupBox();
            controlTable = new TableLayoutPanel();
            datasheetButton = new FontAwesome.Sharp.IconButton();
            infoPane = new TableLayoutPanel();
            projectInfoBox = new GroupBox();
            projectInfoTable = new TableLayoutPanel();
            buildingBox = new GroupBox();
            buildingTable = new TableLayoutPanel();
            conditionLabel = new Label();
            conditionList = new ComboBox();
            functionLabel = new Label();
            functionList = new ComboBox();
            typeLabel = new Label();
            typeList = new ComboBox();
            projectAddressBox = new GroupBox();
            projectAddressTable = new TableLayoutPanel();
            fullAddressTBox = new TextBox();
            fullAddressLabel = new Label();
            stateList = new ComboBox();
            stateLabel = new Label();
            countryLabel = new Label();
            projectNameTBox = new TextBox();
            projectNameLabel = new Label();
            countryList = new ComboBox();
            managementBox = new GroupBox();
            managementTable = new TableLayoutPanel();
            developersLabel = new Label();
            developersTable = new TableLayoutPanel();
            archDevTBox = new TextBox();
            archDevLabel = new Label();
            structDevTBox = new TextBox();
            structDevLabel = new Label();
            engDevTBox = new TextBox();
            engDevLabel = new Label();
            fireDevTBox = new TextBox();
            fireDevLabel = new Label();
            plumbDevTBox = new TextBox();
            plumbDevLabel = new Label();
            elecDevTBox = new TextBox();
            elecDevLabel = new Label();
            mechDevTBox = new TextBox();
            mechDevLabel = new Label();
            scopeLabel = new Label();
            scopeList = new CheckedListBox();
            managerLabel = new Label();
            managerTBox = new TextBox();
            directorLabel = new Label();
            directorTBox = new TextBox();
            clientLabel = new Label();
            clientTBox = new TextBox();
            infoControlButtonsTable = new TableLayoutPanel();
            resetInfoButton = new FontAwesome.Sharp.IconButton();
            saveInfoButton = new FontAwesome.Sharp.IconButton();
            projectPathBox.SuspendLayout();
            projectPathTable.SuspendLayout();
            controlGroup.SuspendLayout();
            controlTable.SuspendLayout();
            infoPane.SuspendLayout();
            projectInfoBox.SuspendLayout();
            projectInfoTable.SuspendLayout();
            buildingBox.SuspendLayout();
            buildingTable.SuspendLayout();
            projectAddressBox.SuspendLayout();
            projectAddressTable.SuspendLayout();
            managementBox.SuspendLayout();
            managementTable.SuspendLayout();
            developersTable.SuspendLayout();
            infoControlButtonsTable.SuspendLayout();
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
            // projectPathBox
            // 
            projectPathBox.Controls.Add(projectPathTable);
            projectPathBox.Dock = DockStyle.Fill;
            projectPathBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectPathBox.Location = new Point(3, 0);
            projectPathBox.Margin = new Padding(3, 0, 3, 3);
            projectPathBox.Name = "projectPathBox";
            projectPathBox.Size = new Size(997, 67);
            projectPathBox.TabIndex = 0;
            projectPathBox.TabStop = false;
            projectPathBox.Text = "Project Path";
            // 
            // projectPathTable
            // 
            projectPathTable.ColumnCount = 5;
            projectPathTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            projectPathTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            projectPathTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            projectPathTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            projectPathTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            projectPathTable.Controls.Add(newRButton, 1, 0);
            projectPathTable.Controls.Add(existingRButton, 0, 0);
            projectPathTable.Controls.Add(folderPathLabel, 2, 0);
            projectPathTable.Controls.Add(projectPathTBox, 3, 0);
            projectPathTable.Controls.Add(setPathButton, 4, 0);
            projectPathTable.Dock = DockStyle.Fill;
            projectPathTable.Location = new Point(3, 25);
            projectPathTable.Name = "projectPathTable";
            projectPathTable.RowCount = 1;
            projectPathTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            projectPathTable.Size = new Size(991, 39);
            projectPathTable.TabIndex = 1;
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
            projectPathTBox.Size = new Size(685, 33);
            projectPathTBox.TabIndex = 4;
            // 
            // setPathButton
            // 
            setPathButton.Dock = DockStyle.Fill;
            setPathButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            setPathButton.IconColor = Color.Black;
            setPathButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            setPathButton.IconSize = 30;
            setPathButton.Location = new Point(954, 3);
            setPathButton.Name = "setPathButton";
            setPathButton.Rotation = -5D;
            setPathButton.Size = new Size(34, 33);
            setPathButton.TabIndex = 5;
            setPathButton.UseVisualStyleBackColor = true;
            setPathButton.Click += setPathButton_Click;
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
            controlTable.Controls.Add(templateButton, 0, 2);
            controlTable.Controls.Add(folderButton, 0, 1);
            controlTable.Controls.Add(infoButton, 0, 0);
            controlTable.Dock = DockStyle.Fill;
            controlTable.Location = new Point(3, 25);
            controlTable.Name = "controlTable";
            controlTable.RowCount = 10;
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
            controlTable.RowStyles.Add(new RowStyle());
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
            // infoPane
            // 
            infoPane.ColumnCount = 1;
            infoPane.ColumnStyles.Add(new ColumnStyle());
            infoPane.Controls.Add(projectInfoBox, 0, 1);
            infoPane.Controls.Add(projectPathBox, 0, 0);
            infoPane.Controls.Add(infoControlButtonsTable, 0, 2);
            infoPane.Dock = DockStyle.Fill;
            infoPane.Location = new Point(200, 0);
            infoPane.Name = "infoPane";
            infoPane.RowCount = 3;
            infoPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            infoPane.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            infoPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            infoPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoPane.Size = new Size(1003, 664);
            infoPane.TabIndex = 1;
            infoPane.Visible = false;
            // 
            // projectInfoBox
            // 
            projectInfoBox.Controls.Add(projectInfoTable);
            projectInfoBox.Dock = DockStyle.Fill;
            projectInfoBox.Enabled = false;
            projectInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectInfoBox.Location = new Point(3, 70);
            projectInfoBox.Margin = new Padding(3, 0, 3, 3);
            projectInfoBox.Name = "projectInfoBox";
            projectInfoBox.Size = new Size(997, 551);
            projectInfoBox.TabIndex = 1;
            projectInfoBox.TabStop = false;
            projectInfoBox.Text = "Project Information";
            // 
            // projectInfoTable
            // 
            projectInfoTable.ColumnCount = 2;
            projectInfoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            projectInfoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            projectInfoTable.Controls.Add(buildingBox, 1, 1);
            projectInfoTable.Controls.Add(projectAddressBox, 1, 0);
            projectInfoTable.Controls.Add(managementBox, 0, 0);
            projectInfoTable.Dock = DockStyle.Fill;
            projectInfoTable.Location = new Point(3, 25);
            projectInfoTable.Name = "projectInfoTable";
            projectInfoTable.RowCount = 3;
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 39.99847F));
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 26.0028286F));
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.9987F));
            projectInfoTable.Size = new Size(991, 523);
            projectInfoTable.TabIndex = 1;
            // 
            // buildingBox
            // 
            buildingBox.Controls.Add(buildingTable);
            buildingBox.Dock = DockStyle.Fill;
            buildingBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buildingBox.Location = new Point(597, 212);
            buildingBox.Name = "buildingBox";
            buildingBox.Size = new Size(391, 129);
            buildingBox.TabIndex = 3;
            buildingBox.TabStop = false;
            buildingBox.Text = "Building State";
            // 
            // buildingTable
            // 
            buildingTable.ColumnCount = 2;
            buildingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            buildingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buildingTable.Controls.Add(conditionLabel, 0, 2);
            buildingTable.Controls.Add(conditionList, 1, 2);
            buildingTable.Controls.Add(functionLabel, 0, 1);
            buildingTable.Controls.Add(functionList, 1, 1);
            buildingTable.Controls.Add(typeLabel, 0, 0);
            buildingTable.Controls.Add(typeList, 1, 0);
            buildingTable.Dock = DockStyle.Fill;
            buildingTable.Location = new Point(3, 25);
            buildingTable.Name = "buildingTable";
            buildingTable.RowCount = 3;
            buildingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            buildingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            buildingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            buildingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            buildingTable.Size = new Size(385, 101);
            buildingTable.TabIndex = 1;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Dock = DockStyle.Fill;
            conditionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            conditionLabel.Location = new Point(10, 66);
            conditionLabel.Margin = new Padding(10, 0, 0, 0);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(110, 35);
            conditionLabel.TabIndex = 8;
            conditionLabel.Text = "Condition:";
            conditionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // conditionList
            // 
            conditionList.Dock = DockStyle.Fill;
            conditionList.DropDownStyle = ComboBoxStyle.DropDownList;
            conditionList.Font = new Font("Segoe UI", 9.75F);
            conditionList.FormattingEnabled = true;
            conditionList.Items.AddRange(new object[] { "Not Selected", "New", "Existing" });
            conditionList.Location = new Point(123, 69);
            conditionList.Name = "conditionList";
            conditionList.Size = new Size(259, 25);
            conditionList.TabIndex = 9;
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Dock = DockStyle.Fill;
            functionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            functionLabel.Location = new Point(10, 33);
            functionLabel.Margin = new Padding(10, 0, 0, 0);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new Size(110, 33);
            functionLabel.TabIndex = 6;
            functionLabel.Text = "Function:";
            functionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // functionList
            // 
            functionList.Dock = DockStyle.Fill;
            functionList.DropDownStyle = ComboBoxStyle.DropDownList;
            functionList.Font = new Font("Segoe UI", 9.75F);
            functionList.FormattingEnabled = true;
            functionList.Location = new Point(123, 36);
            functionList.Name = "functionList";
            functionList.Size = new Size(259, 25);
            functionList.TabIndex = 7;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Dock = DockStyle.Fill;
            typeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            typeLabel.Location = new Point(10, 0);
            typeLabel.Margin = new Padding(10, 0, 0, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(110, 33);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Type:";
            typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typeList
            // 
            typeList.Dock = DockStyle.Fill;
            typeList.DropDownStyle = ComboBoxStyle.DropDownList;
            typeList.Font = new Font("Segoe UI", 9.75F);
            typeList.FormattingEnabled = true;
            typeList.Items.AddRange(new object[] { "Not Selected", "Residential", "Commercial" });
            typeList.Location = new Point(123, 3);
            typeList.Name = "typeList";
            typeList.Size = new Size(259, 25);
            typeList.TabIndex = 12;
            // 
            // projectAddressBox
            // 
            projectAddressBox.Controls.Add(projectAddressTable);
            projectAddressBox.Dock = DockStyle.Fill;
            projectAddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectAddressBox.Location = new Point(597, 3);
            projectAddressBox.Name = "projectAddressBox";
            projectAddressBox.Size = new Size(391, 203);
            projectAddressBox.TabIndex = 2;
            projectAddressBox.TabStop = false;
            projectAddressBox.Text = "Address";
            // 
            // projectAddressTable
            // 
            projectAddressTable.ColumnCount = 2;
            projectAddressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            projectAddressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            projectAddressTable.Controls.Add(fullAddressTBox, 1, 3);
            projectAddressTable.Controls.Add(fullAddressLabel, 0, 3);
            projectAddressTable.Controls.Add(stateList, 1, 2);
            projectAddressTable.Controls.Add(stateLabel, 0, 2);
            projectAddressTable.Controls.Add(countryLabel, 0, 1);
            projectAddressTable.Controls.Add(projectNameTBox, 1, 0);
            projectAddressTable.Controls.Add(projectNameLabel, 0, 0);
            projectAddressTable.Controls.Add(countryList, 1, 1);
            projectAddressTable.Dock = DockStyle.Fill;
            projectAddressTable.Location = new Point(3, 25);
            projectAddressTable.Name = "projectAddressTable";
            projectAddressTable.RowCount = 4;
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            projectAddressTable.Size = new Size(385, 175);
            projectAddressTable.TabIndex = 1;
            projectAddressTable.Paint += projectAddressTable_Paint;
            // 
            // fullAddressTBox
            // 
            fullAddressTBox.Dock = DockStyle.Fill;
            fullAddressTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullAddressTBox.Location = new Point(123, 102);
            fullAddressTBox.Multiline = true;
            fullAddressTBox.Name = "fullAddressTBox";
            fullAddressTBox.PlaceholderText = "Full Address";
            fullAddressTBox.Size = new Size(259, 70);
            fullAddressTBox.TabIndex = 11;
            // 
            // fullAddressLabel
            // 
            fullAddressLabel.AutoSize = true;
            fullAddressLabel.Dock = DockStyle.Fill;
            fullAddressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            fullAddressLabel.Location = new Point(10, 99);
            fullAddressLabel.Margin = new Padding(10, 0, 0, 0);
            fullAddressLabel.Name = "fullAddressLabel";
            fullAddressLabel.Size = new Size(110, 76);
            fullAddressLabel.TabIndex = 10;
            fullAddressLabel.Text = "Full Address: ";
            fullAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stateList
            // 
            stateList.Dock = DockStyle.Fill;
            stateList.DropDownStyle = ComboBoxStyle.DropDownList;
            stateList.Font = new Font("Segoe UI", 9.75F);
            stateList.FormattingEnabled = true;
            stateList.Location = new Point(123, 69);
            stateList.Name = "stateList";
            stateList.Size = new Size(259, 25);
            stateList.TabIndex = 9;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Dock = DockStyle.Fill;
            stateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            stateLabel.Location = new Point(10, 66);
            stateLabel.Margin = new Padding(10, 0, 0, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(110, 33);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State:";
            stateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Dock = DockStyle.Fill;
            countryLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            countryLabel.Location = new Point(10, 33);
            countryLabel.Margin = new Padding(10, 0, 0, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(110, 33);
            countryLabel.TabIndex = 6;
            countryLabel.Text = "Country:";
            countryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // projectNameTBox
            // 
            projectNameTBox.Dock = DockStyle.Fill;
            projectNameTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectNameTBox.Location = new Point(123, 3);
            projectNameTBox.Multiline = true;
            projectNameTBox.Name = "projectNameTBox";
            projectNameTBox.PlaceholderText = "Name";
            projectNameTBox.Size = new Size(259, 27);
            projectNameTBox.TabIndex = 5;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Dock = DockStyle.Fill;
            projectNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            projectNameLabel.Location = new Point(10, 0);
            projectNameLabel.Margin = new Padding(10, 0, 0, 0);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(110, 33);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Name:";
            projectNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // countryList
            // 
            countryList.Dock = DockStyle.Fill;
            countryList.DropDownStyle = ComboBoxStyle.DropDownList;
            countryList.Font = new Font("Segoe UI", 9.75F);
            countryList.FormattingEnabled = true;
            countryList.Location = new Point(123, 36);
            countryList.Name = "countryList";
            countryList.Size = new Size(259, 25);
            countryList.TabIndex = 7;
            // 
            // managementBox
            // 
            managementBox.Controls.Add(managementTable);
            managementBox.Dock = DockStyle.Fill;
            managementBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managementBox.Location = new Point(3, 3);
            managementBox.Name = "managementBox";
            projectInfoTable.SetRowSpan(managementBox, 3);
            managementBox.Size = new Size(588, 517);
            managementBox.TabIndex = 4;
            managementBox.TabStop = false;
            managementBox.Text = "Management";
            // 
            // managementTable
            // 
            managementTable.ColumnCount = 2;
            managementTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            managementTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            managementTable.Controls.Add(developersLabel, 0, 4);
            managementTable.Controls.Add(developersTable, 1, 4);
            managementTable.Controls.Add(scopeLabel, 0, 3);
            managementTable.Controls.Add(scopeList, 1, 3);
            managementTable.Controls.Add(managerLabel, 0, 2);
            managementTable.Controls.Add(managerTBox, 1, 2);
            managementTable.Controls.Add(directorLabel, 0, 1);
            managementTable.Controls.Add(directorTBox, 1, 1);
            managementTable.Controls.Add(clientLabel, 0, 0);
            managementTable.Controls.Add(clientTBox, 1, 0);
            managementTable.Dock = DockStyle.Fill;
            managementTable.Location = new Point(3, 25);
            managementTable.Name = "managementTable";
            managementTable.RowCount = 5;
            managementTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            managementTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            managementTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            managementTable.RowStyles.Add(new RowStyle());
            managementTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            managementTable.Size = new Size(582, 489);
            managementTable.TabIndex = 1;
            // 
            // developersLabel
            // 
            developersLabel.AutoSize = true;
            developersLabel.Dock = DockStyle.Fill;
            developersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            developersLabel.Location = new Point(10, 172);
            developersLabel.Margin = new Padding(10, 0, 0, 0);
            developersLabel.Name = "developersLabel";
            developersLabel.Size = new Size(130, 317);
            developersLabel.TabIndex = 16;
            developersLabel.Text = "Trade Developers:";
            developersLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // developersTable
            // 
            developersTable.ColumnCount = 2;
            developersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            developersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            developersTable.Controls.Add(archDevTBox, 1, 6);
            developersTable.Controls.Add(archDevLabel, 0, 6);
            developersTable.Controls.Add(structDevTBox, 1, 5);
            developersTable.Controls.Add(structDevLabel, 0, 5);
            developersTable.Controls.Add(engDevTBox, 1, 4);
            developersTable.Controls.Add(engDevLabel, 0, 4);
            developersTable.Controls.Add(fireDevTBox, 1, 3);
            developersTable.Controls.Add(fireDevLabel, 0, 3);
            developersTable.Controls.Add(plumbDevTBox, 1, 2);
            developersTable.Controls.Add(plumbDevLabel, 0, 2);
            developersTable.Controls.Add(elecDevTBox, 1, 1);
            developersTable.Controls.Add(elecDevLabel, 0, 1);
            developersTable.Controls.Add(mechDevTBox, 1, 0);
            developersTable.Controls.Add(mechDevLabel, 0, 0);
            developersTable.Dock = DockStyle.Fill;
            developersTable.Location = new Point(143, 175);
            developersTable.Name = "developersTable";
            developersTable.RowCount = 7;
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.Size = new Size(436, 311);
            developersTable.TabIndex = 17;
            // 
            // archDevTBox
            // 
            archDevTBox.Dock = DockStyle.Fill;
            archDevTBox.Enabled = false;
            archDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archDevTBox.Location = new Point(112, 267);
            archDevTBox.Multiline = true;
            archDevTBox.Name = "archDevTBox";
            archDevTBox.PlaceholderText = "Architecture Developer";
            archDevTBox.Size = new Size(321, 41);
            archDevTBox.TabIndex = 25;
            // 
            // archDevLabel
            // 
            archDevLabel.AutoSize = true;
            archDevLabel.Dock = DockStyle.Fill;
            archDevLabel.Enabled = false;
            archDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archDevLabel.Location = new Point(0, 264);
            archDevLabel.Margin = new Padding(0);
            archDevLabel.Name = "archDevLabel";
            archDevLabel.Size = new Size(109, 47);
            archDevLabel.TabIndex = 24;
            archDevLabel.Text = "Architecture:";
            archDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // structDevTBox
            // 
            structDevTBox.Dock = DockStyle.Fill;
            structDevTBox.Enabled = false;
            structDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            structDevTBox.Location = new Point(112, 223);
            structDevTBox.Multiline = true;
            structDevTBox.Name = "structDevTBox";
            structDevTBox.PlaceholderText = "Structure Developer";
            structDevTBox.Size = new Size(321, 38);
            structDevTBox.TabIndex = 23;
            // 
            // structDevLabel
            // 
            structDevLabel.AutoSize = true;
            structDevLabel.Dock = DockStyle.Fill;
            structDevLabel.Enabled = false;
            structDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            structDevLabel.Location = new Point(0, 220);
            structDevLabel.Margin = new Padding(0);
            structDevLabel.Name = "structDevLabel";
            structDevLabel.Size = new Size(109, 44);
            structDevLabel.TabIndex = 22;
            structDevLabel.Text = "Structure:";
            structDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // engDevTBox
            // 
            engDevTBox.Dock = DockStyle.Fill;
            engDevTBox.Enabled = false;
            engDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            engDevTBox.Location = new Point(112, 179);
            engDevTBox.Multiline = true;
            engDevTBox.Name = "engDevTBox";
            engDevTBox.PlaceholderText = "T24/Energy Developer";
            engDevTBox.Size = new Size(321, 38);
            engDevTBox.TabIndex = 21;
            // 
            // engDevLabel
            // 
            engDevLabel.AutoSize = true;
            engDevLabel.Dock = DockStyle.Fill;
            engDevLabel.Enabled = false;
            engDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            engDevLabel.Location = new Point(0, 176);
            engDevLabel.Margin = new Padding(0);
            engDevLabel.Name = "engDevLabel";
            engDevLabel.Size = new Size(109, 44);
            engDevLabel.TabIndex = 20;
            engDevLabel.Text = "T24/Energy:";
            engDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fireDevTBox
            // 
            fireDevTBox.Dock = DockStyle.Fill;
            fireDevTBox.Enabled = false;
            fireDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fireDevTBox.Location = new Point(112, 135);
            fireDevTBox.Multiline = true;
            fireDevTBox.Name = "fireDevTBox";
            fireDevTBox.PlaceholderText = "Fire Protection Developer";
            fireDevTBox.Size = new Size(321, 38);
            fireDevTBox.TabIndex = 19;
            // 
            // fireDevLabel
            // 
            fireDevLabel.AutoSize = true;
            fireDevLabel.Dock = DockStyle.Fill;
            fireDevLabel.Enabled = false;
            fireDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fireDevLabel.Location = new Point(0, 132);
            fireDevLabel.Margin = new Padding(0);
            fireDevLabel.Name = "fireDevLabel";
            fireDevLabel.Size = new Size(109, 44);
            fireDevLabel.TabIndex = 18;
            fireDevLabel.Text = "Fire Protection:";
            fireDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // plumbDevTBox
            // 
            plumbDevTBox.Dock = DockStyle.Fill;
            plumbDevTBox.Enabled = false;
            plumbDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plumbDevTBox.Location = new Point(112, 91);
            plumbDevTBox.Multiline = true;
            plumbDevTBox.Name = "plumbDevTBox";
            plumbDevTBox.PlaceholderText = "Plumbing Developer";
            plumbDevTBox.Size = new Size(321, 38);
            plumbDevTBox.TabIndex = 17;
            // 
            // plumbDevLabel
            // 
            plumbDevLabel.AutoSize = true;
            plumbDevLabel.Dock = DockStyle.Fill;
            plumbDevLabel.Enabled = false;
            plumbDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plumbDevLabel.Location = new Point(0, 88);
            plumbDevLabel.Margin = new Padding(0);
            plumbDevLabel.Name = "plumbDevLabel";
            plumbDevLabel.Size = new Size(109, 44);
            plumbDevLabel.TabIndex = 16;
            plumbDevLabel.Text = "Plumbing:";
            plumbDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // elecDevTBox
            // 
            elecDevTBox.Dock = DockStyle.Fill;
            elecDevTBox.Enabled = false;
            elecDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elecDevTBox.Location = new Point(112, 47);
            elecDevTBox.Multiline = true;
            elecDevTBox.Name = "elecDevTBox";
            elecDevTBox.PlaceholderText = "Electrical Developer";
            elecDevTBox.Size = new Size(321, 38);
            elecDevTBox.TabIndex = 15;
            // 
            // elecDevLabel
            // 
            elecDevLabel.AutoSize = true;
            elecDevLabel.Dock = DockStyle.Fill;
            elecDevLabel.Enabled = false;
            elecDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elecDevLabel.Location = new Point(0, 44);
            elecDevLabel.Margin = new Padding(0);
            elecDevLabel.Name = "elecDevLabel";
            elecDevLabel.Size = new Size(109, 44);
            elecDevLabel.TabIndex = 14;
            elecDevLabel.Text = "Electrical:";
            elecDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mechDevTBox
            // 
            mechDevTBox.Dock = DockStyle.Fill;
            mechDevTBox.Enabled = false;
            mechDevTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mechDevTBox.Location = new Point(112, 3);
            mechDevTBox.Multiline = true;
            mechDevTBox.Name = "mechDevTBox";
            mechDevTBox.PlaceholderText = "Mechanical Developer";
            mechDevTBox.Size = new Size(321, 38);
            mechDevTBox.TabIndex = 13;
            // 
            // mechDevLabel
            // 
            mechDevLabel.AutoSize = true;
            mechDevLabel.Dock = DockStyle.Fill;
            mechDevLabel.Enabled = false;
            mechDevLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mechDevLabel.Location = new Point(0, 0);
            mechDevLabel.Margin = new Padding(0);
            mechDevLabel.Name = "mechDevLabel";
            mechDevLabel.Size = new Size(109, 44);
            mechDevLabel.TabIndex = 4;
            mechDevLabel.Text = "Mechanical:";
            mechDevLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scopeLabel
            // 
            scopeLabel.AutoSize = true;
            scopeLabel.Dock = DockStyle.Fill;
            scopeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            scopeLabel.Location = new Point(10, 99);
            scopeLabel.Margin = new Padding(10, 0, 0, 0);
            scopeLabel.Name = "scopeLabel";
            scopeLabel.Size = new Size(130, 73);
            scopeLabel.TabIndex = 14;
            scopeLabel.Text = "Scope of Work:";
            scopeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scopeList
            // 
            scopeList.CheckOnClick = true;
            scopeList.Dock = DockStyle.Fill;
            scopeList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scopeList.FormattingEnabled = true;
            scopeList.Items.AddRange(new object[] { "Mechanical", "Electrical", "Plumbing", "Fire Protection", "T24/Energy", "Structure", "Architecture" });
            scopeList.Location = new Point(143, 102);
            scopeList.MultiColumn = true;
            scopeList.Name = "scopeList";
            scopeList.Size = new Size(436, 67);
            scopeList.TabIndex = 15;
            scopeList.ItemCheck += scopeList_ItemCheck;
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Dock = DockStyle.Fill;
            managerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            managerLabel.Location = new Point(10, 66);
            managerLabel.Margin = new Padding(10, 0, 0, 0);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(130, 33);
            managerLabel.TabIndex = 8;
            managerLabel.Text = "Manager:";
            managerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // managerTBox
            // 
            managerTBox.Dock = DockStyle.Fill;
            managerTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerTBox.Location = new Point(143, 69);
            managerTBox.Multiline = true;
            managerTBox.Name = "managerTBox";
            managerTBox.PlaceholderText = "Manager";
            managerTBox.Size = new Size(436, 27);
            managerTBox.TabIndex = 13;
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Dock = DockStyle.Fill;
            directorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            directorLabel.Location = new Point(10, 33);
            directorLabel.Margin = new Padding(10, 0, 0, 0);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new Size(130, 33);
            directorLabel.TabIndex = 6;
            directorLabel.Text = "Director:";
            directorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // directorTBox
            // 
            directorTBox.Dock = DockStyle.Fill;
            directorTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            directorTBox.Location = new Point(143, 36);
            directorTBox.Multiline = true;
            directorTBox.Name = "directorTBox";
            directorTBox.PlaceholderText = "Director";
            directorTBox.Size = new Size(436, 27);
            directorTBox.TabIndex = 12;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Dock = DockStyle.Fill;
            clientLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            clientLabel.Location = new Point(10, 0);
            clientLabel.Margin = new Padding(10, 0, 0, 0);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(130, 33);
            clientLabel.TabIndex = 0;
            clientLabel.Text = "Client:";
            clientLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clientTBox
            // 
            clientTBox.Dock = DockStyle.Fill;
            clientTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientTBox.Location = new Point(143, 3);
            clientTBox.Multiline = true;
            clientTBox.Name = "clientTBox";
            clientTBox.PlaceholderText = "Client";
            clientTBox.Size = new Size(436, 27);
            clientTBox.TabIndex = 5;
            // 
            // infoControlButtonsTable
            // 
            infoControlButtonsTable.ColumnCount = 2;
            infoControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoControlButtonsTable.Controls.Add(resetInfoButton, 1, 0);
            infoControlButtonsTable.Controls.Add(saveInfoButton, 0, 0);
            infoControlButtonsTable.Location = new Point(3, 627);
            infoControlButtonsTable.Name = "infoControlButtonsTable";
            infoControlButtonsTable.RowCount = 1;
            infoControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoControlButtonsTable.Size = new Size(250, 34);
            infoControlButtonsTable.TabIndex = 2;
            // 
            // resetInfoButton
            // 
            resetInfoButton.BackColor = Color.Gainsboro;
            resetInfoButton.Dock = DockStyle.Fill;
            resetInfoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetInfoButton.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            resetInfoButton.IconColor = Color.Black;
            resetInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resetInfoButton.IconSize = 30;
            resetInfoButton.ImageAlign = ContentAlignment.MiddleLeft;
            resetInfoButton.Location = new Point(125, 0);
            resetInfoButton.Margin = new Padding(0);
            resetInfoButton.Name = "resetInfoButton";
            resetInfoButton.Size = new Size(125, 34);
            resetInfoButton.TabIndex = 6;
            resetInfoButton.Text = "Reset";
            resetInfoButton.UseVisualStyleBackColor = false;
            // 
            // saveInfoButton
            // 
            saveInfoButton.BackColor = Color.Gainsboro;
            saveInfoButton.Dock = DockStyle.Fill;
            saveInfoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveInfoButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveInfoButton.IconColor = Color.Black;
            saveInfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveInfoButton.IconSize = 30;
            saveInfoButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveInfoButton.Location = new Point(0, 0);
            saveInfoButton.Margin = new Padding(0);
            saveInfoButton.Name = "saveInfoButton";
            saveInfoButton.Size = new Size(125, 34);
            saveInfoButton.TabIndex = 5;
            saveInfoButton.Text = "Save";
            saveInfoButton.UseVisualStyleBackColor = false;
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
            projectPathBox.ResumeLayout(false);
            projectPathTable.ResumeLayout(false);
            projectPathTable.PerformLayout();
            controlGroup.ResumeLayout(false);
            controlTable.ResumeLayout(false);
            infoPane.ResumeLayout(false);
            projectInfoBox.ResumeLayout(false);
            projectInfoTable.ResumeLayout(false);
            buildingBox.ResumeLayout(false);
            buildingTable.ResumeLayout(false);
            buildingTable.PerformLayout();
            projectAddressBox.ResumeLayout(false);
            projectAddressTable.ResumeLayout(false);
            projectAddressTable.PerformLayout();
            managementBox.ResumeLayout(false);
            managementTable.ResumeLayout(false);
            managementTable.PerformLayout();
            developersTable.ResumeLayout(false);
            developersTable.PerformLayout();
            infoControlButtonsTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton folderButton;
        private FontAwesome.Sharp.IconButton templateButton;
        private FontAwesome.Sharp.IconButton infoButton;
        private GroupBox projectPathBox;
        private RadioButton existingRButton;
        private TableLayoutPanel projectPathTable;
        private RadioButton newRButton;
        private GroupBox controlGroup;
        private TableLayoutPanel controlTable;
        private TableLayoutPanel infoPane;
        private Label folderPathLabel;
        private TextBox projectPathTBox;
        private FontAwesome.Sharp.IconButton datasheetButton;
        private FontAwesome.Sharp.IconButton setPathButton;
        private GroupBox projectInfoBox;
        private TableLayoutPanel projectInfoTable;
        private GroupBox projectAddressBox;
        private TableLayoutPanel projectAddressTable;
        private Label projectNameLabel;
        private TextBox projectNameTBox;
        private Label countryLabel;
        private ComboBox countryList;
        private ComboBox stateList;
        private Label stateLabel;
        private TextBox fullAddressTBox;
        private Label fullAddressLabel;
        private GroupBox buildingBox;
        private TableLayoutPanel buildingTable;
        private ComboBox conditionList;
        private Label conditionLabel;
        private Label functionLabel;
        private Label typeLabel;
        private ComboBox functionList;
        private ComboBox typeList;
        private GroupBox managementBox;
        private TableLayoutPanel managementTable;
        private Label managerLabel;
        private Label directorLabel;
        private Label clientLabel;
        private TextBox clientTBox;
        private TextBox directorTBox;
        private TextBox managerTBox;
        private Label scopeLabel;
        private CheckedListBox scopeList;
        private Label developersLabel;
        private TableLayoutPanel developersTable;
        private Label mechDevLabel;
        private Label elecDevLabel;
        private TextBox mechDevTBox;
        private Label plumbDevLabel;
        private TextBox elecDevTBox;
        private TextBox plumbDevTBox;
        private TextBox structDevTBox;
        private Label structDevLabel;
        private TextBox engDevTBox;
        private Label engDevLabel;
        private TextBox fireDevTBox;
        private Label fireDevLabel;
        private TextBox archDevTBox;
        private Label archDevLabel;
        private FontAwesome.Sharp.IconButton saveInfoButton;
        private TableLayoutPanel infoControlButtonsTable;
        private FontAwesome.Sharp.IconButton resetInfoButton;
    }
}
