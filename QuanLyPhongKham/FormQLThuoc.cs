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
    public partial class FormQLThuoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        ThuocDAO thuocDao = new ThuocDAO();
        DonViDAO donviDao = new DonViDAO();
        int MaThuoc = -1;
        public FormQLThuoc()
        {
            InitializeComponent();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            SoThuoc soThuoc = new SoThuoc();
            soThuoc.TenThuoc = txtTenThuoc.Text;
            soThuoc.GiaBan =double.Parse( txtDonGiaXuat.Text);
            soThuoc.GiaNhap = double.Parse(txtDonGiaNhap.Text);
            soThuoc.SoLuong = int.Parse(txtSoLuong.Text);
            soThuoc.NhaSanXuat = txtNSX.Text;
            if(thuocDao.ThemThuoc(soThuoc)== -1)
            {
                MessageBox.Show("Thuốc đã tồn tại vui lòng chọn nút cập nhật");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dataGVThuoc_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (System.Windows.Forms.DataGridView)sender;
            if (oBject.CurrentRow != null)
            {
                MaThuoc = Convert.ToInt32(oBject.Rows[oBject.CurrentRow.Index].Cells["colMaThuoc"].Value);
                SoThuoc soThuoc = thuocDao.ThongTin(MaThuoc);
                txtTenThuoc.Text = soThuoc.TenThuoc;
                txtDonGiaNhap.Text = soThuoc.GiaNhap.ToString();
                txtDonGiaXuat.Text = soThuoc.GiaBan.ToString();
                txtSoLuong.Text = soThuoc.SoLuong.ToString();
                txtNSX.Text = soThuoc.NhaSanXuat;
            }
        }

        private void FormQLThuoc_Load(object sender, EventArgs e)
        {
            dataGVThuoc.DataSource = thuocDao.DanhSach();
            foreach (DataGridViewRow dr in dataGVThuoc.Rows)
            {
                dr.Cells["colDonvi"].Value = donviDao.ThongTin(int.Parse(dr.Cells["colDonvi"].Value.ToString())).TenDVT;
                string res = dr.Cells["colMaBH"].Value.ToString() == "0" ? "Hỗ trợ" : "Không hỗ trợ" ;
                dr.Cells["colBHYT"].Value = res;
                dr.Cells["colTrangThai"].Value = dr.Cells["colMaTrangThai"].Value.ToString() == "1" ? "Còn SX" : "Ngừng SX";
            }
        }
    }
}
