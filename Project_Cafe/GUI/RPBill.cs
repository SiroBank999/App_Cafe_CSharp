using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class RPBill : Form
    {
        List<ItemBill> bills; 
        public RPBill(List<ItemBill> items)
        {
            InitializeComponent();
            this.bills = items;
        }

        private void RPBill_Load(object sender, EventArgs e)
        {
            RPVBill.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            RPVBill.LocalReport.ReportPath = "PRBill.rdlc";
            if(bills != null)
            {
                ReportDataSource source = new ReportDataSource();
                source.Name = "DataBill";
                source.Value = bills;
                RPVBill.LocalReport.DataSources.Clear();
                RPVBill.LocalReport.DataSources.Add(source);
            }
            this.RPVBill.RefreshReport();
        }
    }
}
