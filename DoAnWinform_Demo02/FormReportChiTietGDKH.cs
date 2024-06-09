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
    public partial class FormReportChiTietGDKH : Form
    {
        string MaKH;
        public FormReportChiTietGDKH(string MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.chiTietGiaoDichKHTableAdapter.Fill(this.dataSet1.ChiTietGiaoDichKH, this.MaKH);
            this.reportViewer1.RefreshReport();
        }
    }
}
