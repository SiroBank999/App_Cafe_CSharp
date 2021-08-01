using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        // Hàm
        public void showControl(Control control)
        {
            PMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PMain.Controls.Add(control);
        }
        // Hàm Event
        private void btnHome_Click(object sender, EventArgs e)
        {
           Dashboard dashboard = new Dashboard();
           btnHome.Checked = true;
           if(btnHome.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnListSanPham.Checked = false;
                btnListUser.Checked = false;
            }
           showControl(dashboard);
        }
       

        private void FMain_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
            btnHome.Checked = true;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            btnDoanhThu.Checked = true;
            if(btnDoanhThu.Checked == true)
            {
                btnHome.Checked = false;
                btnListSanPham.Checked = false;
                btnListUser.Checked = false;
            }
        }

        private void btnListSanPham_Click(object sender, EventArgs e)
        {
            btnListSanPham.Checked = true;
            if (btnListSanPham.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnHome.Checked = false;
                btnListUser.Checked = false;
            }
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            StaffManager manager = new StaffManager();
            btnListUser.Checked = true;
            if (btnListUser.Checked == true)
            {
                btnDoanhThu.Checked = false;
                btnHome.Checked = false;
                btnListSanPham.Checked = false;
            }
            showControl(manager);
        }
    }
}
