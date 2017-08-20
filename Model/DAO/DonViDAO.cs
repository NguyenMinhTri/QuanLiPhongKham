using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DonViDAO
    {
        QuanLyPhongKham db = null;
        public DonViDAO()
        {
            db = new QuanLyPhongKham();
        }
        public DonViTinh ThongTin(int id)
        {
            return db.DonViTinhs.Find(id);
        }
    }
}
