namespace lap04_01
{
    partial class frmquanlysinhvien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquanlysinhvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lbldiem = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dtgv_stu = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbkhoa);
            this.groupBox1.Controls.Add(this.txtdiem);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.lblkhoa);
            this.groupBox1.Controls.Add(this.lbldiem);
            this.groupBox1.Controls.Add(this.lblten);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(42, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "công nghệ thông tin",
            "công nghệ vui",
            "ngôn ngữ anh "});
            this.cmbkhoa.Location = new System.Drawing.Point(78, 189);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(201, 24);
            this.cmbkhoa.TabIndex = 7;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(72, 135);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(209, 22);
            this.txtdiem.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(72, 93);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(209, 22);
            this.txtten.TabIndex = 5;
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(20, 192);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(37, 16);
            this.lblkhoa.TabIndex = 4;
            this.lblkhoa.Text = "khoa";
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.Location = new System.Drawing.Point(20, 141);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(37, 16);
            this.lbldiem.TabIndex = 3;
            this.lbldiem.Text = "điểm";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(20, 93);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(25, 16);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "ten";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(20, 43);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(26, 16);
            this.lblma.TabIndex = 1;
            this.lblma.Text = "ma";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(71, 38);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(209, 22);
            this.txtma.TabIndex = 0;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtma_KeyPress);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(42, 373);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(155, 373);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(248, 373);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dtgv_stu
            // 
            this.dtgv_stu.AllowUserToAddRows = false;
            this.dtgv_stu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_stu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.Column2,
            this.Column3,
            this.khoa});
            this.dtgv_stu.Location = new System.Drawing.Point(354, 106);
            this.dtgv_stu.Name = "dtgv_stu";
            this.dtgv_stu.RowHeadersWidth = 51;
            this.dtgv_stu.RowTemplate.Height = 24;
            this.dtgv_stu.Size = new System.Drawing.Size(410, 249);
            this.dtgv_stu.TabIndex = 3;
            // 
            // ma
            // 
            this.ma.HeaderText = "mã";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "điểm tb";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // khoa
            // 
            this.khoa.HeaderText = "khoa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmquanlysinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgv_stu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmquanlysinhvien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dtgv_stu;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

