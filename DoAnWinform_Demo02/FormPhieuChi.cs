using DoAnWinform_Demo02.DS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform_Demo02
{
    public partial class FormPhieuChi : Form
    {
        BLGiaoDichNhaCungCap bLHoaDon = null;
        DataTable dtPhieuChi = null;
        string err = null;
        public FormPhieuChi()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bLHoaDon = new BLGiaoDichNhaCungCap();
            dtPhieuChi = new DataTable();

            dtPhieuChi = bLHoaDon.ChiTietHoaDon().Tables[0];
            dgvPhieuChi.DataSource = dtPhieuChi;
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bLHoaDon = new BLGiaoDichNhaCungCap();
            dgvPhieuChi.DataSource = bLHoaDon.TimKiemThongTin(txtThongTin.Text.Trim()).Tables[0];
        }

        private void dgvPhieuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhieuChi.CurrentCell.RowIndex;
            string MaHD = dgvPhieuChi.Rows[r].Cells[2].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                FormReportHoaDonCungCapNL form = new FormReportHoaDonCungCapNL(MaHD);
                form.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thongbao == DialogResult.OK)
                {
                    bLHoaDon = new BLGiaoDichNhaCungCap();
                    bLHoaDon.XoaHoaDon(ref err, MaHD);
                }
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormHoaDonCungCap HDCCNguyenLieu = new FormHoaDonCungCap();
            HDCCNguyenLieu.ShowDialog();
            LoadData();
        }
    }
}
