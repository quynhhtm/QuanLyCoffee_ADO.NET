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

namespace DoAnWinform_Demo02
{
    public partial class FormNhanVien01 : Form
    {
        DataTable dtNV = null;
        BLNhanVien blNV = new BLNhanVien();
        string err = null;
        public FormNhanVien01()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = blNV.DSNhanVien();
                dtNV = ds.Tables[0];
                dgvNV.DataSource = dtNV;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtNV = new DataTable();
            dtNV.Clear();
            DataSet ds = blNV.TimKiemThongTin(txtThongTin.Text.Trim());
            dtNV = ds.Tables[0];
            dgvNV.DataSource = dtNV;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormNhanVien02 new_form = new FormNhanVien02();
            new_form.Text = "Thêm nhân viên";
            new_form.ShowDialog();
            LoadData();
        }

        private void dgvNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Lấy chỉ mục dòng và cột của ô được nhấp chuột phải
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Kiểm tra xem người dùng đã nhấp chuột vào ô hợp lệ hay không (không phải tiêu đề, không phải ô trống)
                if (rowIndex >= 0 && columnIndex >= 0)
                {
                    ContextMenuStrip popup = new ContextMenuStrip();

                    // Create the menu items
                    ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Chỉnh sửa");
                    ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Xóa");

                    // Add the menu items to the ContextMenuStrip
                    popup.Items.Add(menuItem1);
                    popup.Items.Add(menuItem2);

                    // Show the ContextMenuStrip at the mouse cursor location
                    popup.Show(e.Location);

                    // Hiển thị ContextMenu tại vị trí chuột phải
                    dgvNV.CurrentCell = dgvNV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    popup.Show(dgvNV, dgvNV.PointToClient(Cursor.Position));

                    // Click
                    menuItem1.Click += new EventHandler(btnChinhSua_Click);
                    menuItem2.Click += new EventHandler(btnXoa_Click);
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;

            string MaNV = dgvNV.Rows[r].Cells[0].Value.ToString();
            string HoTenNV = dgvNV.Rows[r].Cells[1].Value.ToString();
            string NgSinh = dgvNV.Rows[r].Cells[2].Value.ToString();
            string DiaChi = dgvNV.Rows[r].Cells[3].Value.ToString();
            string Phai = dgvNV.Rows[r].Cells[4].Value.ToString();
            string MaLLV = dgvNV.Rows[r].Cells[5].Value.ToString();

            FormNhanVien02 new_form = new FormNhanVien02();
            new_form.Text = "Cập nhật thông tin";
            new_form.SetProperties(MaNV, HoTenNV, NgSinh, DiaChi, Phai, MaLLV);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thongbao == DialogResult.OK)
                {
                    int r = dgvNV.CurrentCell.RowIndex;
                    string MaNV = dgvNV.Rows[r].Cells[0].Value.ToString();
                    blNV = new BLNhanVien();
                    blNV.XoaNhanVien(ref err, MaNV);
                    LoadData();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thực hiện!");
            }
        }

        private void FormNhanVien01_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
