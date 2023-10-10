using KTGK.BLL;
using KTGK.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGK
{
    public partial class Form1 : Form
    {
        private ClassBLL spBLL;
        private ClassBLL loaiSPBLL;

        public Form1()
        {
            InitializeComponent();
            spBLL = new ClassBLL();
            loaiSPBLL = new ClassBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sanpham> searchResults = spBLL.GetAllSanpham();
            if (searchResults.Count > 0)
            {
                LoadListViewData(searchResults);
            }
            LoadLoaiSPComboBox();
        }
        private void LoadLoaiSPComboBox()
        {
            List<LoaiSP> loaiSPs = spBLL.GetAllLoaiSP();

            cbo_LoaiSP.DataSource = loaiSPs;
            cbo_LoaiSP.DisplayMember = "TenLoai";
            cbo_LoaiSP.ValueMember = "MaLoai";
        }
        private void LoadListViewData(List<Sanpham> sanphams)
        {
            lv_SanPham.Items.Clear();

            foreach (var sanpham in sanphams)
            {
                string[] row = { sanpham.MaSP, sanpham.TenSP, sanpham.Ngaynhap.ToString(), sanpham.MaLoai };
                var listViewItem = new ListViewItem(row);
                lv_SanPham.Items.Add(listViewItem);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<Sanpham> searchResults = spBLL.GetAllSanpham();

            string maSP = textBox2.Text;
            string tenSP = textBox3.Text;
            string ngayNhap = dateTimePicker1.Text;
            string maLoai = cbo_LoaiSP.SelectedValue?.ToString(); 

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(ngayNhap) || string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            Sanpham sanpham = new Sanpham
            {
                MaSP = maSP,
                TenSP = tenSP,
                Ngaynhap = DateTime.Parse(ngayNhap),
                MaLoai = maLoai
            };

            spBLL.AddSanpham(sanpham);

            MessageBox.Show("Thêm sản phẩm thành công.");

            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now; 
            cbo_LoaiSP.SelectedIndex = -1; 

            LoadListViewData(searchResults);
        }

        private void lv_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_SanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_SanPham.SelectedItems[0];
                string maSP = selectedItem.SubItems[0].Text;
                string tenSP = selectedItem.SubItems[1].Text;
                string ngayNhap = selectedItem.SubItems[2].Text;
                string maLoai = selectedItem.SubItems[3].Text;

                textBox2.Text = maSP;
                textBox3.Text = tenSP;
                dateTimePicker1.Text = ngayNhap;
                cbo_LoaiSP.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cbo_LoaiSP.SelectedIndex = -1;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<Sanpham> searchResults = spBLL.GetAllSanpham();
            if (lv_SanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_SanPham.SelectedItems[0];
                string maSP = selectedItem.SubItems[0].Text;
                string tenSP = selectedItem.SubItems[1].Text;
                string ngayNhap = selectedItem.SubItems[2].Text;
                string maLoai = selectedItem.SubItems[3].Text;

                textBox2.Text = maSP;
                textBox3.Text = tenSP;
                dateTimePicker1.Text = ngayNhap;
                cbo_LoaiSP.SelectedValue = maLoai;

                spBLL.DeleteSanpham(maSP);

                MessageBox.Show("Xóa sản phẩm thành công.");

                LoadListViewData(searchResults);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lv_SanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_SanPham.SelectedItems[0];
                string maSP = selectedItem.SubItems[0].Text;
                string tenSP = textBox3.Text;
                string ngayNhap = dateTimePicker1.Text;
                string maLoai = cbo_LoaiSP.SelectedValue?.ToString();

                spBLL.UpdateSanpham(maSP, tenSP, ngayNhap, maLoai);
                MessageBox.Show("Sửa sản phẩm thành công.");

                List<Sanpham> updatedSearchResults = spBLL.GetAllSanpham();
                LoadListViewData(updatedSearchResults);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            List<Sanpham> searchResults0 = spBLL.GetAllSanpham();
            string keyword = txt_Tim.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                List<Sanpham> searchResults1 = spBLL.SearchSanphamByTenSP(keyword);

                if (searchResults1.Count > 0)
                {
                    LoadListViewData(searchResults1);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào.");
                    LoadListViewData(searchResults1);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                LoadListViewData(searchResults0);
            }
        }
    }
}