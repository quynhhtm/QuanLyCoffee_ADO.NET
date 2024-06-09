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
    public partial class FormReportHoaDonCungCapNL : Form
    {
        private string MaHD;
        public FormReportHoaDonCungCapNL(string MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.chiTietHoaDonCungCapNLTableAdapter.Fill(this.dataSet1.ChiTietHoaDonCungCapNL, this.MaHD);
            this.reportViewer1.RefreshReport();
        }
    }
}
