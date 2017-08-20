using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class KQThuocDAO
    {
        QuanLyPhongKham db = null;
        public KQThuocDAO()
        {
            db = new QuanLyPhongKham();
        }

        public void Them(KetQuaThuoc kqThuoc)
        {
            db.KetQuaThuocs.Add(kqThuoc);
            db.SaveChanges();
        }

        public List<KetQuaThuoc> DSThuocThanhToan (int MaPDK)
        {
            return db.KetQuaThuocs.Where(o => o.MaPDK == MaPDK).ToList();
        }
    }
}
