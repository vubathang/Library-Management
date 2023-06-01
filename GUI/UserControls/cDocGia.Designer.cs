namespace GUI.UserControls
{
    partial class cDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteDG = new System.Windows.Forms.Button();
            this.btnEditDG = new System.Windows.Forms.Button();
            this.btnAddDG = new System.Windows.Forms.Button();
            this.dtgvDG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 132);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txbAmount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(719, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 44);
            this.panel2.TabIndex = 1;
            // 
            // txbAmount
            // 
            this.txbAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbAmount.Enabled = false;
            this.txbAmount.Location = new System.Drawing.Point(149, 0);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.ReadOnly = true;
            this.txbAmount.Size = new System.Drawing.Size(76, 38);
            this.txbAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteDG, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditDG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddDG, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDeleteDG
            // 
            this.btnDeleteDG.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDG.Location = new System.Drawing.Point(333, 3);
            this.btnDeleteDG.Name = "btnDeleteDG";
            this.btnDeleteDG.Size = new System.Drawing.Size(161, 63);
            this.btnDeleteDG.TabIndex = 2;
            this.btnDeleteDG.Text = "Xóa";
            this.btnDeleteDG.UseVisualStyleBackColor = false;
            this.btnDeleteDG.Click += new System.EventHandler(this.btnDeleteDG_Click);
            // 
            // btnEditDG
            // 
            this.btnEditDG.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDG.Location = new System.Drawing.Point(168, 3);
            this.btnEditDG.Name = "btnEditDG";
            this.btnEditDG.Size = new System.Drawing.Size(159, 63);
            this.btnEditDG.TabIndex = 1;
            this.btnEditDG.Text = "Sửa";
            this.btnEditDG.UseVisualStyleBackColor = false;
            this.btnEditDG.Click += new System.EventHandler(this.btnEditDG_Click);
            // 
            // btnAddDG
            // 
            this.btnAddDG.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDG.Location = new System.Drawing.Point(3, 3);
            this.btnAddDG.Name = "btnAddDG";
            this.btnAddDG.Size = new System.Drawing.Size(159, 63);
            this.btnAddDG.TabIndex = 0;
            this.btnAddDG.Text = "Thêm";
            this.btnAddDG.UseVisualStyleBackColor = false;
            this.btnAddDG.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // dtgvDG
            // 
            this.dtgvDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDG.Location = new System.Drawing.Point(3, 34);
            this.dtgvDG.Name = "dtgvDG";
            this.dtgvDG.ReadOnly = true;
            this.dtgvDG.RowHeadersWidth = 62;
            this.dtgvDG.RowTemplate.Height = 28;
            this.dtgvDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDG.Size = new System.Drawing.Size(979, 367);
            this.dtgvDG.TabIndex = 1;
            this.dtgvDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDG_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDG);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách độc giả";
            // 
            // cDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "cDocGia";
            this.Size = new System.Drawing.Size(985, 536);
            this.Load += new System.EventHandler(this.cDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteDG;
        private System.Windows.Forms.Button btnEditDG;
        private System.Windows.Forms.Button btnAddDG;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
