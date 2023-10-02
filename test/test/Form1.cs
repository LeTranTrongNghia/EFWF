using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Models;

namespace test
{
    public partial class Form1 : Form
    {
        StudentContextDB student = new StudentContextDB();
        tblStudent contextStudent = new tblStudent();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // goi csdl
            List<tblStudent> liststudents = student.tblStudents.ToList();
            List<tblFaculty> listfacu = student.tblFaculties.ToList();

            fillfalcultycombobox(listfacu);
            Bindinggrid(liststudents);
        }

        private void Bindinggrid(List<tblStudent> liststudents)
        {
            dtgv_stu.Rows.Clear();
            foreach (var item in liststudents)
            {
                int index = dtgv_stu.Rows.Add();
                dtgv_stu.Rows[index].Cells[0].Value = item.STUDENTID;
                dtgv_stu.Rows[index].Cells[1].Value = item.FULLNAME;
                dtgv_stu.Rows[index].Cells[3].Value = item.tblFaculty.FACULTYNAME;
                dtgv_stu.Rows[index].Cells[2].Value = item.AVERAGESCORE;
            }
        }

        private void fillfalcultycombobox(List<tblFaculty> listfacu)
        {
            this.cmbkhoa.DataSource = listfacu;
            this.cmbkhoa.DisplayMember = "FacultyName";
            this.cmbkhoa.ValueMember = "FacultyID";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtma.Text == "" || txtten.Text == "" || txtdiem.Text == "")
                    throw new Exception("vui long nhap day du thong tin sinh vien");
                if (txtma.Text.Length != 10)
                    throw new Exception("ma sinh vien phai du 10 ki tu ");
                long max;

                if (checkIDsv(txtma.Text) == -1)//-1 la sinh vien moi
                {
                    if (long.TryParse(txtma.Text, out max))
                    {
                        if (double.Parse(this.txtdiem.Text) >= 0 && double.Parse(this.txtdiem.Text) <= 10)
                        {
                            // gan gia tri cho doi tuong 
                            tblStudent newstudent = new tblStudent();
                            newstudent.STUDENTID = txtma.Text.Trim();
                            newstudent.FULLNAME = txtten.Text;
                            newstudent.AVERAGESCORE = Convert.ToDouble(txtdiem.Text);
                            newstudent.FACULTYID = Convert.ToInt32(cmbkhoa.SelectedValue.ToString());
                            student.tblStudents.AddOrUpdate(newstudent);
                            student.SaveChanges();

                            loaddtgv();
                            loadform();
                            MessageBox.Show("them vao danh sach thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("chi nhap so tu 1-10");
                            txtdiem.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("mssv không được nhập kí tự đặc biệt hoặc chữ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadform()
        {
            txtma.Clear();
            txtdiem.Clear();
            txtten.Clear();
        }

        private void loaddtgv()
        {
            List<tblStudent> newstudents = student.tblStudents.ToList();
            Bindinggrid(newstudents);

        }

        private int checkIDsv(string newidsv)
        {
            int length = dtgv_stu.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dtgv_stu.Rows[i].Cells[0].Value != null)
                    if (dtgv_stu.Rows[i].Cells[0].Value.ToString() == newidsv)
                        return i;
            }
            return -1;//khong tim thay
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var studentdels = dtgv_stu.SelectedRows[0].Cells["ma"].Value.ToString();
            tblStudent studentdel = student.tblStudents.Find(studentdels);
            if (studentdel != null)
            {
                DialogResult result = MessageBox.Show($"ban co dong y xoa sinh vien{studentdel.FULLNAME}", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    student.tblStudents.Remove(studentdel);
                    student.SaveChanges();

                    loaddtgv();
                    loadform();
                    MessageBox.Show($"xoa sinh vien {studentdel.FULLNAME}thanh cong", "thong bao ", MessageBoxButtons.OK);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = (dtgv_stu.SelectedRows[0].Cells["ma"].Value.ToString());
            tblStudent updatestu = student.tblStudents.Find(id);
            if (updatestu != null)
            {
                updatestu.FULLNAME = txtten.Text;
                updatestu.AVERAGESCORE = Convert.ToDouble(txtdiem.Text);
                updatestu.FACULTYID = Convert.ToInt32(cmbkhoa.SelectedValue.ToString());
                student.tblStudents.AddOrUpdate(updatestu);
                student.SaveChanges();
                loaddtgv();
                loadform();
                MessageBox.Show($"sua sinh vien {updatestu.STUDENTID} thanh cong", "thong bao ", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_stu_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_stu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgv_stu.SelectedRows[0];
                txtma.Text = row.Cells["ma"].Value.ToString();
                txtten.Text = row.Cells["hoten"].Value.ToString();
                txtdiem.Text = row.Cells["dtb"].Value.ToString();
                cmbkhoa.SelectedItem = row.Cells["khoa"].Value.ToString();
            }
        }
    }
}
