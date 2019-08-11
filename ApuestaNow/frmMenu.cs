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
        User user = new User(5);
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

        bool firstTime = true;
        private void BtnPositions_Click(object sender, EventArgs e)
        {
            tabProgram.SelectedTab = tabGeneralTable;
            btnPositions.BackColor = SystemColors.HotTrack;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.Highlight;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;

            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = Team.GetAll();

            if(firstTime)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = "Position";
                Column.Name = "Position";
                Column.Width = 75;
                dgvTable.Columns.Insert(0, Column);              
                firstTime = false;
            }

            for (int i = 1; i < 20; i++)
            {

                if (i < 9)
                {
                    dgvTable[0, i - 1].Style.BackColor = Color.FromArgb(255, 0, 192, 0);
                    dgvTable[0, i - 1].Style.ForeColor = Color.White;
                }
                dgvTable[0, i - 1].Value = i;
            }
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

            profileDateBirth.Value = user.BirthDate;
            profileTxtEmail.Text = user.Email;
            profileTxtFirstName.Text = user.FirstName;
            profileTxtFirstSurname.Text = user.FirstSurname;
            profileTxtTelephone.Text = user.TelephoneNumber;
            profileTxtSecondSurname.Text = user.SecondSurname;
            profileDateBirth.MaxDate = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month, DateTime.Today.Day);  


        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            // Side menu color change
            tabProgram.SelectedTab = tabPayments;
            btnBet.BackColor = SystemColors.Highlight;
            btnProfile.BackColor = SystemColors.Highlight;
            btnPayments.BackColor = SystemColors.HotTrack;
            btnLogOut.BackColor = SystemColors.Highlight;
            btnPositions.BackColor = SystemColors.Highlight;
            btnMybets.BackColor = SystemColors.Highlight;

            paymentsBtnDelete.Enabled = false;
            paymentsBtnDeposit.Enabled = false;
            paymentsBtnWithdraw.Enabled = false;

            paymentsBtnDeposit.BackColor = Color.Silver;
            paymentsBtnWithdraw.BackColor = Color.Silver;


            List<Card> cards = Card.GetAll();

            dgvCards.AutoGenerateColumns = false;
            dgvCards.DataSource = cards;

            paymentsCboxCard1.Items.Clear();
            paymentsCboxCard2.Items.Clear();
            foreach (Card card in cards)
            {
                paymentsCboxCard1.Items.Add(card.CardNumber);
                paymentsCboxCard2.Items.Add(card.CardNumber);
            }


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

        private void PaymentsBtnNewCard_Click(object sender, EventArgs e)
        {
            frmNewCard FormNewCard = new frmNewCard();
            FormNewCard.ShowDialog();
            List<Card> cards = Card.GetAll();

            dgvCards.AutoGenerateColumns = false;
            dgvCards.DataSource = cards;

            foreach (Card card in cards)
            {
                paymentsCboxCard1.Items.Add(card.CardNumber);
                paymentsCboxCard2.Items.Add(card.CardNumber);
            }
        }

        private void DgvCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaymentsBtnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCards.SelectedCells[0].Value;
            Card.DeleteCard(id);
            List<Card> cards = Card.GetAll();

            dgvCards.AutoGenerateColumns = false;
            dgvCards.DataSource = cards;

            foreach (Card card in cards)
            {
                paymentsCboxCard1.Items.Add(card.CardNumber);
                paymentsCboxCard2.Items.Add(card.CardNumber);
            }
        }

        private void DgvCards_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DgvCards_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCards.SelectedRows.Count > 0)
            {
                paymentsBtnDelete.Enabled = true;
                paymentsBtnDelete.BackColor = Color.FromArgb(255, 231, 76, 6);
            }
            else
            {
                paymentsBtnDelete.Enabled = false;
                paymentsBtnDelete.BackColor = Color.Silver;
            }
        }

        private void TabPayments_Click(object sender, EventArgs e)
        {

        }

        private void PaymentsNumWithdraw_ValueChanged(object sender, EventArgs e)
        {
            if (paymentsNumWithdraw.Value < user.Credits)
            {
                paymentsBtnDeposit.Enabled = true;
                paymentsBtnDeposit.BackColor = Color.FromArgb(255, 0, 192, 0);
            }

        }

        private void PaymentsCboxCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentsCboxCard2.SelectedIndex >= 0 && paymentsNumWithdraw.Value < user.Credits)
            {
                paymentsBtnWithdraw.Enabled = true;
                paymentsBtnWithdraw.BackColor = Color.FromArgb(255, 0, 192, 0);
            }
        }

        private void PaymentsCboxCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentsCboxCard1.SelectedIndex >= 0)
            {
                paymentsBtnDeposit.Enabled = true;
                paymentsBtnDeposit.BackColor = Color.FromArgb(255, 0, 192, 0);
            }
        }

        private void PaymentsBtnDeposit_Click(object sender, EventArgs e)
        {
            if (user.ModifyCredits(true, Convert.ToInt32(paymentsNumDeposit.Value)))
                MessageBox.Show(paymentsNumDeposit.Value.ToString() + " Credits has been deposited to your account", "Credits Deposited", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvTable_SelectionChanged(object sender, EventArgs e)
        {
            dgvTable.ClearSelection();
        }

        private void ProfileTxtTelephone_TextChanged(object sender, EventArgs e)
        {
            if(profileTxtEmail.Text != "" && profileTxtFirstName.Text != "" && profileTxtFirstSurname.Text != "" && profileTxtSecondSurname.Text != "" && profileTxtTelephone.Text != "")
            {
                profileBtnInfo.Enabled = true;
                profileBtnInfo.BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            else
            {
                profileBtnInfo.Enabled = false;
                profileBtnInfo.BackColor = Color.Silver;
            }
        }

        private void ProfileTxtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ProfileTxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ProfileTxtSecondSurname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ProfileTxtSecondSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProfileBtnInfo_Click(object sender, EventArgs e)
        {
            user.BirthDate = (DateTime)profileDateBirth.Text;
        }
    }
}
