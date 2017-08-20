using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CT_PhieuKhamDAO
    {
        QuanLyPhongKham db = null;
        public CT_PhieuKhamDAO()
        {
            db = new QuanLyPhongKham();
        }
        public int Them(CT_PhieuKham ct_pk)
        {
            if (db.CT_PhieuKham.Any(o => (o.MaPK == ct_pk.MaPK && o.TenXN == ct_pk.TenXN && o.NoiDung == ct_pk.NoiDung)))
            {
                return -1;
            }

            db.CT_PhieuKham.Add(ct_pk);
            db.SaveChanges();
            return ct_pk.MaCTPK;
        }
    }
}
