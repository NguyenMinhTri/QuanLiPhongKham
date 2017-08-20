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
    public partial class FormKhamChuyenKhoa : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        BenhNhanDAO benhnhanDAO = new BenhNhanDAO();
        KhamChuyenKhoaDAO khamCKDAO = new KhamChuyenKhoaDAO();
        CT_PhieuKhamDAO ct_PhieuKhamDAO = new CT_PhieuKhamDAO();
        List<BenhNhan> listBN = new List<BenhNhan>();
        int MaBN = -1;
        public FormKhamChuyenKhoa()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void FormKhamChuyenKhoa_Load(object sender, EventArgs e)
        {
            listBN = benhnhanDAO.ListBN();
            cbbTenBN.DataSource = listBN.Select(o => (o.Ten)).ToList();
            dtiNgayTao.Value = DateTime.Now;
        }

        private void cbbTenBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexBN = cbbTenBN.SelectedIndex;
            if(indexBN != -1 )
            {
                var BN = listBN.Where(bn => bn.Ten == cbbTenBN.Items[indexBN].ToString());
                txtTuoi.Text = BN.First().Tuoi;
                txtSDT.Text = BN.First().SDT;
                txtCMND.Text = BN.First().CMND;
                txtDiaChi.Text = BN.First().DiaChi;
                txtBaoHiem.Text = BN.First().MaBH;
                MaBN = BN.First().MaBN;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhamChuyenKhoa khamCk = new KhamChuyenKhoa();
            khamCk.MaBN = MaBN;
            khamCk.NgayLap = dtiNgayTao.Value;
            khamCk.MaNV = 0;
            int MaPK = khamCKDAO.Them(khamCk);
            for (int i = 0; i < dataThongTin.RowCount; i++)
            {
                CT_PhieuKham ct_PhieuKham = new CT_PhieuKham();
                ct_PhieuKham.MaPK = MaPK;
                ct_PhieuKham.TenXN = dataThongTin.Rows[i].Cells[0].ToString();
                ct_PhieuKham.NoiDung = dataThongTin.Rows[i].Cells[1].ToString();
                ct_PhieuKhamDAO.Them(ct_PhieuKham);
            }
        }
    }
}
