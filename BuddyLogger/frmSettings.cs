using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buddy.CommonBot.Settings;

namespace BuddyLogger
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbMegaDump.Checked = BuddyLogger.MegaDump;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuddyLogger.DumpObjects();
        }

        private void cbMegaDump_CheckedChanged(object sender, EventArgs e)
        {
            BuddyLogger.MegaDump = cbMegaDump.Checked;
            //Properties.Settings.MD = cbMegaDump.Checked;
        }
    }
}
