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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            BLTaiKhoan bLTaiKhoan = new BLTaiKhoan();
            bool flag = false;

            if (rdbQuanLy.Checked)
            {
                if (bLTaiKhoan.KTQuanLy(txtTenTK.Text.Trim(), txtMatKhau.Text.Trim()))
                {
                    flag = true;
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.ThongTinDangNhap(txtTenTK.Text.Trim());
                    formMain.ShowDialog();
                    this.Dispose();
                }
            }
            if (rdbNhanVien.Checked)
            {
                if (bLTaiKhoan.KiemTra(txtTenTK.Text.Trim(), txtMatKhau.Text.Trim()))
                {
                    flag = true;
                    this.Hide();
                    FormMainNV formNV = new FormMainNV();
                    formNV.ThongTinDangNhap(txtTenTK.Text.Trim());
                    formNV.ShowDialog();
                    this.Dispose();
                }
            }

            if (!flag)
            {
                txtTenTK.ResetText();
                txtMatKhau.ResetText();
                txtTenTK.Focus();
            }
        }

        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                txtTenTK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenTK_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

    }
}
