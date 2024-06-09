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
    public partial class FormDoiMatKhau : Form
    {
        string err;
        string TenTK;
        public FormDoiMatKhau(string TenTK)
        {
            InitializeComponent();
            this.TenTK = TenTK;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(KiemTraNhap())
            {
                BLTaiKhoan bLTaiKhoan = new BLTaiKhoan();
                if (bLTaiKhoan.KiemTra(TenTK, txtMKCu.Text.Trim()) || bLTaiKhoan.KTQuanLy(TenTK, txtMKCu.Text.Trim()))
                {
                    bool flag = bLTaiKhoan.ThayDoiMatKhau(TenTK, txtMKMoi.Text.Trim(), ref err);
                    if (flag)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!");
                    txtMKCu.ResetText();
                    txtMKMoi.ResetText();
                    txtMKCu.Focus();
                }
            }
        }

        private bool KiemTraNhap()
        {
            if(string.IsNullOrEmpty(txtMKCu.Text))
            {
                txtMKCu.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtMKMoi.Text))
            {
                txtMKMoi.Focus();
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
