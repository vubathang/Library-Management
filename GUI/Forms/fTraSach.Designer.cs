namespace GUI.Forms
{
    partial class fTraSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRefund = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.cbTTPM = new System.Windows.Forms.ComboBox();
            this.cbTTS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpReturn);
            this.panel1.Controls.Add(this.dtpBorrow);
            this.panel1.Controls.Add(this.txtReader);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtRefund);
            this.panel1.Controls.Add(this.txtBook);
            this.panel1.Controls.Add(this.cbTTPM);
            this.panel1.Controls.Add(this.cbTTS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 579);
            this.panel1.TabIndex = 4;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(320, 303);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(262, 38);
            this.dtpReturn.TabIndex = 1;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBorrow.Enabled = false;
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrow.Location = new System.Drawing.Point(319, 235);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(262, 38);
            this.dtpBorrow.TabIndex = 0;
            // 
            // txtReader
            // 
            this.txtReader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReader.Enabled = false;
            this.txtReader.Location = new System.Drawing.Point(319, 31);
            this.txtReader.Name = "txtReader";
            this.txtReader.ReadOnly = true;
            this.txtReader.Size = new System.Drawing.Size(322, 38);
            this.txtReader.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(320, 167);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(106, 38);
            this.txtAmount.TabIndex = 2;
            // 
            // txtRefund
            // 
            this.txtRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefund.Location = new System.Drawing.Point(319, 507);
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.Size = new System.Drawing.Size(263, 38);
            this.txtRefund.TabIndex = 4;
            this.txtRefund.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefund_KeyPress);
            // 
            // txtBook
            // 
            this.txtBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBook.Enabled = false;
            this.txtBook.Location = new System.Drawing.Point(319, 99);
            this.txtBook.Name = "txtBook";
            this.txtBook.ReadOnly = true;
            this.txtBook.Size = new System.Drawing.Size(322, 38);
            this.txtBook.TabIndex = 1;
            // 
            // cbTTPM
            // 
            this.cbTTPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTTPM.FormattingEnabled = true;
            this.cbTTPM.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Đã trả",
            "Hoàn thành"});
            this.cbTTPM.Location = new System.Drawing.Point(320, 439);
            this.cbTTPM.Name = "cbTTPM";
            this.cbTTPM.Size = new System.Drawing.Size(262, 39);
            this.cbTTPM.TabIndex = 3;
            // 
            // cbTTS
            // 
            this.cbTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTTS.FormattingEnabled = true;
            this.cbTTS.Items.AddRange(new object[] {
            "Tốt",
            "Mất trang",
            "Hỏng"});
            this.cbTTS.Location = new System.Drawing.Point(319, 371);
            this.cbTTS.Name = "cbTTS";
            this.cbTTS.Size = new System.Drawing.Size(262, 39);
            this.cbTTS.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền hoàn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng thái phiếu mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên độc giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 86);
            this.panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(525, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 52);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(380, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 52);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu trả";
            this.Load += new System.EventHandler(this.fTraSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.TextBox txtReader;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRefund;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox cbTTPM;
        private System.Windows.Forms.ComboBox cbTTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}