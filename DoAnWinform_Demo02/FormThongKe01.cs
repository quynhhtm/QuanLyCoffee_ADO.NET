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
    public partial class FormThongKe01 : Form
    {
        public FormThongKe01()
        {
            InitializeComponent();
        }


        private void FormThongKe01_Load(object sender, EventArgs e)
        {
            BLThongKe bLThongKe = new BLThongKe();
            DataTable dt = new DataTable();
            dt = bLThongKe.DSNam().Tables[0];
            cbbNam.DataSource = dt;
            cbbNam.DisplayMember = "Nam";
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            if(rdbDoanhThu.Checked)
            {
                BieuDoDoanhThu();
            }
            else
            {
                BieuDoChiPhi();
            }
        }
        private void BieuDoDoanhThu()
        {
            BLThongKe bLThongKe = new BLThongKe();
            DataTable dt = new DataTable();
            dt = bLThongKe.DoanhThuThang(cbbNam.Text.ToString()).Tables[0];
            chart1.DataSource = dt;

            chart1.Titles.Clear();
            chart1.Series["Series1"].XValueMember = "thang";
            chart1.Series["Series1"].YValueMembers = "doanhthu";
            chart1.Titles.Add("Doanh thu tháng");
        }

        private void BieuDoChiPhi()
        {
            BLThongKe bLThongKe = new BLThongKe();
            DataTable dt = new DataTable();
            dt = bLThongKe.ChiPhiNguyenLieu(cbbNam.Text.ToString()).Tables[0];
            chart1.DataSource = dt;

            chart1.Titles.Clear();
            chart1.Series["Series1"].XValueMember = "Thang";
            chart1.Series["Series1"].YValueMembers = "ChiPhi";
            chart1.Titles.Add("Chi phí nguyên liệu");
        }

    }
}
