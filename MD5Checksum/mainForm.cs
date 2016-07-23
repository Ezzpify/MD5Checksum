using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace MD5Checksum
{
    public partial class mainForm : Form
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// FormLoad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            dropPanel.AllowDrop = true;
        }


        /// <summary>
        /// On drop event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            /*Get data for all the files*/
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                /*Ensure that the file exists*/
                if (!File.Exists(file))
                    continue;

                /*Get the MD5 checksum for the file and add to textbox*/
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(file))
                    {
                        string fileName = Path.GetFileName(file);
                        string md5sum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToUpper();

                        md5Box.AppendText($"{fileName} - {md5sum}\n");
                    }
                }
            }
        }


        /// <summary>
        /// Enable drop effect when enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
