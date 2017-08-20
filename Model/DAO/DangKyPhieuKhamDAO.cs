using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DangKyPhieuKhamDAO
    {
        QuanLyPhongKham db = null;
        public DangKyPhieuKhamDAO()
        {
            db = new QuanLyPhongKham();
        }

        public int Them(DangKyPhieuKham dkpk)
        {
            //Chua co kq thi khong dc lap them phieu
            if (db.DangKyPhieuKhams.Any(o => o.MaBN == dkpk.MaBN && o.Status == 0 && o.KetQua == null))
            {
                return -1;
            }

            db.DangKyPhieuKhams.Add(dkpk);
            db.SaveChanges();
            return dkpk.MaPDK;
        }

        public int InitSTT()
        {
            var today = DateTime.Today.Date;
            if(!db.DangKyPhieuKhams.Any(t => DbFunctions.TruncateTime(t.NgayKham) == today))
            {
                return 0;
            }
            return db.DangKyPhieuKhams.OrderByDescending(o => o.NgayKham).First().STT;
        }

        public List<DangKyPhieuKham> LichSuKham(int MaBN)
        {
            return db.DangKyPhieuKhams.Where(o => o.MaBN == MaBN && o.KetQua != null).ToList();
        }

        public List<DangKyPhieuKham> DanhSach()
        {
            return db.DangKyPhieuKhams.OrderByDescending(o => o.NgayKham).ToList();
        }

        public List<DangKyPhieuKham> DanhSachCho()
        {
            return db.DangKyPhieuKhams.Where(o => o.Status == 0 && (o.KetQua == null || o.KetQua=="")).ToList();
        }

        public void SetKetQua(int maphieu,string kq)
        {
            var phieu = db.DangKyPhieuKhams.Find(maphieu);
            phieu.KetQua = kq;
            phieu.Status = 1;
            db.SaveChanges();
        }

        public List<DangKyPhieuKham> DanhSachChoThanhToan()
        {
            return db.DangKyPhieuKhams.Where(o => o.Status == 1 && (o.KetQua != null || o.KetQua != "")).ToList();
        }

        public void ThanhToan(int maphieu)
        {
            var phieu = db.DangKyPhieuKhams.Find(maphieu);
            phieu.Status = 2;
            db.SaveChanges();
        }
    }
}
