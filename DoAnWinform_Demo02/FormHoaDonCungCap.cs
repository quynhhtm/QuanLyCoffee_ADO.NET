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
    public partial class FormHoaDonCungCap : Form
    {
        BLNhaCungCap blNhaCungcap = null;
        BLNguyenLieu blNguyenLieu = null;
        DataTable dtNhaCungCap = null;
        DataTable dtNguyenLieu = null;
        string err = null;

        public FormHoaDonCungCap()
        {
            InitializeComponent();
            
        }

        private void LoadData()
        {
            blNhaCungcap = new BLNhaCungCap();
            blNguyenLieu = new BLNguyenLieu();
            dtNhaCungCap = new DataTable();
            dtNguyenLieu = new DataTable();

            dtNhaCungCap = blNhaCungcap.DSNhaCungCap().Tables[0];
            dtNguyenLieu = blNguyenLieu.DSNguyenLieu().Tables[0];

            cbbNCC.DataSource = dtNhaCungCap;
            cbbNL.DataSource = dtNguyenLieu;

            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";

            cbbNL.DisplayMember = "TenNL";
            cbbNL.ValueMember = "MaNL";
        }

        private void FormHoaDonCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            cbbNCC.Enabled = false;

            string MaNL = cbbNL.SelectedValue.ToString();
            string TenNL = cbbNL.Text.ToString();
            float DonGia;
            float.TryParse(txtDonGia.Text.Trim(), out DonGia);
            int SoLuong = (int)nudSoLuong.Value;

            List<string> str = new List<string> { MaNL, TenNL, SoLuong.ToString(), DonGia.ToString() };
            
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell;

            if(DonGia == 0)
            {
                txtDonGia.Focus();
            }
            else
            {
                foreach (string strItem in str)
                {
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = strItem;
                    row.Cells.Add(cell);
                }
                dgvHoaDonCungCap.Rows.Add(row);
                nudSoLuong.Value = 1;
                txtDonGia.ResetText();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<List<string>> myList = new List<List<string>>();
            foreach (DataGridViewRow row in dgvHoaDonCungCap.Rows)
            {
                if(!row.IsNewRow)
                {
                    List<string> list2 = new List<string>();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        list2.Add(row.Cells[i].Value.ToString());

                    }
                    myList.Add(list2);
                }
            }
            DateTime data = DateTime.Now;
            BLGiaoDichNhaCungCap bLGiaoDichNhaCungCap = new BLGiaoDichNhaCungCap();
            bLGiaoDichNhaCungCap.ThemHoaDon(cbbNCC.SelectedValue.ToString(), data, myList, ref err);
            MessageBox.Show("Thêm thành công");
            ResetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDonCungCap.CurrentCell.RowIndex;
            DataGridViewRow row = dgvHoaDonCungCap.Rows[r];
            if(!row.IsNewRow)
            {
                dgvHoaDonCungCap.Rows.RemoveAt(r);
            }
        }

        private void ResetAll()
        {
            cbbNCC.Enabled = true;
            txtDonGia.ResetText();
            nudSoLuong.Value = 1;
            dgvHoaDonCungCap.Rows.Clear();
            LoadData();
        }
    }
    
}
