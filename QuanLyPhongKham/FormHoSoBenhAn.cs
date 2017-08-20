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
    public partial class FormHoSoBenhAn : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        ThuocDAO thuocDao = new ThuocDAO();
        DonViDAO donviDao = new DonViDAO();
        KQThuocDAO kqThuocDao = new KQThuocDAO();
        DangKyPhieuKhamDAO dkPhieuKhamDAO = new DangKyPhieuKhamDAO();
        BenhNhanDAO benhnhanDAO = new BenhNhanDAO();
        int MaBN = -1;
        int MaDKPK = -1;
        public FormHoSoBenhAn()
        {
            InitializeComponent();
        }

        private void btnChuyenKhoa_Click(object sender, EventArgs e)
        {
            FormKhamChuyenKhoa formKhamChuyenKhoa = new FormKhamChuyenKhoa();
            formKhamChuyenKhoa.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoSoBenhAn_Load(object sender, EventArgs e)
        {
            ((DataGridViewComboBoxColumn)dataDonThuoc.Columns["TenThuoc"]).DataSource = thuocDao.DanhSach().Select(o => o.TenThuoc).ToList();
            //Khoi tao danh sach bn cho
            dataGVTimBN.DataSource = dkPhieuKhamDAO.DanhSachCho();
            foreach (DataGridViewRow dr in dataGVTimBN.Rows)
            {
                dr.Cells["Ten"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Ten;
                dr.Cells["Tuoi"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Tuoi;
            }
        }

        private void dataDonThuoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataDonThuoc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            foreach (DataGridViewRow dr in dataDonThuoc.Rows)
            {
                try
                {
                    var test = dr.Cells[0].Value.ToString();
                }
                catch
                {
                    break;
                }
                dr.Cells["DonVi"].Value = donviDao.ThongTin(int.Parse(thuocDao.TimThuoc(dr.Cells[0].Value.ToString()).DonViTinh)).TenDVT;
            }
        }

        private void dataGVTimBN_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (System.Windows.Forms.DataGridView)sender;
            if (oBject.CurrentRow != null)
            {
                MaDKPK = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells["MaPDK"].Value);
                MaBN = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells["colMaBN"].Value);
                BenhNhan benhNhan = benhnhanDAO.BenhNhanByID(MaBN);
                txtTenBN.Text = benhNhan.Ten;
                txtCMND.Text = benhNhan.CMND;
                txtDiaChi.Text = benhNhan.DiaChi;
                txtNgheNghiep.Text = benhNhan.NgheNghiep;
                txtTuoi.Text = benhNhan.Tuoi;
                txtSDT.Text = benhNhan.SDT;
                lbSTT.Text = oBject.Rows[oBject.CurrentRow.Index].Cells["STT"].Value.ToString();
                //Lich su kham 
                dataGVLichSuKham.DataSource = dkPhieuKhamDAO.LichSuKham(MaBN);
                dataGVLichSuKham.Columns["MaPDK"].Visible = false;
                dataGVLichSuKham.Columns["MaBN"].Visible = false;
                dataGVLichSuKham.Columns["STT"].Visible = false;
                dataGVLichSuKham.Columns["Status"].Visible = false;
                dataGVLichSuKham.Columns["MaNV"].Visible = false;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dkPhieuKhamDAO.SetKetQua(MaDKPK, txtChuanDoan.Text);
            foreach (DataGridViewRow dr in dataDonThuoc.Rows)
            {
                KetQuaThuoc kqThuoc = new KetQuaThuoc();
                kqThuoc.MaThuoc = thuocDao.TimThuoc(dr.Cells["TenThuoc"].Value.ToString()).MaThuoc;
                kqThuoc.MaPDK = MaDKPK;
                string kq = dr.Cells["SoLuong"].Value.ToString();
                kqThuoc.SoLuong = int.Parse(kq);
                kqThuoc.GhiChu = dr.Cells["GhiChu"].Value.ToString();
                kqThuoc.LieuDung = dr.Cells["CachDung"].Value.ToString();
                kqThuocDao.Them(kqThuoc);
            }
        }
    }
}
