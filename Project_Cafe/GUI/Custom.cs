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
    public partial class Custom : UserControl
    {
        public Custom()
        {
            InitializeComponent();
        }

        private void Custom_Load(object sender, EventArgs e)
        {
            LHour.Text = DateTime.Now.ToString("HH:mm");
            LSeconds.Text = DateTime.Now.ToString("ss");
            LCalendar.Text = DateTime.Now.ToString("MMM - dd - yyyy");
            TCalendar.Start();

        }
    }
}
