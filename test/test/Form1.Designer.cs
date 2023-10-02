
namespace test
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stu)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(32, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(230, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin sinh vien";
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "công nghệ thông tin",
            "công nghệ vui",
            "ngôn ngữ anh "});
            this.cmbkhoa.Location = new System.Drawing.Point(58, 154);
            this.cmbkhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(152, 21);
            this.cmbkhoa.TabIndex = 7;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(54, 110);
            this.txtdiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(158, 20);
            this.txtdiem.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(54, 76);
            this.txtten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(158, 20);
            this.txtten.TabIndex = 5;
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(15, 156);
            this.lblkhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(31, 13);
            this.lblkhoa.TabIndex = 4;
            this.lblkhoa.Text = "khoa";
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.Location = new System.Drawing.Point(15, 115);
            this.lbldiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(30, 13);
            this.lbldiem.TabIndex = 3;
            this.lbldiem.Text = "điểm";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(15, 76);
            this.lblten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(22, 13);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "ten";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(15, 35);
            this.lblma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(21, 13);
            this.lblma.TabIndex = 1;
            this.lblma.Text = "ma";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(53, 31);
            this.txtma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(158, 20);
            this.txtma.TabIndex = 0;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(32, 303);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(110, 303);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(186, 303);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
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
            this.hoten,
            this.dtb,
            this.khoa});
            this.dtgv_stu.Location = new System.Drawing.Point(266, 86);
            this.dtgv_stu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_stu.Name = "dtgv_stu";
            this.dtgv_stu.RowHeadersWidth = 51;
            this.dtgv_stu.RowTemplate.Height = 24;
            this.dtgv_stu.Size = new System.Drawing.Size(308, 202);
            this.dtgv_stu.TabIndex = 3;
            this.dtgv_stu.SelectionChanged += new System.EventHandler(this.dtgv_stu_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quan ly thong tin sinh vien";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ma
            // 
            this.ma.HeaderText = "mã";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // dtb
            // 
            this.dtb.HeaderText = "điểm tb";
            this.dtb.MinimumWidth = 6;
            this.dtb.Name = "dtb";
            // 
            // khoa
            // 
            this.khoa.HeaderText = "khoa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_stu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stu)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
    }
}

