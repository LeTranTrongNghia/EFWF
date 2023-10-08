using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace BT
{
    public partial class Form1 : Form
    {
        StudentModels db = new StudentModels();
        private string ImagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dataGridView1);
                var listFacultys = FacultyService.GetAll();
                var listStudents = StudentService.GetAll();
                FillFacaultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void FillFacaultyCombobox(List<Faculty> listFacultys)
        {
            this.comboBox1.DataSource = listFacultys;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";
        }

        public void BindGrid(List<Student> listStudents)
        {
            dataGridView1.Rows.Clear();
            foreach(var item in listStudents)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                if(item.Faculty != null)
                    dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore + "" ;

                if(item.MajorID != null)
                    dataGridView1.Rows[index].Cells[4].Value = item.Major.Name + "";
                ShowAvatar(item.Avatar);
            }
        }

        private void ShowAvatar(string aVATAR)
        {
            if (string.IsNullOrEmpty(aVATAR))
            {
                pictureBox1.Image = null;
            }
            else
            {
                string parentDirectory = Directory.GetParent(
                    AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Resources", aVATAR);
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Refresh();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.checkBox1.Checked)
                listStudents = StudentService.GetAllHasNoMajor();
            else
                listStudents = StudentService.GetAll();
            BindGrid(listStudents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var context = db.Students;

                // gan gia tri cho doi tuong 
                Student newstudent = new Student();
                newstudent.StudentID = textBox1.Text.Trim();
                newstudent.FullName = textBox2.Text;
                newstudent.AverageScore = Convert.ToDouble(textBox3.Text);
                newstudent.FacultyID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                newstudent.Avatar = ImagePath.ToString();

                // Kiem tra ID da ton tai
                var entity = db.Students.FirstOrDefault(x => x.StudentID == newstudent.StudentID);

                // Neu da ton tai => Update
                if (entity != null)
                {
                    entity.FullName = newstudent.FullName;
                    entity.AverageScore = newstudent.AverageScore;
                    entity.Faculty.FacultyName = newstudent.FacultyID.ToString();
                    entity.FacultyID = newstudent.FacultyID;
                    entity.Avatar = newstudent.Avatar;
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                else
                {
                    // Neu chua ton tai => Add
                    db.Students.Add(newstudent);
                    MessageBox.Show("Thêm sinh viên mới thành công");
                }

                db.SaveChanges();
                loaddtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadform()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void loaddtgv()
        {
            var students = db.Students;
            List<Student> newstudents = students.ToList();
            BindGrid(newstudents);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                if (row.Cells["Column1"].Value != null)
                {
                    string studentID = row.Cells["Column1"].Value.ToString();
                    Student st = StudentService.FindByID(studentID);
                    textBox1.Text = st.StudentID.ToString();
                    textBox2.Text = st.FullName.ToString();
                    comboBox1.Text = st.Faculty.FacultyName.ToString();
                    textBox3.Text = st.AverageScore.ToString();
                    ShowAvatar(st.Avatar);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImagePath = LoadImage();

            if (ImagePath != null)
            {
                ShowAvatar(ImagePath);
            }
        }

        private string LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set initial directory and filter for image files
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog.FileName;
                return ImagePath;
            }

            // If the user canceled, return null
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studentdels = dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString();
            Student studentdel = db.Students.Find(studentdels);
            if (studentdel != null)
            {
                DialogResult result = MessageBox.Show($"ban co dong y xoa sinh vien {studentdel.FullName}", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Students.Remove(studentdel);
                    db.SaveChanges();

                    loaddtgv();
                    loadform();
                    MessageBox.Show($"xoa sinh vien {studentdel.FullName} thanh cong", "thong bao ", MessageBoxButtons.OK);
                }
            }
        }
    }
}
