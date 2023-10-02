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
using lap04_01.models;

namespace lap04_01
{
    public partial class frmquanlysinhvien : Form
    {
        StudentcontextDB student = new StudentcontextDB();
        Student contensStuden=new Student();
        public frmquanlysinhvien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // goi csdl
            List<Student> liststudents = student.Students.ToList();
            List<Faculty> listfacu = student.Faculties.ToList();

            fillfalcultycombobox(listfacu);
            Bindinggrid(liststudents);
        }

        private void Bindinggrid(List<Student> liststudents)
        {
            dtgv_stu.Rows.Clear();
            foreach (var item in liststudents)
            {
                int index = dtgv_stu.Rows.Add();
                dtgv_stu.Rows[index].Cells[0].Value = item.StudenID;
                dtgv_stu.Rows[index].Cells[1].Value = item.FullName;
                dtgv_stu.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                dtgv_stu.Rows[index].Cells[2].Value = item.AverageScore;
            }
        }

        private void fillfalcultycombobox(List<Faculty> listfacu)
        {
            this.cmbkhoa.DataSource = listfacu;
            this.cmbkhoa.DisplayMember = "FacultyName";
            this.cmbkhoa.ValueMember = "FacultyID";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {try
            {
                if (txtma.Text == "" || txtten.Text == "" || txtdiem.Text == "")
                    throw new Exception("vui long nhap day du thong tin sinh vien");
                if (txtma.Text.Length !=10)
                    throw new Exception("ma sinh vien phai du 10 ki tu ");
                long max;
                
                if (checkIDsv(txtma.Text) == -1)//-1 la sinh vien moi
                {
                    if (long.TryParse(txtma.Text, out max))
                    {
                        if(double.Parse(this.txtdiem.Text) >= 0 && double.Parse(this.txtdiem.Text) <= 10)
                        {
                            // gan gia tri cho doi tuong 
                            Student newstudent = new Student();
                            newstudent.StudenID = txtma.Text.Trim();
                            newstudent.FullName = txtten.Text;
                            newstudent.AverageScore = Convert.ToDouble(txtdiem.Text);
                            newstudent.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue.ToString());
                            student.Students.AddOrUpdate(newstudent);
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
            }catch(Exception ex)
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
            List<Student> newstudents = student.Students.ToList();
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
            Student studentdel= student.Students.FirstOrDefault(p=> p.StudenID==txtma.Text);
            if (studentdel != null)
            {
                DialogResult result = MessageBox.Show($"ban co dong y xoa sinh vien{studentdel.FullName}", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                     student.Students.Remove(studentdel) ;
                     student.SaveChanges();

                    loaddtgv();
                    loadform();
                    MessageBox.Show($"xoa sinh vien {studentdel.FullName}thanh cong", "thong bao ", MessageBoxButtons.OK);
                }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
                Student updatestu = student.Students.FirstOrDefault(p => p.StudenID == txtma.Text);
                if (updatestu != null)
                {
                    updatestu.FullName = txtten.Text;
                    updatestu.AverageScore = Convert.ToDouble(txtdiem.Text);
                    updatestu.FacultyID= Convert.ToInt32(cmbkhoa.SelectedValue.ToString());
                    student.Students.AddOrUpdate(updatestu);
                    student.SaveChanges();
                    loaddtgv();
                    loadform();
                    MessageBox.Show($"sua sinh vien {updatestu.StudenID} thanh cong", "thong bao ", MessageBoxButtons.OK);

                }   
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timkiem tk=new timkiem();
            tk.Show();
        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||  e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmFaculty frm=new frmFaculty();
            frm.ShowDialog();
            
        }
    }
}
