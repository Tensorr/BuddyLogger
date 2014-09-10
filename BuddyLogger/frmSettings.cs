using System;
using System.Linq;
using System.Windows.Forms;
using Buddy.Common.Math;
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
            ObjectManager.Update();
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
            catch (Exception ex)
            {
                BuddyLogger.Write(ex);
            }
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectManager.Update();
                torNpcBindingSource.DataSource = ObjectManager.GetObjects<TorNpc>().OrderBy(t => t.Distance);
            }
            catch (Exception ex)
            {
                BuddyLogger.Write(ex);
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //BuddyLogger.Write("Err");
        }
         private void dataGridViewPlaceable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //BuddyLogger.Write("Err");
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            BuddyLogger.DumpObjects();
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Navigator.PathPrecision = 0.3f;
            if (contextMenuStrip1.Tag == null) return;
            try
            {
                BuddyLogger.MoveTo((Vector3) contextMenuStrip1.Tag);
            }
            catch (Exception exception)
            {
                BuddyLogger.Write(exception);
            }
        }

        private void dataGridViewPlaceable_RowContextMenuStripNeeded(object sender,
            DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1) return;
            contextMenuStrip1.Tag = dGridVTab1.Rows[e.RowIndex].Cells["positionDataGridViewTextBoxColumn"].Value;
        }

        /// <summary> Handles the changes in the comboboxes
        /// activates and deactivtes buttons (revise)
        /// Changes tab titles (revise) </summary>
        private void cbTab1Object_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb.Text == "")
            {
                if (cmb == cbTab1Object)
                {
                    btnTab1b1.Enabled = false;
                    btnTab1b2.Enabled = false;
                    return;
                }
                if (cmb == cbTab2Object)
                {
                    btnTab2b1.Enabled = false;
                    btnTab2b2.Enabled = false;
                    return;
                }
                BuddyLogger.Write("EX: combo?");
                return;
            }
            if (cmb == cbTab1Object)
            {
                btnTab1b1.Enabled = true;
                btnTab1b1.Text = cbTab1Object.Text;
                btnTab1b2.Enabled = true;
                btnTab1b2.Text = cbTab1Object.Text + " -Ori";
                tabPage1.Text = cbTab1Object.Text;
                tabPage2.Text = cbTab1Object.Text + " -Ori";
                return;
            }
            if (cmb != cbTab2Object) return;
            btnTab2b1.Enabled = true;
            btnTab2b1.Text = cbTab2Object.Text;
            btnTab2b2.Enabled = true;
            btnTab2b2.Text = cbTab2Object.Text + " -Ori";
            tabPage3.Text = cbTab2Object.Text;
            tabPage4.Text = cbTab2Object.Text + " -Ori";
      
        }


        private void DataGridPlaceable(DataGridView dataGrid, string strFilter="")
        {
            dataGrid.DataSource = torPlaceableBindingSource;
            torPlaceableBindingSource.DataSource = 
                ObjectManager.GetObjects<TorPlaceable>().AsParallel().ToArray()
                .Where(t => t != null && !t.IsDeleted && t.Name.Contains(strFilter))
                .OrderBy(t => t.Distance);

            dataGrid.DataBindings.Clear();
            //!t.DisabledForEveryone)
        }
        private void DataGridNPC(DataGridView dataGrid, string strFilter = "")
        {
            dataGrid.DataSource = torNpcBindingSource;
            torNpcBindingSource.DataSource = 
                ObjectManager.GetObjects<TorNpc>().AsParallel().ToArray()
                .Where(t => t != null && !t.IsDeleted && t.Name.Contains(strFilter))
                .OrderBy(t => t.Distance);

            dataGrid.DataBindings.Clear();
        }

        private void btnTabA_Click(object sender, EventArgs e)
        {
            ObjectManager.Update();
            string strSwitch;
            string strFilter;

            var btn = sender as Button;

            if (btn == btnTab1b1 || btn == btnTab1b2)
            {
                strSwitch = cbTab1Object.Text;
                strFilter = textBoxTab1.Text;
                LoadDGV(sender.Equals(btnTab1b1) ? dGridVTab1 : dGridVTab2, strSwitch, strFilter);
                return;
            }
            if (btn != btnTab2b1 && btn != btnTab2b2) return;
            strSwitch = cbTab2Object.Text;
            strFilter = textBoxTab2.Text;
            LoadDGV(sender.Equals(btnTab1b1) ? dGridVTab1 : dGridVTab2, strSwitch, strFilter);
            return;
        }

        private void LoadDGV(DataGridView dgView, string strSwitch, string strFilter="")  
        {
            switch (strSwitch)
            {
                case (""):
                    break;
                case ("Placeables"):
                    DataGridPlaceable(dgView, strFilter);
                    //dataGridViewTab1.DataMember = torPlaceableBindingSource.DataMember;
                    break;
                case ("NPC"):
                    DataGridNPC(dgView, strFilter);
                    //dataGridViewTab1.DataMember = torPlaceableBindingSource.DataMember;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}