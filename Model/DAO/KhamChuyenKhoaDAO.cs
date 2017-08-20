using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class KhamChuyenKhoaDAO
    {
        QuanLyPhongKham db = null;
        public KhamChuyenKhoaDAO()
        {
            db = new QuanLyPhongKham();
        }

        public int Them(KhamChuyenKhoa Kham)
        {
            db.KhamChuyenKhoas.Add(Kham);
            db.SaveChanges();
            return Kham.MaPK;
        }
    }
}
