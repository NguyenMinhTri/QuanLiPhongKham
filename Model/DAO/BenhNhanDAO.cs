using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class BenhNhanDAO
    {
        QuanLyPhongKham db = null;
        public BenhNhanDAO()
        {
            db = new QuanLyPhongKham();
        }

        public int Them(BenhNhan benhnhan)
        {
            if (db.BenhNhans.Any(o => o.CMND == benhnhan.CMND))
            {
                return 0;
            }

            db.BenhNhans.Add(benhnhan);
            db.SaveChanges();
            return benhnhan.MaBN;
        }

        public void CapNhat(BenhNhan benhnhan, int ID)
        {
            var bn = db.BenhNhans.Find(ID);
            bn.Ten = benhnhan.Ten;
            bn.NgheNghiep = benhnhan.NgheNghiep;
            bn.SDT = benhnhan.SDT;
            bn.Tuoi = benhnhan.Tuoi;
            db.SaveChanges();
        }

        public List<BenhNhan> ListBN()
        {
            return db.BenhNhans.OrderByDescending(x => x.MaBN).ToList();
        }

        public BenhNhan BenhNhanByID(int MaBN)
        {
            return db.BenhNhans.Find(MaBN);
        }

        public List<BenhNhan> TimBN(string TenBN)
        {
            return db.BenhNhans.Where(bn =>bn.Ten.Contains(TenBN)).ToList();
        }
    }
}
