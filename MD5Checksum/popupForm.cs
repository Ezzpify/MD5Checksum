using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Checksum
{
    public partial class popupForm : Form
    {
        /// <summary>
        /// If this has been shown before
        /// </summary>
        private bool mShown;


        /// <summary>
        /// Class constructor
        /// </summary>
        public popupForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Hides the form after n milliseconds
        /// </summary>
        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            fadeTimer.Stop();
            Hide();
        }


        /// <summary>
        /// Occures when the form is shown
        /// We'll just hide it instantly
        /// </summary>
        private void popupForm_Shown(object sender, EventArgs e)
        {
            Hide();
            if (!mShown)
            {
                DisplayMe();
                mShown = true;
            }
        }


        /// <summary>
        /// Displays the form
        /// </summary>
        public void DisplayMe()
        {
            fadeTimer.Stop();

            Height = 16;
            var pos = Cursor.Position;
            Location = new Point(pos.X - 10, pos.Y - 10);

            Show();
            fadeTimer.Start();
        }
    }
}
