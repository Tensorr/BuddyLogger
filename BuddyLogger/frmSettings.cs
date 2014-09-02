using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Buddy.Common.Math;
using Buddy.CommonBot.Settings;
using Buddy.Navigation;
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
            try
            {
                ObjectManager.Update();
                torPlaceableBindingSource.DataSource = ObjectManager.GetObjects<TorPlaceable>().OrderBy(t => t.Distance);
            }
            catch
            {
            }
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectManager.Update();
                torNpcBindingSource.DataSource = ObjectManager.GetObjects<TorNpc>().OrderBy(t => t.Distance);
            }
            catch
            {
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //BuddyLogger.Write("Err");
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            BuddyLogger.DumpObjects();
        }

        private void dataGridViewPlaceable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //BuddyLogger.Write("Err");
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 1;
            //Navigator.PathPrecision = 0.3f;
            if (contextMenuStrip1.Tag != null)
            {
                try
                {
                    BuddyLogger.MoveTo((Vector3) contextMenuStrip1.Tag);
                }
                catch (Exception exception)
                {
                    BuddyLogger.Write(exception);
                }
            }
        }

        private void dataGridViewPlaceable_RowContextMenuStripNeeded(object sender,
            DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1) return;
            contextMenuStrip1.Tag = dataGridViewPlaceable.Rows[e.RowIndex].Cells["positionDataGridViewTextBoxColumn"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
