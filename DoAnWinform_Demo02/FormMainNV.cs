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
    public partial class FormMainNV : Form
    {
        string TenTK;

        public FormMainNV()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMaxed.Location = btnMax.Location;
            btnMaxed.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxed.Visible = false;
            btnMax.Visible = true;
        }

        private void FormMainNV_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGiaoDichKhachHang());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau form = new FormDoiMatKhau(TenTK);
            form.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            form.ShowDialog();
            this.Dispose();
        }

        public void ThongTinDangNhap(string TenTK)
        {
            lblTenDangNhap.Text = TenTK;
            this.TenTK = TenTK;
        }
    }
}
