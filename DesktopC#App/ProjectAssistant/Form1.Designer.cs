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
            buttonHolder = new FlowLayoutPanel();
            infoButton = new FontAwesome.Sharp.IconButton();
            templateButton = new FontAwesome.Sharp.IconButton();
            infoPane = new FlowLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            buttonHolder.SuspendLayout();
            infoPane.SuspendLayout();
            SuspendLayout();
            // 
            // folderButton
            // 
            folderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderButton.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            folderButton.IconColor = Color.Black;
            folderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            folderButton.IconSize = 35;
            folderButton.ImageAlign = ContentAlignment.MiddleLeft;
            folderButton.Location = new Point(3, 49);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(144, 40);
            folderButton.TabIndex = 1;
            folderButton.Text = "Folders";
            folderButton.TextAlign = ContentAlignment.MiddleRight;
            folderButton.UseVisualStyleBackColor = true;
            // 
            // buttonHolder
            // 
            buttonHolder.AutoScroll = true;
            buttonHolder.Controls.Add(infoButton);
            buttonHolder.Controls.Add(folderButton);
            buttonHolder.Controls.Add(templateButton);
            buttonHolder.Dock = DockStyle.Left;
            buttonHolder.FlowDirection = FlowDirection.TopDown;
            buttonHolder.Location = new Point(0, 0);
            buttonHolder.Name = "buttonHolder";
            buttonHolder.Size = new Size(179, 664);
            buttonHolder.TabIndex = 2;
            buttonHolder.WrapContents = false;
            // 
            // infoButton
            // 
            infoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            infoButton.IconColor = Color.Black;
            infoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            infoButton.IconSize = 30;
            infoButton.ImageAlign = ContentAlignment.MiddleLeft;
            infoButton.Location = new Point(3, 3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(144, 40);
            infoButton.TabIndex = 3;
            infoButton.Text = "Project Info";
            infoButton.TextAlign = ContentAlignment.MiddleRight;
            infoButton.UseVisualStyleBackColor = true;
            // 
            // templateButton
            // 
            templateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            templateButton.IconChar = FontAwesome.Sharp.IconChar.File;
            templateButton.IconColor = Color.Black;
            templateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            templateButton.IconSize = 30;
            templateButton.ImageAlign = ContentAlignment.MiddleLeft;
            templateButton.Location = new Point(3, 95);
            templateButton.Name = "templateButton";
            templateButton.Size = new Size(144, 40);
            templateButton.TabIndex = 2;
            templateButton.Text = "Templates";
            templateButton.TextAlign = ContentAlignment.MiddleRight;
            templateButton.UseVisualStyleBackColor = true;
            // 
            // infoPane
            // 
            infoPane.Controls.Add(iconButton1);
            infoPane.Dock = DockStyle.Fill;
            infoPane.Location = new Point(179, 0);
            infoPane.Name = "infoPane";
            infoPane.Size = new Size(1024, 664);
            infoPane.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(144, 40);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Project Info";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 664);
            Controls.Add(infoPane);
            Controls.Add(buttonHolder);
            MinimumSize = new Size(1000, 500);
            Name = "mainForm";
            Text = "Project Assistant";
            buttonHolder.ResumeLayout(false);
            infoPane.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton folderButton;
        private FlowLayoutPanel buttonHolder;
        private FontAwesome.Sharp.IconButton templateButton;
        private FontAwesome.Sharp.IconButton infoButton;
        private FlowLayoutPanel infoPane;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
