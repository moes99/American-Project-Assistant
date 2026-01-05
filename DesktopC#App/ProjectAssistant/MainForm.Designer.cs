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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
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
            stateNoteLabel = new Label();
            fullAddressTBox = new TextBox();
            fullAddressLabel = new Label();
            stateList = new ComboBox();
            stateLabel = new Label();
            projectNameTBox = new TextBox();
            projectNameLabel = new Label();
            countryLabel = new Label();
            countryList = new ComboBox();
            managementBox = new GroupBox();
            managementTable = new TableLayoutPanel();
            developersLabel = new Label();
            developersTable = new TableLayoutPanel();
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
            folderPane = new TableLayoutPanel();
            folderControlButtonsTable = new TableLayoutPanel();
            deleteFolderButton = new FontAwesome.Sharp.IconButton();
            addFolderButton = new FontAwesome.Sharp.IconButton();
            createFolderButton = new FontAwesome.Sharp.IconButton();
            folderStructureBox = new GroupBox();
            folderView = new TreeView();
            folderNoteLabel = new Label();
            templatesPane = new TableLayoutPanel();
            templateControlButtonsTable = new TableLayoutPanel();
            copyTemplateButton = new FontAwesome.Sharp.IconButton();
            templateViewer = new TableLayoutPanel();
            templateMessageLabel = new Label();
            datasheetsPane = new TableLayoutPanel();
            label2 = new Label();
            datasheetControlButtonsTable = new TableLayoutPanel();
            copyDatasheetButton = new FontAwesome.Sharp.IconButton();
            findDatasheetButton = new FontAwesome.Sharp.IconButton();
            datasheetGroupBox = new GroupBox();
            datasheetSplitterContainer = new SplitContainer();
            inputGroupBox = new GroupBox();
            inputTable = new TableLayoutPanel();
            equipmentOptionLabel = new Label();
            equipmentTypeLabel = new Label();
            equipmentTypeList = new ComboBox();
            equipmentCatLabel = new Label();
            equipmentCatList = new ComboBox();
            equipmentOptionList = new ComboBox();
            equipOptionAcronymLabel = new Label();
            equipTypeAcronymLabel = new Label();
            equipmentSpecsTable = new TableLayoutPanel();
            matchingDatasheetGroupBox = new GroupBox();
            matchingDatasheetList = new CheckedListBox();
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
            infoControlButtonsTable.SuspendLayout();
            folderPane.SuspendLayout();
            folderControlButtonsTable.SuspendLayout();
            folderStructureBox.SuspendLayout();
            templatesPane.SuspendLayout();
            templateControlButtonsTable.SuspendLayout();
            datasheetsPane.SuspendLayout();
            datasheetControlButtonsTable.SuspendLayout();
            datasheetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasheetSplitterContainer).BeginInit();
            datasheetSplitterContainer.Panel1.SuspendLayout();
            datasheetSplitterContainer.Panel2.SuspendLayout();
            datasheetSplitterContainer.SuspendLayout();
            inputGroupBox.SuspendLayout();
            inputTable.SuspendLayout();
            matchingDatasheetGroupBox.SuspendLayout();
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
            folderButton.Click += folderButton_Click;
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
            templateButton.Click += templateButton_Click;
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
            projectPathTBox.Enabled = false;
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
            datasheetButton.Click += datasheetButton_Click;
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
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2275352F));
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 26.0038242F));
            projectInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9598465F));
            projectInfoTable.Size = new Size(991, 523);
            projectInfoTable.TabIndex = 1;
            // 
            // buildingBox
            // 
            buildingBox.Controls.Add(buildingTable);
            buildingBox.Dock = DockStyle.Fill;
            buildingBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buildingBox.Location = new Point(597, 249);
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
            functionList.Items.AddRange(new object[] { "Not Selected" });
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
            typeList.SelectedIndexChanged += typeList_SelectedIndexChanged;
            // 
            // projectAddressBox
            // 
            projectAddressBox.Controls.Add(projectAddressTable);
            projectAddressBox.Dock = DockStyle.Fill;
            projectAddressBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectAddressBox.Location = new Point(597, 3);
            projectAddressBox.Name = "projectAddressBox";
            projectAddressBox.Size = new Size(391, 240);
            projectAddressBox.TabIndex = 2;
            projectAddressBox.TabStop = false;
            projectAddressBox.Text = "Address";
            // 
            // projectAddressTable
            // 
            projectAddressTable.ColumnCount = 2;
            projectAddressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            projectAddressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            projectAddressTable.Controls.Add(stateNoteLabel, 0, 3);
            projectAddressTable.Controls.Add(fullAddressTBox, 1, 4);
            projectAddressTable.Controls.Add(fullAddressLabel, 0, 4);
            projectAddressTable.Controls.Add(stateList, 1, 2);
            projectAddressTable.Controls.Add(stateLabel, 0, 2);
            projectAddressTable.Controls.Add(projectNameTBox, 1, 0);
            projectAddressTable.Controls.Add(projectNameLabel, 0, 0);
            projectAddressTable.Controls.Add(countryLabel, 0, 1);
            projectAddressTable.Controls.Add(countryList, 1, 1);
            projectAddressTable.Dock = DockStyle.Fill;
            projectAddressTable.Location = new Point(3, 25);
            projectAddressTable.Name = "projectAddressTable";
            projectAddressTable.RowCount = 5;
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            projectAddressTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            projectAddressTable.Size = new Size(385, 212);
            projectAddressTable.TabIndex = 1;
            // 
            // stateNoteLabel
            // 
            stateNoteLabel.AutoSize = true;
            projectAddressTable.SetColumnSpan(stateNoteLabel, 2);
            stateNoteLabel.Dock = DockStyle.Fill;
            stateNoteLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            stateNoteLabel.Location = new Point(0, 99);
            stateNoteLabel.Margin = new Padding(0);
            stateNoteLabel.Name = "stateNoteLabel";
            stateNoteLabel.Size = new Size(385, 20);
            stateNoteLabel.TabIndex = 12;
            stateNoteLabel.Text = "State only needed for USA projects";
            stateNoteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fullAddressTBox
            // 
            fullAddressTBox.Dock = DockStyle.Fill;
            fullAddressTBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullAddressTBox.Location = new Point(123, 122);
            fullAddressTBox.Multiline = true;
            fullAddressTBox.Name = "fullAddressTBox";
            fullAddressTBox.PlaceholderText = "Full Address";
            fullAddressTBox.Size = new Size(259, 87);
            fullAddressTBox.TabIndex = 11;
            // 
            // fullAddressLabel
            // 
            fullAddressLabel.AutoSize = true;
            fullAddressLabel.Dock = DockStyle.Fill;
            fullAddressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            fullAddressLabel.Location = new Point(10, 119);
            fullAddressLabel.Margin = new Padding(10, 0, 0, 0);
            fullAddressLabel.Name = "fullAddressLabel";
            fullAddressLabel.Size = new Size(110, 93);
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
            stateList.Items.AddRange(new object[] { "Not Selected" });
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
            // countryList
            // 
            countryList.Dock = DockStyle.Fill;
            countryList.DropDownStyle = ComboBoxStyle.DropDownList;
            countryList.Font = new Font("Segoe UI", 9.75F);
            countryList.FormattingEnabled = true;
            countryList.Items.AddRange(new object[] { "Not Selected" });
            countryList.Location = new Point(123, 36);
            countryList.Name = "countryList";
            countryList.Size = new Size(259, 25);
            countryList.TabIndex = 7;
            countryList.SelectedIndexChanged += countryList_SelectedIndexChanged;
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
            developersLabel.Location = new Point(10, 185);
            developersLabel.Margin = new Padding(10, 0, 0, 0);
            developersLabel.Name = "developersLabel";
            developersLabel.Size = new Size(130, 304);
            developersLabel.TabIndex = 16;
            developersLabel.Text = "Trade Developers:";
            developersLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // developersTable
            // 
            developersTable.ColumnCount = 2;
            developersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            developersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            developersTable.Dock = DockStyle.Fill;
            developersTable.Location = new Point(143, 188);
            developersTable.Name = "developersTable";
            developersTable.RowCount = 7;
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            developersTable.Size = new Size(436, 298);
            developersTable.TabIndex = 17;
            // 
            // scopeLabel
            // 
            scopeLabel.AutoSize = true;
            scopeLabel.Dock = DockStyle.Fill;
            scopeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            scopeLabel.Location = new Point(10, 99);
            scopeLabel.Margin = new Padding(10, 0, 0, 0);
            scopeLabel.Name = "scopeLabel";
            scopeLabel.Size = new Size(130, 86);
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
            scopeList.Location = new Point(143, 102);
            scopeList.MultiColumn = true;
            scopeList.Name = "scopeList";
            scopeList.Size = new Size(436, 80);
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
            resetInfoButton.Click += resetInfoButton_Click;
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
            saveInfoButton.Click += saveInfoButton_Click;
            // 
            // folderPane
            // 
            folderPane.ColumnCount = 1;
            folderPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            folderPane.Controls.Add(folderControlButtonsTable, 0, 1);
            folderPane.Controls.Add(folderStructureBox, 0, 0);
            folderPane.Controls.Add(folderNoteLabel, 0, 1);
            folderPane.Dock = DockStyle.Fill;
            folderPane.Location = new Point(200, 0);
            folderPane.Name = "folderPane";
            folderPane.RowCount = 4;
            folderPane.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            folderPane.RowStyles.Add(new RowStyle());
            folderPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            folderPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            folderPane.Size = new Size(1003, 664);
            folderPane.TabIndex = 5;
            folderPane.Visible = false;
            // 
            // folderControlButtonsTable
            // 
            folderControlButtonsTable.ColumnCount = 3;
            folderControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            folderControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            folderControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            folderControlButtonsTable.Controls.Add(deleteFolderButton, 2, 0);
            folderControlButtonsTable.Controls.Add(addFolderButton, 1, 0);
            folderControlButtonsTable.Controls.Add(createFolderButton, 0, 0);
            folderControlButtonsTable.Location = new Point(3, 607);
            folderControlButtonsTable.Name = "folderControlButtonsTable";
            folderControlButtonsTable.RowCount = 1;
            folderControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            folderControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            folderControlButtonsTable.Size = new Size(375, 34);
            folderControlButtonsTable.TabIndex = 3;
            // 
            // deleteFolderButton
            // 
            deleteFolderButton.BackColor = Color.Gainsboro;
            deleteFolderButton.Dock = DockStyle.Fill;
            deleteFolderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteFolderButton.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            deleteFolderButton.IconColor = Color.Black;
            deleteFolderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteFolderButton.IconSize = 30;
            deleteFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteFolderButton.Location = new Point(250, 0);
            deleteFolderButton.Margin = new Padding(0);
            deleteFolderButton.Name = "deleteFolderButton";
            deleteFolderButton.Size = new Size(125, 34);
            deleteFolderButton.TabIndex = 7;
            deleteFolderButton.Text = "Delete";
            deleteFolderButton.UseVisualStyleBackColor = false;
            deleteFolderButton.Click += deleteFolderButton_Click;
            // 
            // addFolderButton
            // 
            addFolderButton.BackColor = Color.Gainsboro;
            addFolderButton.Dock = DockStyle.Fill;
            addFolderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addFolderButton.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            addFolderButton.IconColor = Color.Black;
            addFolderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addFolderButton.IconSize = 30;
            addFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            addFolderButton.Location = new Point(125, 0);
            addFolderButton.Margin = new Padding(0);
            addFolderButton.Name = "addFolderButton";
            addFolderButton.Size = new Size(125, 34);
            addFolderButton.TabIndex = 6;
            addFolderButton.Text = "Add";
            addFolderButton.UseVisualStyleBackColor = false;
            addFolderButton.Click += addFolderButton_Click;
            // 
            // createFolderButton
            // 
            createFolderButton.BackColor = Color.Gainsboro;
            createFolderButton.Dock = DockStyle.Fill;
            createFolderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createFolderButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            createFolderButton.IconColor = Color.Black;
            createFolderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createFolderButton.IconSize = 25;
            createFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            createFolderButton.Location = new Point(0, 0);
            createFolderButton.Margin = new Padding(0);
            createFolderButton.Name = "createFolderButton";
            createFolderButton.Size = new Size(125, 34);
            createFolderButton.TabIndex = 5;
            createFolderButton.Text = "Create";
            createFolderButton.UseVisualStyleBackColor = false;
            createFolderButton.Click += createFolderButton_Click;
            // 
            // folderStructureBox
            // 
            folderStructureBox.Controls.Add(folderView);
            folderStructureBox.Dock = DockStyle.Fill;
            folderStructureBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            folderStructureBox.Location = new Point(3, 0);
            folderStructureBox.Margin = new Padding(3, 0, 3, 3);
            folderStructureBox.Name = "folderStructureBox";
            folderStructureBox.Size = new Size(997, 567);
            folderStructureBox.TabIndex = 0;
            folderStructureBox.TabStop = false;
            folderStructureBox.Text = "Typical Folder Structure";
            // 
            // folderView
            // 
            folderView.Dock = DockStyle.Fill;
            folderView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderView.Location = new Point(3, 25);
            folderView.Name = "folderView";
            folderView.Size = new Size(991, 539);
            folderView.TabIndex = 0;
            folderView.AfterLabelEdit += folderView_AfterLabelEdit;
            // 
            // folderNoteLabel
            // 
            folderNoteLabel.AutoSize = true;
            folderNoteLabel.Dock = DockStyle.Fill;
            folderNoteLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            folderNoteLabel.Location = new Point(3, 570);
            folderNoteLabel.Name = "folderNoteLabel";
            folderNoteLabel.Size = new Size(997, 34);
            folderNoteLabel.TabIndex = 1;
            folderNoteLabel.Text = resources.GetString("folderNoteLabel.Text");
            folderNoteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // templatesPane
            // 
            templatesPane.AutoSize = true;
            templatesPane.ColumnCount = 1;
            templatesPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            templatesPane.Controls.Add(templateControlButtonsTable, 0, 2);
            templatesPane.Controls.Add(templateViewer, 0, 0);
            templatesPane.Controls.Add(templateMessageLabel, 0, 1);
            templatesPane.Dock = DockStyle.Fill;
            templatesPane.Location = new Point(200, 0);
            templatesPane.Name = "templatesPane";
            templatesPane.RowCount = 4;
            templatesPane.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            templatesPane.RowStyles.Add(new RowStyle());
            templatesPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            templatesPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            templatesPane.Size = new Size(1003, 664);
            templatesPane.TabIndex = 1;
            templatesPane.Visible = false;
            // 
            // templateControlButtonsTable
            // 
            templateControlButtonsTable.ColumnCount = 2;
            templateControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            templateControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            templateControlButtonsTable.Controls.Add(copyTemplateButton, 0, 0);
            templateControlButtonsTable.Location = new Point(3, 607);
            templateControlButtonsTable.Name = "templateControlButtonsTable";
            templateControlButtonsTable.RowCount = 1;
            templateControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            templateControlButtonsTable.Size = new Size(380, 34);
            templateControlButtonsTable.TabIndex = 3;
            // 
            // copyTemplateButton
            // 
            copyTemplateButton.BackColor = Color.Gainsboro;
            copyTemplateButton.Dock = DockStyle.Fill;
            copyTemplateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyTemplateButton.IconChar = FontAwesome.Sharp.IconChar.Clone;
            copyTemplateButton.IconColor = Color.Black;
            copyTemplateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyTemplateButton.IconSize = 30;
            copyTemplateButton.ImageAlign = ContentAlignment.MiddleLeft;
            copyTemplateButton.Location = new Point(0, 0);
            copyTemplateButton.Margin = new Padding(0);
            copyTemplateButton.Name = "copyTemplateButton";
            copyTemplateButton.Size = new Size(190, 34);
            copyTemplateButton.TabIndex = 5;
            copyTemplateButton.Text = "Copy Selected";
            copyTemplateButton.UseVisualStyleBackColor = false;
            copyTemplateButton.Click += copyTemplateButton_Click;
            // 
            // templateViewer
            // 
            templateViewer.ColumnCount = 1;
            templateViewer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            templateViewer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            templateViewer.Dock = DockStyle.Fill;
            templateViewer.Location = new Point(3, 3);
            templateViewer.Name = "templateViewer";
            templateViewer.RowCount = 1;
            templateViewer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            templateViewer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            templateViewer.Size = new Size(997, 581);
            templateViewer.TabIndex = 0;
            // 
            // templateMessageLabel
            // 
            templateMessageLabel.AutoSize = true;
            templateMessageLabel.Dock = DockStyle.Fill;
            templateMessageLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            templateMessageLabel.Location = new Point(3, 587);
            templateMessageLabel.Name = "templateMessageLabel";
            templateMessageLabel.Size = new Size(997, 17);
            templateMessageLabel.TabIndex = 1;
            templateMessageLabel.Text = "Each template is copied to its appropriate folder inside the \"Working Folder\" folder.";
            templateMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datasheetsPane
            // 
            datasheetsPane.ColumnCount = 1;
            datasheetsPane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            datasheetsPane.Controls.Add(label2, 0, 1);
            datasheetsPane.Controls.Add(datasheetControlButtonsTable, 0, 2);
            datasheetsPane.Controls.Add(datasheetGroupBox, 0, 0);
            datasheetsPane.Dock = DockStyle.Fill;
            datasheetsPane.Location = new Point(200, 0);
            datasheetsPane.Name = "datasheetsPane";
            datasheetsPane.RowCount = 3;
            datasheetsPane.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            datasheetsPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            datasheetsPane.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            datasheetsPane.Size = new Size(1003, 664);
            datasheetsPane.TabIndex = 0;
            datasheetsPane.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            datasheetsPane.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 604);
            label2.Name = "label2";
            label2.Size = new Size(997, 20);
            label2.TabIndex = 5;
            label2.Text = "The selected datasheet is copied to the \"Selection\" folder of the selected category.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datasheetControlButtonsTable
            // 
            datasheetControlButtonsTable.ColumnCount = 2;
            datasheetControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            datasheetControlButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            datasheetControlButtonsTable.Controls.Add(copyDatasheetButton, 1, 0);
            datasheetControlButtonsTable.Controls.Add(findDatasheetButton, 0, 0);
            datasheetControlButtonsTable.Location = new Point(3, 627);
            datasheetControlButtonsTable.Name = "datasheetControlButtonsTable";
            datasheetControlButtonsTable.RowCount = 1;
            datasheetControlButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            datasheetControlButtonsTable.Size = new Size(250, 34);
            datasheetControlButtonsTable.TabIndex = 6;
            // 
            // copyDatasheetButton
            // 
            copyDatasheetButton.BackColor = Color.Gainsboro;
            copyDatasheetButton.Dock = DockStyle.Fill;
            copyDatasheetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyDatasheetButton.IconChar = FontAwesome.Sharp.IconChar.Clone;
            copyDatasheetButton.IconColor = Color.Black;
            copyDatasheetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyDatasheetButton.IconSize = 30;
            copyDatasheetButton.ImageAlign = ContentAlignment.MiddleLeft;
            copyDatasheetButton.Location = new Point(125, 0);
            copyDatasheetButton.Margin = new Padding(0);
            copyDatasheetButton.Name = "copyDatasheetButton";
            copyDatasheetButton.Size = new Size(125, 34);
            copyDatasheetButton.TabIndex = 6;
            copyDatasheetButton.Text = "Copy";
            copyDatasheetButton.UseVisualStyleBackColor = false;
            // 
            // findDatasheetButton
            // 
            findDatasheetButton.BackColor = Color.Gainsboro;
            findDatasheetButton.Dock = DockStyle.Fill;
            findDatasheetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findDatasheetButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            findDatasheetButton.IconColor = Color.Black;
            findDatasheetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            findDatasheetButton.IconSize = 30;
            findDatasheetButton.ImageAlign = ContentAlignment.MiddleLeft;
            findDatasheetButton.Location = new Point(0, 0);
            findDatasheetButton.Margin = new Padding(0);
            findDatasheetButton.Name = "findDatasheetButton";
            findDatasheetButton.Size = new Size(125, 34);
            findDatasheetButton.TabIndex = 5;
            findDatasheetButton.Text = "Find";
            findDatasheetButton.UseVisualStyleBackColor = false;
            // 
            // datasheetGroupBox
            // 
            datasheetGroupBox.Controls.Add(datasheetSplitterContainer);
            datasheetGroupBox.Dock = DockStyle.Fill;
            datasheetGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datasheetGroupBox.Location = new Point(3, 0);
            datasheetGroupBox.Margin = new Padding(3, 0, 3, 3);
            datasheetGroupBox.Name = "datasheetGroupBox";
            datasheetGroupBox.Size = new Size(997, 601);
            datasheetGroupBox.TabIndex = 7;
            datasheetGroupBox.TabStop = false;
            datasheetGroupBox.Text = "Datasheet Selection";
            // 
            // datasheetSplitterContainer
            // 
            datasheetSplitterContainer.Dock = DockStyle.Fill;
            datasheetSplitterContainer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datasheetSplitterContainer.Location = new Point(3, 25);
            datasheetSplitterContainer.Name = "datasheetSplitterContainer";
            // 
            // datasheetSplitterContainer.Panel1
            // 
            datasheetSplitterContainer.Panel1.Controls.Add(inputGroupBox);
            // 
            // datasheetSplitterContainer.Panel2
            // 
            datasheetSplitterContainer.Panel2.Controls.Add(matchingDatasheetGroupBox);
            datasheetSplitterContainer.Size = new Size(991, 573);
            datasheetSplitterContainer.SplitterDistance = 495;
            datasheetSplitterContainer.TabIndex = 0;
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(inputTable);
            inputGroupBox.Dock = DockStyle.Fill;
            inputGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputGroupBox.Location = new Point(0, 0);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Size = new Size(495, 573);
            inputGroupBox.TabIndex = 0;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Inputs";
            // 
            // inputTable
            // 
            inputTable.ColumnCount = 2;
            inputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTable.Controls.Add(equipmentOptionLabel, 0, 3);
            inputTable.Controls.Add(equipmentTypeLabel, 0, 1);
            inputTable.Controls.Add(equipmentTypeList, 1, 1);
            inputTable.Controls.Add(equipmentCatLabel, 0, 0);
            inputTable.Controls.Add(equipmentCatList, 1, 0);
            inputTable.Controls.Add(equipmentOptionList, 1, 3);
            inputTable.Controls.Add(equipOptionAcronymLabel, 0, 4);
            inputTable.Controls.Add(equipTypeAcronymLabel, 0, 2);
            inputTable.Controls.Add(equipmentSpecsTable, 0, 5);
            inputTable.Dock = DockStyle.Fill;
            inputTable.Location = new Point(3, 25);
            inputTable.Name = "inputTable";
            inputTable.RowCount = 6;
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.RowStyles.Add(new RowStyle());
            inputTable.Size = new Size(489, 545);
            inputTable.TabIndex = 0;
            // 
            // equipmentOptionLabel
            // 
            equipmentOptionLabel.AutoSize = true;
            equipmentOptionLabel.Dock = DockStyle.Fill;
            equipmentOptionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            equipmentOptionLabel.Location = new Point(3, 79);
            equipmentOptionLabel.Name = "equipmentOptionLabel";
            equipmentOptionLabel.Size = new Size(238, 31);
            equipmentOptionLabel.TabIndex = 4;
            equipmentOptionLabel.Text = "Option:";
            equipmentOptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // equipmentTypeLabel
            // 
            equipmentTypeLabel.AutoSize = true;
            equipmentTypeLabel.Dock = DockStyle.Fill;
            equipmentTypeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            equipmentTypeLabel.Location = new Point(3, 31);
            equipmentTypeLabel.Name = "equipmentTypeLabel";
            equipmentTypeLabel.Size = new Size(238, 31);
            equipmentTypeLabel.TabIndex = 2;
            equipmentTypeLabel.Text = "Equipment Type:";
            equipmentTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // equipmentTypeList
            // 
            equipmentTypeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equipmentTypeList.DropDownStyle = ComboBoxStyle.DropDownList;
            equipmentTypeList.Font = new Font("Segoe UI", 9.75F);
            equipmentTypeList.FormattingEnabled = true;
            equipmentTypeList.Items.AddRange(new object[] { "Not Selected" });
            equipmentTypeList.Location = new Point(247, 34);
            equipmentTypeList.Name = "equipmentTypeList";
            equipmentTypeList.Size = new Size(239, 25);
            equipmentTypeList.TabIndex = 3;
            equipmentTypeList.SelectedIndexChanged += equipmentTypeList_SelectedIndexChanged;
            // 
            // equipmentCatLabel
            // 
            equipmentCatLabel.AutoSize = true;
            equipmentCatLabel.Dock = DockStyle.Fill;
            equipmentCatLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            equipmentCatLabel.Location = new Point(3, 0);
            equipmentCatLabel.Name = "equipmentCatLabel";
            equipmentCatLabel.Size = new Size(238, 31);
            equipmentCatLabel.TabIndex = 0;
            equipmentCatLabel.Text = "Equipment Category:";
            equipmentCatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // equipmentCatList
            // 
            equipmentCatList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equipmentCatList.DropDownStyle = ComboBoxStyle.DropDownList;
            equipmentCatList.Font = new Font("Segoe UI", 9.75F);
            equipmentCatList.FormattingEnabled = true;
            equipmentCatList.Items.AddRange(new object[] { "Not Selected" });
            equipmentCatList.Location = new Point(247, 3);
            equipmentCatList.Name = "equipmentCatList";
            equipmentCatList.Size = new Size(239, 25);
            equipmentCatList.TabIndex = 1;
            equipmentCatList.SelectedIndexChanged += equipmentCatList_SelectedIndexChanged;
            // 
            // equipmentOptionList
            // 
            equipmentOptionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equipmentOptionList.DropDownStyle = ComboBoxStyle.DropDownList;
            equipmentOptionList.Font = new Font("Segoe UI", 9.75F);
            equipmentOptionList.FormattingEnabled = true;
            equipmentOptionList.Location = new Point(247, 82);
            equipmentOptionList.Name = "equipmentOptionList";
            equipmentOptionList.Size = new Size(239, 25);
            equipmentOptionList.TabIndex = 5;
            equipmentOptionList.SelectedIndexChanged += equipmentOptionList_SelectedIndexChanged;
            // 
            // equipOptionAcronymLabel
            // 
            equipOptionAcronymLabel.AutoSize = true;
            inputTable.SetColumnSpan(equipOptionAcronymLabel, 2);
            equipOptionAcronymLabel.Dock = DockStyle.Fill;
            equipOptionAcronymLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            equipOptionAcronymLabel.Location = new Point(3, 110);
            equipOptionAcronymLabel.Name = "equipOptionAcronymLabel";
            equipOptionAcronymLabel.Size = new Size(483, 17);
            equipOptionAcronymLabel.TabIndex = 8;
            equipOptionAcronymLabel.Text = "description of equipment option";
            equipOptionAcronymLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equipTypeAcronymLabel
            // 
            equipTypeAcronymLabel.AutoSize = true;
            inputTable.SetColumnSpan(equipTypeAcronymLabel, 2);
            equipTypeAcronymLabel.Dock = DockStyle.Fill;
            equipTypeAcronymLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            equipTypeAcronymLabel.Location = new Point(3, 62);
            equipTypeAcronymLabel.Name = "equipTypeAcronymLabel";
            equipTypeAcronymLabel.Size = new Size(483, 17);
            equipTypeAcronymLabel.TabIndex = 7;
            equipTypeAcronymLabel.Text = "description of equipment type";
            equipTypeAcronymLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equipmentSpecsTable
            // 
            equipmentSpecsTable.ColumnCount = 2;
            inputTable.SetColumnSpan(equipmentSpecsTable, 2);
            equipmentSpecsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            equipmentSpecsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            equipmentSpecsTable.Dock = DockStyle.Fill;
            equipmentSpecsTable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equipmentSpecsTable.Location = new Point(3, 130);
            equipmentSpecsTable.Name = "equipmentSpecsTable";
            equipmentSpecsTable.RowCount = 1;
            equipmentSpecsTable.RowStyles.Add(new RowStyle());
            equipmentSpecsTable.Size = new Size(483, 412);
            equipmentSpecsTable.TabIndex = 9;
            // 
            // matchingDatasheetGroupBox
            // 
            matchingDatasheetGroupBox.Controls.Add(matchingDatasheetList);
            matchingDatasheetGroupBox.Dock = DockStyle.Fill;
            matchingDatasheetGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matchingDatasheetGroupBox.Location = new Point(0, 0);
            matchingDatasheetGroupBox.Name = "matchingDatasheetGroupBox";
            matchingDatasheetGroupBox.Size = new Size(492, 573);
            matchingDatasheetGroupBox.TabIndex = 1;
            matchingDatasheetGroupBox.TabStop = false;
            matchingDatasheetGroupBox.Text = "Matching Datasheets";
            // 
            // matchingDatasheetList
            // 
            matchingDatasheetList.Dock = DockStyle.Fill;
            matchingDatasheetList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            matchingDatasheetList.FormattingEnabled = true;
            matchingDatasheetList.Location = new Point(3, 25);
            matchingDatasheetList.Name = "matchingDatasheetList";
            matchingDatasheetList.Size = new Size(486, 545);
            matchingDatasheetList.TabIndex = 0;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 664);
            Controls.Add(datasheetsPane);
            Controls.Add(templatesPane);
            Controls.Add(folderPane);
            Controls.Add(infoPane);
            Controls.Add(controlGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            infoControlButtonsTable.ResumeLayout(false);
            folderPane.ResumeLayout(false);
            folderPane.PerformLayout();
            folderControlButtonsTable.ResumeLayout(false);
            folderStructureBox.ResumeLayout(false);
            templatesPane.ResumeLayout(false);
            templatesPane.PerformLayout();
            templateControlButtonsTable.ResumeLayout(false);
            datasheetsPane.ResumeLayout(false);
            datasheetsPane.PerformLayout();
            datasheetControlButtonsTable.ResumeLayout(false);
            datasheetGroupBox.ResumeLayout(false);
            datasheetSplitterContainer.Panel1.ResumeLayout(false);
            datasheetSplitterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datasheetSplitterContainer).EndInit();
            datasheetSplitterContainer.ResumeLayout(false);
            inputGroupBox.ResumeLayout(false);
            inputTable.ResumeLayout(false);
            inputTable.PerformLayout();
            matchingDatasheetGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private FontAwesome.Sharp.IconButton saveInfoButton;
        private TableLayoutPanel infoControlButtonsTable;
        private FontAwesome.Sharp.IconButton resetInfoButton;
        private TableLayoutPanel folderPane;
        private TreeView folderView;
        private GroupBox folderStructureBox;
        private TableLayoutPanel folderControlButtonsTable;
        private FontAwesome.Sharp.IconButton createFolderButton;
        private Label folderNoteLabel;
        private FontAwesome.Sharp.IconButton deleteFolderButton;
        private FontAwesome.Sharp.IconButton addFolderButton;
        private TableLayoutPanel templatesPane;
        private TableLayoutPanel templateViewer;
        private Label templateMessageLabel;
        private TableLayoutPanel templateControlButtonsTable;
        private FontAwesome.Sharp.IconButton copyTemplateButton;
        private TableLayoutPanel datasheetsPane;
        private Label label2;
        private TableLayoutPanel datasheetControlButtonsTable;
        private FontAwesome.Sharp.IconButton findDatasheetButton;
        private GroupBox datasheetGroupBox;
        private SplitContainer datasheetSplitterContainer;
        private GroupBox inputGroupBox;
        private GroupBox matchingDatasheetGroupBox;
        private CheckedListBox matchingDatasheetList;
        private TableLayoutPanel inputTable;
        private Label equipmentCatLabel;
        private ComboBox equipmentCatList;
        private Label equipmentTypeLabel;
        private Label stateNoteLabel;
        private ComboBox equipmentTypeList;
        private Label equipmentOptionLabel;
        private ComboBox equipmentOptionList;
        private Label equipTypeAcronymLabel;
        private Label equipOptionAcronymLabel;
        private TableLayoutPanel equipmentSpecsTable;
        private FontAwesome.Sharp.IconButton copyDatasheetButton;
    }
}
