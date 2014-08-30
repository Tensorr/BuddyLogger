using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buddy.CommonBot.Settings;
using Buddy.Swtor;
using Buddy.Swtor.Objects;

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
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void cbMegaDump_CheckedChanged(object sender, EventArgs e)
        {
            BuddyLogger.MegaDump = cbMegaDump.Checked;
        }

        private void cbPalceables_CheckedChanged(object sender, EventArgs e)
        {
            BuddyLogger.Placeables = cbPalceables.Checked;
        }

        private void btnPlaceables_Click(object sender, EventArgs e)
        {
            torPlaceableBindingSource.DataSource = ObjectManager.GetObjects<TorPlaceable>().OrderBy(t => t.Distance);
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            torNpcBindingSource.DataSource = ObjectManager.GetObjects<TorNpc>().OrderBy(t => t.Distance);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //BuddyLogger.Write("Err");
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            BuddyLogger.DumpObjects();
        }
    }
}
