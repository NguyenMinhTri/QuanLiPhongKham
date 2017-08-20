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
    public partial class FormDangKiKhamBenh : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        DangKyPhieuKhamDAO dkPhieuKhamDAO =new DangKyPhieuKhamDAO();
        BenhNhanDAO benhnhanDAO = new BenhNhanDAO();
        KhamChuyenKhoaDAO khamCKDAO = new KhamChuyenKhoaDAO();
        CT_PhieuKhamDAO ct_PhieuKhamDAO = new CT_PhieuKhamDAO();
        List<BenhNhan> listBN = new List<BenhNhan>();
        int MaBN = -1;
        public FormDangKiKhamBenh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangKiKhamBenh_Load(object sender, EventArgs e)
        {
            lbSTT.Text = (dkPhieuKhamDAO.InitSTT() + 1).ToString();
            dtiNgayTao.Value = DateTime.Now;
            listBN = benhnhanDAO.ListBN();
            dataGVTimBN.DataSource = benhnhanDAO.ListBN();

            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            allowedTypes.AddRange(benhnhanDAO.ListBN().Select(o => (o.Ten)).ToArray());
            txtTimTenBN.AutoCompleteCustomSource = allowedTypes;
            txtTimTenBN.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimTenBN.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //load danh sach
            dataGVBenhNhan.DataSource = dkPhieuKhamDAO.DanhSach();
            foreach (DataGridViewRow dr in dataGVBenhNhan.Rows)
            {
                dr.Cells["Ten"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Ten;
                dr.Cells["NgaySinhBN"].Value = benhnhanDAO.BenhNhanByID(int.Parse(dr.Cells["colMaBN"].Value.ToString())).Tuoi;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGVTimBN.DataSource = benhnhanDAO.TimBN(txtTimTenBN.Text);
        }

        private void dataGVTimBN_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (System.Windows.Forms.DataGridView)sender;
            if (oBject.CurrentRow != null)
            {
                MaBN = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value);
                BenhNhan benhNhan = benhnhanDAO.BenhNhanByID(MaBN);
                txtTenBN.Text = benhNhan.Ten;
                txtCMND.Text = benhNhan.CMND;
                txtDiaChi.Text = benhNhan.DiaChi;
                txtNgheNghiep.Text = benhNhan.NgheNghiep;
                txtTuoi.Text = benhNhan.Tuoi;
                txtSDT.Text = benhNhan.SDT;
                lbSTT.Text = (dkPhieuKhamDAO.InitSTT()+1).ToString();
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
            DangKyPhieuKham dkPhieuKham = new DangKyPhieuKham();
            dkPhieuKham.LyDo = txtLyDoKham.Text;
            dkPhieuKham.MaBN = MaBN;
            dkPhieuKham.NgayKham = dtiNgayTao.Value;
            dkPhieuKham.Status = 0;
            dkPhieuKham.STT =int.Parse(lbSTT.Text);
            if(dkPhieuKhamDAO.Them(dkPhieuKham) == -1)
            {
                MessageBox.Show("Đã đăng ký hoặc chưa có kết quả lần trước");
            }
        }
    }
}
