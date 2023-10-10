using KTGK.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTGK.BLL
{
    public class ClassBLL
    {
        public List<LoaiSP> GetAllLoaiSP()
        {
            using (var context = new SPModel())
            {
                return context.LoaiSPs.ToList();
            }
        }

        public List<Sanpham> GetAllSanpham()
        {
            using (var context = new SPModel())
            {
                return context.Sanphams.ToList();
            }
        }

        public List<Sanpham> GetSanphamByLoaiSP(string maLoai)
        {
            using (var context = new SPModel())
            {
                return context.Sanphams.Where(s => s.MaLoai == maLoai).ToList();
            }
        }
        
        public string GetTenLoaiSP(string maLoai)
        {
            using (var context = new SPModel())
            {
                var loaiSP = context.LoaiSPs.FirstOrDefault(l => l.MaLoai == maLoai);
                if (loaiSP != null)
                {
                    return loaiSP.TenLoai;
                }
                return string.Empty;
            }
        }
        
        public void AddSanpham(Sanpham sanpham)
        {
            using (var context = new SPModel())
            {
                context.Sanphams.Add(sanpham);
                context.SaveChanges();
            }
        }

        public void DeleteSanpham(string maSP)
        {
            using (var context = new SPModel())
            {
                var sanpham = context.Sanphams.FirstOrDefault(sp => sp.MaSP == maSP);
                if (sanpham != null)
                {
                    context.Sanphams.Remove(sanpham);
                    context.SaveChanges();
                }
            }
        }
        
        public void UpdateSanpham(string maSP, string tenSP, string ngayNhap, string maLoai)
        {
            using (var context = new SPModel())
            {
                var sanpham = context.Sanphams.FirstOrDefault(sp => sp.MaSP == maSP);
                if (sanpham != null)
                {
                    sanpham.TenSP = tenSP;
                    sanpham.Ngaynhap = DateTime.Parse(ngayNhap);
                    sanpham.MaLoai = maLoai;

                    context.SaveChanges();
                }
            }
        }

        public List<Sanpham> SearchSanphamByTenSP(string tenSP)
        {
            using (var context = new SPModel())
            {
                return context.Sanphams.Where(s => s.TenSP.Contains(tenSP)).ToList();
            }
        }
    }
}
