using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace MD5Checksum
{
    public partial class mainForm : Form
    {
        /// <summary>
        /// List that contains all the files
        /// </summary>
        private List<Format.Data> mDataList = new List<Format.Data>();


        /// <summary>
        /// Popup form for showing that the text was copied to clipboard
        /// </summary>
        private popupForm mPopupForm = new popupForm();


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
        private void mainForm_Load(object sender, EventArgs e)
        {
            dropPanel.AllowDrop = true;

            md5Box.ScrollBars = ScrollBars.Vertical;
            md5Box.WordWrap = false;
        }


        /// <summary>
        /// On drop event
        /// </summary>
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

                        if (!mDataList.Any(o => o.md5 == md5sum))
                            mDataList.Add(new Format.Data() { file = fileName, md5 = md5sum });
                    }
                }
            }

            if (files.Length > 0)
                RefreshList();
        }


        /// <summary>
        /// Refreshes the md5 textbox with all entries from the list
        /// </summary>
        private void RefreshList()
        {
            md5Box.Clear();

            foreach (var item in mDataList)
                md5Box.AppendText($"{item.file} - {item.md5}\n");
        }


        /// <summary>
        /// Enable drop effect when enter
        /// </summary>
        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }


        /// <summary>
        /// Opens menu
        /// </summary>
        private void menuLabel_Click(object sender, EventArgs e)
        {
            if (mDataList.Count == 0)
                return;

            Point ptLowerLeft = new Point(0, menuLabel.Height);
            ptLowerLeft = menuLabel.PointToScreen(ptLowerLeft);

            menu.Show(ptLowerLeft);
        }


        /// <summary>
        /// Github menu click
        /// Formats the list of checksums into a github markdown table
        /// </summary>
        private void menuGithub_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Format.GithubTable(mDataList));
            mPopupForm.DisplayMe();
        }


        /// <summary>
        /// Clears all checksums saved
        /// </summary>
        private void menuClear_Click(object sender, EventArgs e)
        {
            mDataList.Clear();
            md5Box.Clear();
        }
    }
}
