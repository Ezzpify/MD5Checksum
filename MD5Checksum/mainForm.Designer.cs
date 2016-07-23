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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.md5Box = new System.Windows.Forms.TextBox();
            this.dropPanel = new System.Windows.Forms.Panel();
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.md5Box);
            this.Controls.Add(this.dropPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 Checksum";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox md5Box;
        private System.Windows.Forms.Panel dropPanel;
    }
}

