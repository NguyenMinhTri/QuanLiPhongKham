using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ThuocDAO
    {
        QuanLyPhongKham db = null;
        public ThuocDAO()
        {
            db = new QuanLyPhongKham();
        }
        public List<SoThuoc> DanhSach()
        {
            return db.SoThuocs.ToList();
        }

        public SoThuoc TimThuoc(string TenThuoc)
        {
            return db.SoThuocs.Where(o => o.TenThuoc == TenThuoc).ToList().First();
        }

        public int ThemThuoc(SoThuoc thuoc)
        {
            if (db.SoThuocs.Any(o => o.TenThuoc == thuoc.TenThuoc))
            {
                return -1;
            }
            db.SoThuocs.Add(thuoc);
            db.SaveChanges();
            return thuoc.MaThuoc;
        }

        public SoThuoc ThongTin(int mathuoc)
        {
            return db.SoThuocs.Find(mathuoc);
        }
    }
}
