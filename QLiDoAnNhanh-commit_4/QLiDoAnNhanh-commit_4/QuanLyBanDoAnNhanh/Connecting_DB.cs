using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanDoAnNhanh.DAO;

namespace QuanLyBanDoAnNhanh
{
    public partial class Connecting_DB : Form
    {
        public TextBox TxtServerName { get => txtServerName; set => txtServerName = value; }
        public TextBox TxtDatabaseName { get => txtDatabaseName; set => txtDatabaseName = value; }

        public Connecting_DB()
        {
            InitializeComponent();
        }

        private void btnConnecting_Click(object sender, EventArgs e)
        {
            //Data Source = LAPTOP - JTQDLG3Q; Initial Catalog = QuanLyBanDoAnNhanh; Integrated Security = True; User ID = sa
            DataProvider.ConnectionSTR = "Data source = " + TxtServerName.Text + "; Initial Catalog = " + TxtDatabaseName.Text + "; Integrated Security = True";
            this.Close();
        }
    }
}
