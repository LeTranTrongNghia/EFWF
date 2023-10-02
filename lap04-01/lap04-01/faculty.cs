using lap04_01.models;
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

namespace lap04_01
{
    public partial class frmFaculty : Form
    {
        StudentcontextDB student = new StudentcontextDB();
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            List<Faculty> listfacu = student.Faculties.ToList();

            fillfalculty(listfacu);
        }

        private void fillfalculty(List<Faculty> listfacu)
        {
            dtgvKhoa.Rows.Clear();
            foreach (var faculty in listfacu)
            {
                int index = dtgvKhoa.Rows.Add();
                dtgvKhoa.Rows[index].Cells[0].Value = faculty.FacultyID;
                dtgvKhoa.Rows[index].Cells[1].Value = faculty.FacultyName;
                dtgvKhoa.Rows[index].Cells[2].Value = faculty.TotalProfressor;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtmakhoa.Text == "" || txttenkhoa.Text == "" || txttongsogs.Text == "")
                        throw new Exception("vui long nhap day du thong tin ");

                    int makhoa = Convert.ToInt32(txtmakhoa.Text);
                    Faculty updatestu = student.Faculties.Find(makhoa);
                    if (updatestu != null) // Khoa đã tồn tại
                    {
                        // Cập nhật thông tin khoa
                        updatestu.FacultyName = txttenkhoa.Text;
                        updatestu.TotalProfressor = Convert.ToInt32(txttongsogs.Text);
                        student.Faculties.AddOrUpdate(updatestu);
                        student.SaveChanges();
                        loaddtgv();
                        loadform();
                        MessageBox.Show($"Đã cập nhật khoa có ID {updatestu.FacultyID} thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else // Khoa mới
                    {
                        // Tạo và lưu khoa mới
                        Faculty newfaculty = new Faculty();
                        newfaculty.FacultyID = makhoa;
                        newfaculty.FacultyName = txttenkhoa.Text;
                        newfaculty.TotalProfressor = Convert.ToInt32(txttongsogs.Text);
                        student.Faculties.AddOrUpdate(newfaculty);
                        student.SaveChanges();
                        loaddtgv();
                        loadform();
                        MessageBox.Show("Đã thêm vào danh sách thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void loaddtgv()
        {
            List<Faculty> listfacu = student.Faculties.ToList();
            fillfalculty(listfacu);

        }
        private void loadform()
        {
            txtmakhoa.Clear();
            txttenkhoa.Clear();
            txttongsogs.Clear();
        }

        private int checkIDsv(object newidfaculty)
        {
            int length = dtgvKhoa.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dtgvKhoa.Rows[i].Cells[0].Value != null)
                    if (dtgvKhoa.Rows[i].Cells[0].Value == newidfaculty)
                        return i;
            }
            return -1;//khong tim thay
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int makhoa=int.Parse(txtmakhoa.Text);
            Faculty facultydel = student.Faculties.Find(makhoa);
            if (facultydel != null)
            {
                DialogResult result = MessageBox.Show($"ban co dong y xoa khoa {facultydel.FacultyName}", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    student.Faculties.Remove(facultydel);
                    student.SaveChanges();

                    loaddtgv();
                    loadform();
                    MessageBox.Show($"xoa khoa {facultydel.FacultyName}thanh cong", "thong bao ", MessageBoxButtons.OK);
                }

            }
        }

        private void txtmakhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txttenkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}