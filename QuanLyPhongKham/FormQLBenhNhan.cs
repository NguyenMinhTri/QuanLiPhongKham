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
    public partial class FormQLBenhNhan : DevComponents.DotNetBar.Metro.MetroForm
    {
        BenhNhanDAO benhnhanDAO = new BenhNhanDAO();
        int IDBN = 0;
        public FormQLBenhNhan()
        {
            InitializeComponent();
        }
        private void checkBHYT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBHYT.Checked)
            {
                lbBaoHiem.Visible = true;
                txtBaoHiem.Visible = true;
            }
            else
            {
                lbBaoHiem.Visible = false;
                txtBaoHiem.Visible = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLBenhNhan_Load(object sender, EventArgs e)
        {
           dataGVBenhNhan.DataSource = benhnhanDAO.ListBN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BenhNhan benhNhan = new BenhNhan();
            benhNhan.Ten = txtTenBN.Text;
            benhNhan.CMND = txtCMND.Text;

            if (benhnhanDAO.Them(benhNhan) == 0)
            {
                MessageBox.Show("Bệnh Nhân Đã Tồn Tại");
            }
        }

        private void dataGVBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (System.Windows.Forms.DataGridView)sender;
            if (oBject.CurrentRow != null)
            {
                IDBN = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value);
                BenhNhan benhNhan = benhnhanDAO.BenhNhanByID(IDBN);
                txtTenBN.Text = benhNhan.Ten;
                txtCMND.Text = benhNhan.CMND;
                txtDiaChi.Text= benhNhan.DiaChi;
                txtNgheNghiep.Text= benhNhan.NgheNghiep;
                txtTuoi.Text= benhNhan.Tuoi;
                txtSDT.Text = benhNhan.SDT;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(IDBN != 0)
            {
                BenhNhan benhNhan = new BenhNhan();
                benhNhan.Ten = txtTenBN.Text;
                benhNhan.CMND = txtCMND.Text;
                benhNhan.DiaChi = txtDiaChi.Text;
                benhNhan.NgheNghiep = txtNgheNghiep.Text;
                benhNhan.Tuoi = txtTuoi.Text;
                benhNhan.SDT = txtSDT.Text;
                benhnhanDAO.CapNhat(benhNhan,IDBN);
                dataGVBenhNhan.DataSource = benhnhanDAO.ListBN();
            }
        }
    }
}
