using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoAnNhanh
{
    public partial class ListFoodReport : Form
    {
        public ListFoodReport()
        {
            InitializeComponent();
        }

        private void ListFoodReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanDoAnNhanhDataSet1.USP_GetListFoodReport' table. You can move, or remove it, as needed.
            this.USP_GetListFoodReportTableAdapter.Fill(this.QuanLyBanDoAnNhanhDataSet1.USP_GetListFoodReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
