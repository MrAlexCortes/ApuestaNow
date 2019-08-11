namespace ApuestaNow
{
    partial class frmNewCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.txtBoxMaskExpDate = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.txtBoxExpDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(6)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(187, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 45);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Silver;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Enabled = false;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(22, 183);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(155, 45);
            this.btnAccept.TabIndex = 104;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCardNumber.Location = new System.Drawing.Point(35, 34);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(10);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(290, 20);
            this.txtCardNumber.TabIndex = 100;
            this.txtCardNumber.Text = "Card Number";
            this.txtCardNumber.TextChanged += new System.EventHandler(this.TxtCardHolder_TextChanged);
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardNumber_KeyPress);
            this.txtCardNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtCardNumber_MouseDown);
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCardHolder.Location = new System.Drawing.Point(35, 87);
            this.txtCardHolder.Margin = new System.Windows.Forms.Padding(10);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(290, 20);
            this.txtCardHolder.TabIndex = 101;
            this.txtCardHolder.Text = "Card Holder";
            this.txtCardHolder.TextChanged += new System.EventHandler(this.TxtCardHolder_TextChanged);
            this.txtCardHolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtCardNumber_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Location = new System.Drawing.Point(187, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 40);
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Location = new System.Drawing.Point(22, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 40);
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(22, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 40);
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Location = new System.Drawing.Point(22, 24);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(320, 40);
            this.pictureBox32.TabIndex = 126;
            this.pictureBox32.TabStop = false;
            // 
            // txtBoxMaskExpDate
            // 
            this.txtBoxMaskExpDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMaskExpDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMaskExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMaskExpDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxMaskExpDate.Location = new System.Drawing.Point(36, 138);
            this.txtBoxMaskExpDate.Margin = new System.Windows.Forms.Padding(10);
            this.txtBoxMaskExpDate.Name = "txtBoxMaskExpDate";
            this.txtBoxMaskExpDate.Size = new System.Drawing.Size(128, 20);
            this.txtBoxMaskExpDate.TabIndex = 102;
            this.txtBoxMaskExpDate.Text = "Expiration Date";
            this.txtBoxMaskExpDate.TextChanged += new System.EventHandler(this.TxtCardHolder_TextChanged);
            this.txtBoxMaskExpDate.Enter += new System.EventHandler(this.TxtBoxMaskExpDate_Enter);
            this.txtBoxMaskExpDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardNumber_KeyPress);
            // 
            // txtCCV
            // 
            this.txtCCV.BackColor = System.Drawing.SystemColors.Window;
            this.txtCCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCV.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCCV.Location = new System.Drawing.Point(200, 139);
            this.txtCCV.Margin = new System.Windows.Forms.Padding(10);
            this.txtCCV.MaxLength = 3;
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(122, 20);
            this.txtCCV.TabIndex = 103;
            this.txtCCV.Text = "CCV";
            this.txtCCV.TextChanged += new System.EventHandler(this.TxtCardHolder_TextChanged);
            this.txtCCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardNumber_KeyPress);
            this.txtCCV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtCardNumber_MouseDown);
            // 
            // txtBoxExpDate
            // 
            this.txtBoxExpDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExpDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxExpDate.Location = new System.Drawing.Point(36, 138);
            this.txtBoxExpDate.Mask = "00/00";
            this.txtBoxExpDate.Name = "txtBoxExpDate";
            this.txtBoxExpDate.Size = new System.Drawing.Size(128, 19);
            this.txtBoxExpDate.TabIndex = 134;
            this.txtBoxExpDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtBoxExpDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtBoxExpDate_MaskInputRejected);
            this.txtBoxExpDate.TextChanged += new System.EventHandler(this.TxtBoxExpDate_TextChanged);
            // 
            // frmNewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(365, 273);
            this.Controls.Add(this.txtCCV);
            this.Controls.Add(this.txtBoxMaskExpDate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtCardHolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtBoxExpDate);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewCard";
            this.Load += new System.EventHandler(this.FrmNewCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBoxMaskExpDate;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.MaskedTextBox txtBoxExpDate;
    }
}