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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLMT = new System.Windows.Forms.Button();
            this.btnQLS = new System.Windows.Forms.Button();
            this.btnQLDG = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnQLMT);
            this.panel1.Controls.Add(this.btnQLS);
            this.panel1.Controls.Add(this.btnQLDG);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 789);
            this.panel1.TabIndex = 0;
            // 
            // btnQLMT
            // 
            this.btnQLMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMT.FlatAppearance.BorderSize = 0;
            this.btnQLMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLMT.Image = global::GUI.Properties.Resources.bill;
            this.btnQLMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMT.Location = new System.Drawing.Point(0, 389);
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
            this.btnQLS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLS.Image = global::GUI.Properties.Resources.book;
            this.btnQLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLS.Location = new System.Drawing.Point(0, 317);
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
            this.btnQLDG.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLDG.Image = global::GUI.Properties.Resources.reading;
            this.btnQLDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDG.Location = new System.Drawing.Point(0, 245);
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
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLNV.Image = global::GUI.Properties.Resources.staff;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 173);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(240, 72);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::GUI.Properties.Resources.library__1_;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(240, 173);
            this.Home.TabIndex = 0;
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            this.panel2.Size = new System.Drawing.Size(1129, 57);
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
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(831, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 57);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(42, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::GUI.Properties.Resources.down_arrow1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(274, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 57);
            this.panel6.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBody.Location = new System.Drawing.Point(240, 57);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1129, 732);
            this.pnlBody.TabIndex = 2;
            // 
            // fHomeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 789);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fHomeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHomeManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Button btnQLMT;
        private System.Windows.Forms.Button btnQLS;
        private System.Windows.Forms.Button btnQLDG;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTitle;
    }
}