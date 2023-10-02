using lap04_01.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap04_01
{
    public partial class timkiem : Form
    {
        StudentcontextDB student=new StudentcontextDB();
        public timkiem()
        {
            InitializeComponent();
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {
            List<Student> listfacu = new List<Student>();
            string keyword = txtma.Text;
            foreach(var faculty in student.Students) 
             {
                // Nếu tên khoa hoặc mã khoa chứa từ khóa tìm kiếm
                if (faculty.FullName.Contains(keyword))
                {
                    // Thêm khoa vào danh sách kết quả
                    listfacu.Add(faculty);
                }
            }

            // Hiển thị kết quả tìm kiếm lên giao diện
            Bindinggrid(listfacu);
            int dem = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dem++;
            }
            txttimkiem.Text = dem.ToString();
        }
        private void Bindinggrid(List<Student> liststudents)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in liststudents)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudenID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[2].Value = item.AverageScore;

            }
        }

        private void fillfalcultycombobox(List<Faculty> listfacu)
        {
            this.comboBox1.DataSource = listfacu;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";
        }
        Student newstu= new Student();

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            newstudent.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue.ToString());
            string keyword = comboBox1.SelectedValue.ToString();

            var listfacu = from student in student.Students
                           where student.FacultyID.ToString() == keyword
                           select student;

            Bindinggrid(listfacu);
            */
            List<Student> listfacu = new List<Student>();
           
             string keyword = comboBox1.SelectedValue.ToString();
            foreach (var faculty in student.Students)
            {
                // Nếu tên khoa hoặc mã khoa chứa từ khóa tìm kiếm
                if (faculty.FacultyID.ToString().Contains(keyword))
                {
                    // Thêm khoa vào danh sách kết quả
                    listfacu.Add(faculty);
                }
            }

            // Hiển thị kết quả tìm kiếm lên giao diện
            Bindinggrid(listfacu);
            int dem = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dem++;
            }
            txttimkiem.Text = dem.ToString();
        }

        private void txttensv_TextChanged(object sender, EventArgs e)
        {
            List<Student> listfacu = new List<Student>();
            string keyword = txttensv.Text;
            foreach (var faculty in student.Students)
            {
                // Nếu tên khoa hoặc mã khoa chứa từ khóa tìm kiếm
                if (faculty.FullName.Contains(keyword))
                {
                    // Thêm khoa vào danh sách kết quả
                    listfacu.Add(faculty);
                }
            }

            // Hiển thị kết quả tìm kiếm lên giao diện
            Bindinggrid(listfacu);
            
        }

        private void timkiem_Load(object sender, EventArgs e)
        {
            // goi csdl
            List<Student> liststudents = student.Students.ToList();
            List<Faculty> listfacu = student.Faculties.ToList();

            fillfalcultycombobox(listfacu);
            Bindinggrid(liststudents);
            comboBox1.SelectedIndex = 0;
            txtma.Text = "";
            txttensv.Text = "";
            txttimkiem.Text = "";

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            timkiem_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
