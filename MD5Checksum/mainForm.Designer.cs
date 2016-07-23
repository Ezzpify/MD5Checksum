namespace MD5Checksum
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.md5Box = new System.Windows.Forms.TextBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // md5Box
            // 
            this.md5Box.BackColor = System.Drawing.Color.White;
            this.md5Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.md5Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.md5Box.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.md5Box.ForeColor = System.Drawing.Color.Gray;
            this.md5Box.Location = new System.Drawing.Point(0, 115);
            this.md5Box.Multiline = true;
            this.md5Box.Name = "md5Box";
            this.md5Box.ReadOnly = true;
            this.md5Box.Size = new System.Drawing.Size(584, 147);
            this.md5Box.TabIndex = 2;
            this.md5Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dropPanel
            // 
            this.dropPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropPanel.BackgroundImage")));
            this.dropPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanel.Location = new System.Drawing.Point(0, 0);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(584, 115);
            this.dropPanel.TabIndex = 3;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.ContextMenuStrip = this.menu;
            this.menuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.menuLabel.ForeColor = System.Drawing.Color.Gray;
            this.menuLabel.Location = new System.Drawing.Point(556, 118);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(16, 16);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "▼";
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGithub,
            this.menuClear});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(185, 48);
            // 
            // menuGithub
            // 
            this.menuGithub.Image = ((System.Drawing.Image)(resources.GetObject("menuGithub.Image")));
            this.menuGithub.Name = "menuGithub";
            this.menuGithub.Size = new System.Drawing.Size(184, 22);
            this.menuGithub.Text = "Copy as Github table";
            this.menuGithub.Click += new System.EventHandler(this.menuGithub_Click);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(184, 22);
            this.menuClear.Text = "Clear checksums";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.md5Box);
            this.Controls.Add(this.dropPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 Checksum";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox md5Box;
        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuGithub;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
    }
}

