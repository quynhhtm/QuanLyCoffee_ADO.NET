using DoAnWinform_Demo02.DS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinform_Demo02
{
    public partial class FormGiaoDichKhachHang : Form
    {
        DataTable dtThucUong = null;
        DataTable dtNhomThucUong = null;
        DataTable dtNhanVien = null;
        BLThucUong blThucUong = null;
        BLNhomThucUong blNhomThucUong = null;
        BLNhanVien blNhanVien = null;
        List<string> dsMaThucUong;
        string err = null;
        public FormGiaoDichKhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                blThucUong = new BLThucUong();
                blNhanVien = new BLNhanVien();
                dtThucUong = new DataTable();
                dtNhanVien = new DataTable();
                dsMaThucUong = new List<string>();
                dtThucUong.Clear();
                dtNhanVien.Clear();

                DataSet ds = blThucUong.DSThucUong();
                dtThucUong = ds.Tables[0];
                dgvThucUong.DataSource = dtThucUong;

                DataSet dsNV = blNhanVien.DSNhanVien();
                dtNhanVien = dsNV.Tables[0];
                cbbNhanVien.DataSource = dtNhanVien;

                cbbNhanVien.DisplayMember = "HoTenNV";
                cbbNhanVien.ValueMember = "MaNV";

                btnXuatPhieu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }

        private void LoadNhomThuc()
        {
            blNhomThucUong = new BLNhomThucUong();
            dtNhomThucUong = new DataTable();
            dtNhomThucUong.Clear();
            dtNhomThucUong = blNhomThucUong.DSNhomThucUong().Tables[0];
            foreach (DataRow row in dtNhomThucUong.Rows)
            {
                string columnValue = row["TenNhom"].ToString();
                TreeNode node = new TreeNode(columnValue);
                trvNhomThucUong.Nodes.Add(node);
            }

        }
        private void FormGiaoDichKhachHang01_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadNhomThuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int r = dgvThucUong.CurrentCell.RowIndex;

            string MaThucUong = dgvThucUong.Rows[r].Cells[0].Value.ToString();
            string TenThucUong = dgvThucUong.Rows[r].Cells[1].Value.ToString();
            string DonGia = dgvThucUong.Rows[r].Cells[3].Value.ToString();
            
            if(dsMaThucUong.Contains(MaThucUong))
            {
                DialogResult traloi = MessageBox.Show("Sản phẩm đã có trong hóa đơn, bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(traloi == DialogResult.OK)
                {
                    int slBanDau = int.Parse(dgvHoaDon.Rows[dsMaThucUong.IndexOf(MaThucUong)].Cells[3].Value.ToString());
                    dgvHoaDon.Rows[dsMaThucUong.IndexOf(MaThucUong)].Cells[3].Value = (slBanDau + nudSoLuong.Value).ToString();
                }
            }
            else
            {
                List<string> str = new List<string>() { MaThucUong, TenThucUong, DonGia, nudSoLuong.Value.ToString() };
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell;
                foreach (string strItem in str)
                {
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = strItem;
                    row.Cells.Add(cell);
                }
                dsMaThucUong.Add(MaThucUong);
                dgvHoaDon.Rows.Add(row);
            }
            nudSoLuong.Value = 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                BLGiaoDichKhachHang blGiaoDichKhachHang = new BLGiaoDichKhachHang();
                DateTime date = DateTime.Now;
                List<Pair> dsThucUong = new List<Pair>();
                int SoLuong;
                float DonGia;
                float ThanhTien = 0;
                float ThueVAT = 0;
                float GiamGia = 0;
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out SoLuong);
                        float.TryParse(row.Cells["GiaBan"].Value.ToString(), out DonGia);
                        dsThucUong.Add(new Pair(row.Cells["MaTU"].Value.ToString(), SoLuong));
                        ThanhTien += SoLuong * DonGia;
                    }
                }
                if (txtMaKH.Enabled == false)
                {
                    blGiaoDichKhachHang.ThemGiaoDichKhachHangCu(txtMaKH.Text.Trim(), date.Date.ToString(), cbbNhanVien.SelectedValue.ToString(), dsThucUong, ref err);
                }
                else
                {
                    blGiaoDichKhachHang.ThemGiaoDichKhachHangMoi(txtTenKH.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), date.Date.ToString(), cbbNhanVien.SelectedValue.ToString(), dsThucUong, ref err);
                }
                float.TryParse(txtThue.Text.Trim(), out ThueVAT);
                float.TryParse(txtGiamGia.Text.Trim(), out GiamGia);
                txtThanhTien.Text = ThanhTien.ToString();
                txtTong.Text = (ThanhTien + (ThueVAT * ThanhTien) - (GiamGia * ThanhTien)).ToString();
                btnXuatPhieu.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            blThucUong = new BLThucUong();
            dgvThucUong.DataSource = blThucUong.TimKiemThongTin(txtThongTin.Text.Trim()).Tables[0];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            LoadData();
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtGiamGia.ResetText();
            txtTong.ResetText();
            txtThanhTien.ResetText();
            txtTong.ResetText();
            dgvHoaDon.Rows.Clear();
            nudSoLuong.Value = 1;

            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnXuatPhieu.Enabled =  false;

            txtTenKH.Focus();
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            BLHoaDonThanhToan blHoaDon = new BLHoaDonThanhToan();
            DataTable dtHoaDon = new DataTable();
            dtHoaDon = blHoaDon.HoaDonMoi().Tables[0];
            string MaHD = dtHoaDon.Rows[0][0].ToString();
            string MaKH;
            if (txtMaKH.Enabled == true)
            {
                BLKhachHang blKhachHang = new BLKhachHang();
                DataTable dtKhachHang = new DataTable();
                dtKhachHang = blKhachHang.KhachHangMoi().Tables[0];
                MaKH = dtKhachHang.Rows[0][0].ToString();
            }
            else
            {
                MaKH = txtMaKH.Text.Trim();
            }
            FormReportGDKH form = new FormReportGDKH(MaKH, MaHD);
            form.ShowDialog();
            ResetAll();
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                this.txtTenKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
            {
                this.txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                this.txtDiaChi.Focus();
                return false;
            }
            if (dgvHoaDon.Rows[0].IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return false;
            }
            return true;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHoaDon.Rows[r];
                if (!row.IsNewRow)
                {
                    dgvHoaDon.Rows.RemoveAt(r);
                    dsMaThucUong.RemoveAt(r);
                }
            }
        }

        private void btnKiemTraKH_Click(object sender, EventArgs e)
        {
            BLGiaoDichKhachHang khachhang = new BLGiaoDichKhachHang();
            DataTable dt = new DataTable();
            dt = khachhang.TimKiem(txtMaKH.Text.Trim()).Tables[0];

            if (dt.Rows.Count > 0)
            {
                txtTenKH.Text = (string)dt.Rows[0]["TenKH"];
                txtSDT.Text = (string)dt.Rows[0]["SDT"];
                txtDiaChi.Text = (string)dt.Rows[0]["DiaChi"];
                txtTenKH.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtMaKH.Enabled = false;
            }
            else
            {
                ResetAll();
            }
        }
    }
}
