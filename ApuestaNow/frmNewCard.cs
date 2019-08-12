using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApuestaNow
{
    public partial class frmNewCard : Form
    {

        public static int userid = frmMenu.userid;
        public frmNewCard()
        {
            InitializeComponent();

        }

        private void TxtBoxMaskExpDate_Enter(object sender, EventArgs e)
        {
            txtBoxMaskExpDate.SendToBack();
            txtBoxExpDate.Focus();
        }

        private void TxtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ccvOk = false;
        private void TxtCardHolder_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxExpDate.Text != "" && txtCardHolder.Text != "" && txtCardNumber.TextLength > 15 && txtCCV.Text != "CCV" && txtCCV.TextLength > 2 && ccvOk == true )
            {
                btnAccept.Enabled = true;
                btnAccept.BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            else
            {
                btnAccept.Enabled = false;
                btnAccept.BackColor = Color.Silver;
            }
        }

        private void TxtCardNumber_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb = (TextBox)ActiveControl;

            tb.SelectAll();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (!Card.AddCard(txtCardNumber.Text, txtCardHolder.Text, txtBoxExpDate.Text, txtCCV.Text, userid))
                Card.AddCard(txtCardNumber.Text, txtCardHolder.Text, txtBoxExpDate.Text, txtCCV.Text, userid);

            this.Close();
        }

        private void TxtBoxExpDate_TextChanged(object sender, EventArgs e)
        {
            int ccv0 = 0;
            int ccv1 = 0;
            string[] ccvstr = txtBoxExpDate.Text.Split('/');

            try { ccv0 = Convert.ToInt32(ccvstr[0]); }              
            catch(FormatException) { ccv0 = 0; }

            try { ccv1 = Convert.ToInt32(ccvstr[1]); }
            catch(FormatException) { ccv1 = 0; }

            if (ccv0 < 13 && ccv1 > 18)
                ccvOk = true;
            else
                ccvOk = false;

            if (txtBoxExpDate.Text != "" && txtCardHolder.Text != "" && txtCardNumber.TextLength > 15 && txtCCV.Text != "CCV" && txtCCV.TextLength > 2 && ccvOk == true)
            {
                btnAccept.Enabled = true;
                btnAccept.BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            else
            {
                btnAccept.Enabled = false;
                btnAccept.BackColor = Color.Silver;
            }
        }

        private void TxtBoxExpDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewCard_Load(object sender, EventArgs e)
        {

        }
    }
}
