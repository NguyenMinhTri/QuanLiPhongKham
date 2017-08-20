using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class FormHoaDon : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        ThuocDAO thuocDao = new ThuocDAO();
        DonViDAO donviDao = new DonViDAO();
        KQThuocDAO kqThuocDao = new KQThuocDAO();
        DangKyPhieuKhamDAO dkPhieuKhamDAO = new DangKyPhieuKhamDAO();
        BenhNhanDAO benhnhanDAO = new BenhNhanDAO();
        double TongTien = 0.0;
        int MaBN = -1;
        int MaDKPK = -1;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dataGVTimBN.DataSource = dkPhieuKhamDAO.DanhSachCho();
            foreach (DataGridViewRow dr in dataGVTimBN.Rows)
            {
                dr.Cells["Ten"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Ten;
                dr.Cells["Tuoi"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Tuoi;
            }
        }

        private void dataGVTimBN_SelectionChanged(object sender, EventArgs e)
        {
            TongTien = 0.0;
            MaBN = -1;
            MaDKPK = -1;
            var oBject = (System.Windows.Forms.DataGridView)sender;
            if (oBject.CurrentRow != null)
            {
                MaDKPK = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells["MaPDK"].Value);
                MaBN = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells["colMaBN"].Value);
                BenhNhan benhNhan = benhnhanDAO.BenhNhanByID(MaBN);
                txtTenBN.Text = benhNhan.Ten;
                txtDiaChi.Text = benhNhan.DiaChi;
                txtTuoi.Text = benhNhan.Tuoi;
                txtSDT.Text = benhNhan.SDT;
                //Lich su kham 
                List<KetQuaThuoc> kqThuoc = kqThuocDao.DSThuocThanhToan(MaDKPK);
                List<SoThuoc> soThuoc = thuocDao.DanhSach();
                for (int i = 0;i < kqThuoc.Count; i++)
                {
                    dataCTThuoc.Rows[i].Cells[0].Value = soThuoc.Where(o => o.MaThuoc == kqThuoc[i].MaThuoc).ToArray().First().TenThuoc;
                    string donvi = soThuoc.Where(o => o.MaThuoc == kqThuoc[i].MaThuoc).ToArray().First().DonViTinh;
                    dataCTThuoc.Rows[i].Cells[1].Value = donviDao.ThongTin(int.Parse(donvi)).TenDVT;
                    dataCTThuoc.Rows[i].Cells[2].Value = kqThuoc[i].SoLuong;
                    dataCTThuoc.Rows[i].Cells[3].Value = soThuoc.Where(o => o.MaThuoc == kqThuoc[i].MaThuoc).ToArray().First().GiaBan;
                    dataCTThuoc.Rows[i].Cells[4].Value = int.Parse(dataCTThuoc.Rows[i].Cells[2].Value.ToString()) * double.Parse(dataCTThuoc.Rows[i].Cells[3].Value.ToString());
                    TongTien +=double.Parse( dataCTThuoc.Rows[i].Cells[4].Value.ToString());
                    //string tenThuoc = soThuoc.Select(o => o.TenThuoc).ToArray().First();
                }
                txtSoTien.Text = TongTien.ToString();
                //  string tenThuoc thuocDao.DanhSach().Select(o => o.TenThuoc).ToList();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dkPhieuKhamDAO.ThanhToan(MaDKPK);
        }
    }
}
