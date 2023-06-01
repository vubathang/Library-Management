namespace GUI.Forms
{
    partial class fAdd
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbName.Location = new System.Drawing.Point(42, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(162, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên đăng nhập:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbPassword.Location = new System.Drawing.Point(42, 96);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(107, 26);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbAddress.Location = new System.Drawing.Point(42, 155);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(85, 26);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbPhone.Location = new System.Drawing.Point(42, 214);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(145, 26);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Số điện thoại:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbDate.Location = new System.Drawing.Point(42, 273);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(115, 26);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Ngày sinh:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txbName.Location = new System.Drawing.Point(252, 37);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(369, 29);
            this.txbName.TabIndex = 0;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txbPassword.Location = new System.Drawing.Point(252, 95);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(369, 30);
            this.txbPassword.TabIndex = 1;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txbAddress.Location = new System.Drawing.Point(252, 154);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(369, 30);
            this.txbAddress.TabIndex = 2;
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txbPhone.Location = new System.Drawing.Point(252, 214);
            this.txbPhone.Multiline = true;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(369, 29);
            this.txbPhone.TabIndex = 3;
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "dd/MM/yyyy";
            this.dtBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirth.Location = new System.Drawing.Point(252, 272);
            this.dtBirth.MinimumSize = new System.Drawing.Size(20, 30);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(369, 32);
            this.dtBirth.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(244, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(513, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(389, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fAdd
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(679, 407);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Name = "fAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.fAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
    }
}