namespace Unzipper
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.addContextMenuButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.unzipperLogo = new System.Windows.Forms.PictureBox();
            this.removeContextMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unzipperLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(360, 72);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox2.Location = new System.Drawing.Point(12, 183);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(360, 139);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox3.Location = new System.Drawing.Point(12, 344);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(360, 38);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.TabStop = false;
            this.richTextBox3.Text = "If there are any issues using this tool, or if you have ideas for improvements or" +
    " feature requests, then please get in touch with Jeff Higgins.";
            // 
            // addContextMenuButton
            // 
            this.addContextMenuButton.Location = new System.Drawing.Point(213, 18);
            this.addContextMenuButton.Name = "addContextMenuButton";
            this.addContextMenuButton.Size = new System.Drawing.Size(159, 23);
            this.addContextMenuButton.TabIndex = 1;
            this.addContextMenuButton.Text = "Add to Context Menu";
            this.addContextMenuButton.UseVisualStyleBackColor = true;
            this.addContextMenuButton.Click += new System.EventHandler(this.addContextMenuButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(68, 55);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "v1.1";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unzipperLogo
            // 
            this.unzipperLogo.Image = ((System.Drawing.Image)(resources.GetObject("unzipperLogo.Image")));
            this.unzipperLogo.Location = new System.Drawing.Point(12, 18);
            this.unzipperLogo.Name = "unzipperLogo";
            this.unzipperLogo.Size = new System.Drawing.Size(50, 50);
            this.unzipperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unzipperLogo.TabIndex = 5;
            this.unzipperLogo.TabStop = false;
            // 
            // removeContextMenuButton
            // 
            this.removeContextMenuButton.Location = new System.Drawing.Point(213, 45);
            this.removeContextMenuButton.Name = "removeContextMenuButton";
            this.removeContextMenuButton.Size = new System.Drawing.Size(159, 23);
            this.removeContextMenuButton.TabIndex = 6;
            this.removeContextMenuButton.Text = "Remove from Context Menu";
            this.removeContextMenuButton.UseVisualStyleBackColor = true;
            this.removeContextMenuButton.Click += new System.EventHandler(this.removeContextMenuButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.removeContextMenuButton);
            this.Controls.Add(this.unzipperLogo);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.addContextMenuButton);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.unzipperLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button addContextMenuButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox unzipperLogo;
        private System.Windows.Forms.Button removeContextMenuButton;
    }
}