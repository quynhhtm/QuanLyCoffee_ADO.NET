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
    public partial class FormTiLeNhomThucUongBanRa : Form
    {
        public FormTiLeNhomThucUongBanRa()
        {
            InitializeComponent();
        }

        private void FormTiLeNhomThucUongBanRa_Load(object sender, EventArgs e)
        {
            BLThongKe bLThongKe = new BLThongKe();
            DataTable dtNam = new DataTable();
            DataTable dtThang = new DataTable();
            dtNam = bLThongKe.DSNam().Tables[0];
            dtThang = bLThongKe.DSThang().Tables[0];
            cbbNam.DataSource = dtNam;
            cbbThang.DataSource = dtThang;

            cbbNam.DisplayMember = "Nam";
            cbbThang.DisplayMember = "Thang";
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            BLThongKe bLThongKe = new BLThongKe();
            DataTable dt = new DataTable();
            dt = bLThongKe.TiLeNhomThucUongBanRa(cbbThang.Text.Trim(), cbbNam.Text.Trim()).Tables[0];

            chart1.Titles.Clear();
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = "TenNhom";
            chart1.Series["Series1"].YValueMembers = "SoLuong";
            chart1.Titles.Add("Tỉ lệ nhóm thức uống bán ra");
        }
    }
}
