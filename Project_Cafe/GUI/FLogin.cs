using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FLogin : Form
    {
        Admin admin;
        public FLogin()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            DataTable data = BUS_Admin.Intance.CheckAccount(username,password);
            if (data.Rows.Count == 1)
            {
                FMain main = new FMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại","Thông báo",MessageBoxButtons.OKCancel);
            }
        }
    }
}
