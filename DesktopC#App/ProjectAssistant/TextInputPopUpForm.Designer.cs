namespace ProjectAssistant
{
    partial class TextInputPopUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            controlContainer = new TableLayoutPanel();
            messageLabel = new Label();
            answerTBox = new TextBox();
            createFolderButton = new FontAwesome.Sharp.IconButton();
            titleLabel = new Label();
            controlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // controlContainer
            // 
            controlContainer.ColumnCount = 1;
            controlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlContainer.Controls.Add(titleLabel, 0, 0);
            controlContainer.Controls.Add(createFolderButton, 0, 3);
            controlContainer.Controls.Add(messageLabel, 0, 1);
            controlContainer.Controls.Add(answerTBox, 0, 2);
            controlContainer.Dock = DockStyle.Fill;
            controlContainer.Location = new Point(0, 0);
            controlContainer.Name = "controlContainer";
            controlContainer.RowCount = 4;
            controlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            controlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            controlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            controlContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            controlContainer.Size = new Size(800, 450);
            controlContainer.TabIndex = 0;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Dock = DockStyle.Fill;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(3, 82);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(794, 123);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Message";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerTBox
            // 
            answerTBox.Dock = DockStyle.Fill;
            answerTBox.Location = new Point(3, 208);
            answerTBox.Multiline = true;
            answerTBox.Name = "answerTBox";
            answerTBox.Size = new Size(794, 199);
            answerTBox.TabIndex = 1;
            // 
            // createFolderButton
            // 
            createFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            createFolderButton.BackColor = Color.Gainsboro;
            createFolderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createFolderButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            createFolderButton.IconColor = Color.Black;
            createFolderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createFolderButton.IconSize = 25;
            createFolderButton.ImageAlign = ContentAlignment.MiddleLeft;
            createFolderButton.Location = new Point(337, 410);
            createFolderButton.Margin = new Padding(0);
            createFolderButton.Name = "createFolderButton";
            createFolderButton.Size = new Size(125, 40);
            createFolderButton.TabIndex = 6;
            createFolderButton.Text = "Create";
            createFolderButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(794, 82);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextInputPopUpFom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(controlContainer);
            Name = "TextInputPopUpFom";
            Text = "TextInputPopUpFom";
            controlContainer.ResumeLayout(false);
            controlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel controlContainer;
        private Label messageLabel;
        private TextBox answerTBox;
        private FontAwesome.Sharp.IconButton createFolderButton;
        private Label titleLabel;
    }
}