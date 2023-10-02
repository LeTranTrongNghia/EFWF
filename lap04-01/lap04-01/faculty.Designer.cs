namespace lap04_01
{
    partial class frmFaculty
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
            this.thoong = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttongsogs = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.lbltongsogs = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.dtgvKhoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // thoong
            // 
            this.thoong.Controls.Add(this.btnxoa);
            this.thoong.Controls.Add(this.btnthem);
            this.thoong.Controls.Add(this.txttongsogs);
            this.thoong.Controls.Add(this.txttenkhoa);
            this.thoong.Controls.Add(this.txtmakhoa);
            this.thoong.Controls.Add(this.lbltongsogs);
            this.thoong.Controls.Add(this.lblten);
            this.thoong.Controls.Add(this.lblma);
            this.thoong.Location = new System.Drawing.Point(15, 10);
            this.thoong.Name = "thoong";
            this.thoong.Size = new System.Drawing.Size(320, 345);
            this.thoong.TabIndex = 0;
            this.thoong.TabStop = false;
            this.thoong.Text = "Thông tin khoa";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(211, 297);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 29);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xoas";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(105, 297);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 29);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "them/sua";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttongsogs
            // 
            this.txttongsogs.Location = new System.Drawing.Point(114, 152);
            this.txttongsogs.Name = "txttongsogs";
            this.txttongsogs.Size = new System.Drawing.Size(186, 22);
            this.txttongsogs.TabIndex = 6;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(114, 109);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(186, 22);
            this.txttenkhoa.TabIndex = 5;
            this.txttenkhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkhoa_KeyPress);
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(114, 50);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(186, 22);
            this.txtmakhoa.TabIndex = 4;
            this.txtmakhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmakhoa_KeyPress);
            // 
            // lbltongsogs
            // 
            this.lbltongsogs.AutoSize = true;
            this.lbltongsogs.Location = new System.Drawing.Point(6, 152);
            this.lbltongsogs.Name = "lbltongsogs";
            this.lbltongsogs.Size = new System.Drawing.Size(75, 16);
            this.lbltongsogs.TabIndex = 3;
            this.lbltongsogs.Text = "Tổng số gs";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(6, 109);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(64, 16);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "Tên khoa";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(6, 53);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(59, 16);
            this.lblma.TabIndex = 1;
            this.lblma.Text = "Mã khoa";
            // 
            // dtgvKhoa
            // 
            this.dtgvKhoa.AllowUserToAddRows = false;
            this.dtgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvKhoa.Location = new System.Drawing.Point(378, 31);
            this.dtgvKhoa.Name = "dtgvKhoa";
            this.dtgvKhoa.RowHeadersWidth = 51;
            this.dtgvKhoa.RowTemplate.Height = 24;
            this.dtgvKhoa.Size = new System.Drawing.Size(409, 304);
            this.dtgvKhoa.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = " mã khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "tông số gs";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvKhoa);
            this.Controls.Add(this.thoong);
            this.Name = "frmFaculty";
            this.Text = "Quan ly khoa";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.thoong.ResumeLayout(false);
            this.thoong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox thoong;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label lbltongsogs;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttongsogs;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.DataGridView dtgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}