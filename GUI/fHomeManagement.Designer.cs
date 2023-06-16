namespace GUI
{
    partial class fHomeManagement
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
            System.Windows.Forms.Panel Home;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQLMT = new System.Windows.Forms.Button();
            this.btnQLS = new System.Windows.Forms.Button();
            this.btnQLDG = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Home = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            Home.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnQLMT);
            this.panel1.Controls.Add(this.btnQLS);
            this.panel1.Controls.Add(this.btnQLDG);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 789);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 717);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 72);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Home
            // 
            Home.BackColor = System.Drawing.Color.Transparent;
            Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Home.Controls.Add(this.pictureBox1);
            Home.Dock = System.Windows.Forms.DockStyle.Top;
            Home.Location = new System.Drawing.Point(0, 0);
            Home.Name = "Home";
            Home.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            Home.Size = new System.Drawing.Size(240, 86);
            Home.TabIndex = 0;
            Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1561, 57);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(369, 57);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HOME";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lbNameStaff);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1234, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel5.Size = new System.Drawing.Size(327, 57);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNameStaff.Location = new System.Drawing.Point(119, 0);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(188, 57);
            this.lbNameStaff.TabIndex = 0;
            this.lbNameStaff.Text = "label1";
            this.lbNameStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNameStaff.Click += new System.EventHandler(this.Home_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackgroundImage = global::GUI.Properties.Resources.BG4;
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBody.Location = new System.Drawing.Point(240, 57);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1561, 732);
            this.pnlBody.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::GUI.Properties.Resources.user__2_;
            this.pictureBox2.Location = new System.Drawing.Point(56, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Size = new System.Drawing.Size(63, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnQLMT
            // 
            this.btnQLMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMT.FlatAppearance.BorderSize = 0;
            this.btnQLMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMT.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMT.ForeColor = System.Drawing.Color.White;
            this.btnQLMT.Image = global::GUI.Properties.Resources.bill;
            this.btnQLMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMT.Location = new System.Drawing.Point(0, 302);
            this.btnQLMT.Name = "btnQLMT";
            this.btnQLMT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLMT.Size = new System.Drawing.Size(240, 72);
            this.btnQLMT.TabIndex = 3;
            this.btnQLMT.Text = "Mượn trả";
            this.btnQLMT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLMT.UseVisualStyleBackColor = true;
            this.btnQLMT.Click += new System.EventHandler(this.btnQLMT_Click);
            // 
            // btnQLS
            // 
            this.btnQLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLS.FlatAppearance.BorderSize = 0;
            this.btnQLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLS.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLS.ForeColor = System.Drawing.Color.White;
            this.btnQLS.Image = global::GUI.Properties.Resources.book;
            this.btnQLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLS.Location = new System.Drawing.Point(0, 230);
            this.btnQLS.Name = "btnQLS";
            this.btnQLS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLS.Size = new System.Drawing.Size(240, 72);
            this.btnQLS.TabIndex = 2;
            this.btnQLS.Text = "Sách";
            this.btnQLS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLS.UseVisualStyleBackColor = true;
            this.btnQLS.Click += new System.EventHandler(this.btnQLS_Click);
            // 
            // btnQLDG
            // 
            this.btnQLDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDG.FlatAppearance.BorderSize = 0;
            this.btnQLDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDG.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDG.ForeColor = System.Drawing.Color.White;
            this.btnQLDG.Image = global::GUI.Properties.Resources.reading;
            this.btnQLDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDG.Location = new System.Drawing.Point(0, 158);
            this.btnQLDG.Name = "btnQLDG";
            this.btnQLDG.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLDG.Size = new System.Drawing.Size(240, 72);
            this.btnQLDG.TabIndex = 1;
            this.btnQLDG.Text = "Độc giả";
            this.btnQLDG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDG.UseVisualStyleBackColor = true;
            this.btnQLDG.Click += new System.EventHandler(this.btnQLDG_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.Image = global::GUI.Properties.Resources.staff;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 86);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(240, 72);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUI.Properties.Resources.book_stack1;
            this.pictureBox1.Location = new System.Drawing.Point(70, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fHomeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 789);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fHomeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            Home.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLMT;
        private System.Windows.Forms.Button btnQLS;
        private System.Windows.Forms.Button btnQLDG;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbNameStaff;
    }
}