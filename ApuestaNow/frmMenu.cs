using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApuestaNow
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Label68_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabBet;
            btnBet.BackColor = SystemColors.HotTrack;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.Highlight;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnPositions.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnPositions_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabGeneralTable;
            btnPositions.BackColor = SystemColors.HotTrack;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.Highlight;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;

            tabProfile.Controls.Clear();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabProfile;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.HotTrack;
            btnPayments.BackColor = SystemColors.Highlight;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnPositions.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabBet;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.HotTrack;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnPositions.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;
        }

        private void BtnMybets_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabMyBets;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.Highlight;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnPositions.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.HotTrack;
        }

        private void TabProgram_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
