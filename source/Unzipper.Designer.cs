namespace Unzipper
{
    partial class Unzipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unzipper));
            this.destinationFolderButton = new System.Windows.Forms.Button();
            this.destinationTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unzipLogTextbox = new System.Windows.Forms.RichTextBox();
            this.cancelUnzipButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.overwriteFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.openFolderCheckbox = new System.Windows.Forms.CheckBox();
            this.unzipButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.unzipProgressBar = new System.Windows.Forms.ProgressBar();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(393, 88);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(75, 20);
            this.destinationFolderButton.TabIndex = 4;
            this.destinationFolderButton.Text = "Browse...";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            this.destinationFolderButton.Click += new System.EventHandler(this.destinationFolderButton_Click);
            // 
            // destinationTextbox
            // 
            this.destinationTextbox.Location = new System.Drawing.Point(18, 88);
            this.destinationTextbox.Name = "destinationTextbox";
            this.destinationTextbox.Size = new System.Drawing.Size(369, 20);
            this.destinationTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Files will be unzipped to this folder:";
            // 
            // unzipLogTextbox
            // 
            this.unzipLogTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unzipLogTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.unzipLogTextbox.DetectUrls = false;
            this.unzipLogTextbox.HideSelection = false;
            this.unzipLogTextbox.Location = new System.Drawing.Point(486, 35);
            this.unzipLogTextbox.Name = "unzipLogTextbox";
            this.unzipLogTextbox.ReadOnly = true;
            this.unzipLogTextbox.Size = new System.Drawing.Size(420, 267);
            this.unzipLogTextbox.TabIndex = 13;
            this.unzipLogTextbox.TabStop = false;
            this.unzipLogTextbox.Text = "";
            this.unzipLogTextbox.WordWrap = false;
            // 
            // cancelUnzipButton
            // 
            this.cancelUnzipButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelUnzipButton.Image")));
            this.cancelUnzipButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelUnzipButton.Location = new System.Drawing.Point(111, 227);
            this.cancelUnzipButton.Name = "cancelUnzipButton";
            this.cancelUnzipButton.Size = new System.Drawing.Size(75, 75);
            this.cancelUnzipButton.TabIndex = 11;
            this.cancelUnzipButton.Text = "Cancel";
            this.cancelUnzipButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelUnzipButton.UseVisualStyleBackColor = true;
            this.cancelUnzipButton.Visible = false;
            this.cancelUnzipButton.Click += new System.EventHandler(this.cancelUnzipButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordCheckbox);
            this.panel1.Controls.Add(this.passwordTextbox);
            this.panel1.Controls.Add(this.overwriteFilesCheckbox);
            this.panel1.Controls.Add(this.openFolderCheckbox);
            this.panel1.Location = new System.Drawing.Point(18, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 94);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Options";
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.Location = new System.Drawing.Point(0, 25);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(119, 17);
            this.passwordCheckbox.TabIndex = 6;
            this.passwordCheckbox.Text = "Password required?";
            this.passwordCheckbox.UseVisualStyleBackColor = true;
            this.passwordCheckbox.CheckedChanged += new System.EventHandler(this.passwordCheckbox_CheckedChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Enabled = false;
            this.passwordTextbox.Location = new System.Drawing.Point(128, 22);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(322, 20);
            this.passwordTextbox.TabIndex = 7;
            // 
            // overwriteFilesCheckbox
            // 
            this.overwriteFilesCheckbox.AutoSize = true;
            this.overwriteFilesCheckbox.Location = new System.Drawing.Point(0, 48);
            this.overwriteFilesCheckbox.Name = "overwriteFilesCheckbox";
            this.overwriteFilesCheckbox.Size = new System.Drawing.Size(150, 17);
            this.overwriteFilesCheckbox.TabIndex = 8;
            this.overwriteFilesCheckbox.Text = "Overwrite any existing files";
            this.overwriteFilesCheckbox.UseVisualStyleBackColor = true;
            // 
            // openFolderCheckbox
            // 
            this.openFolderCheckbox.AutoSize = true;
            this.openFolderCheckbox.Checked = true;
            this.openFolderCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openFolderCheckbox.Location = new System.Drawing.Point(0, 70);
            this.openFolderCheckbox.Name = "openFolderCheckbox";
            this.openFolderCheckbox.Size = new System.Drawing.Size(188, 17);
            this.openFolderCheckbox.TabIndex = 9;
            this.openFolderCheckbox.Text = "Show unzipped files when finished";
            this.openFolderCheckbox.UseVisualStyleBackColor = true;
            // 
            // unzipButton
            // 
            this.unzipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.unzipButton.Image = ((System.Drawing.Image)(resources.GetObject("unzipButton.Image")));
            this.unzipButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.unzipButton.Location = new System.Drawing.Point(18, 227);
            this.unzipButton.Name = "unzipButton";
            this.unzipButton.Size = new System.Drawing.Size(75, 75);
            this.unzipButton.TabIndex = 10;
            this.unzipButton.Text = "Unzip files";
            this.unzipButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.unzipButton.UseVisualStyleBackColor = true;
            this.unzipButton.Click += new System.EventHandler(this.unzipButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zip file:";
            // 
            // unzipProgressBar
            // 
            this.unzipProgressBar.ForeColor = System.Drawing.Color.Green;
            this.unzipProgressBar.Location = new System.Drawing.Point(486, 19);
            this.unzipProgressBar.Name = "unzipProgressBar";
            this.unzipProgressBar.Size = new System.Drawing.Size(419, 18);
            this.unzipProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.unzipProgressBar.TabIndex = 19;
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(18, 35);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(369, 20);
            this.fileNameTextbox.TabIndex = 1;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(393, 35);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(75, 20);
            this.fileSelectButton.TabIndex = 2;
            this.fileSelectButton.Text = "Browse...";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aboutButton.Location = new System.Drawing.Point(393, 227);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 75);
            this.aboutButton.TabIndex = 12;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Unzipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 321);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.unzipProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unzipLogTextbox);
            this.Controls.Add(this.cancelUnzipButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unzipButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationTextbox);
            this.Controls.Add(this.destinationFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Unzipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unzipper";
            this.Load += new System.EventHandler(this.UnzipperCM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button destinationFolderButton;
        private System.Windows.Forms.TextBox destinationTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox unzipLogTextbox;
        private System.Windows.Forms.Button cancelUnzipButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox passwordCheckbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.CheckBox overwriteFilesCheckbox;
        private System.Windows.Forms.CheckBox openFolderCheckbox;
        private System.Windows.Forms.Button unzipButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar unzipProgressBar;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Button aboutButton;
    }
}