using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnection conn = null;
            Form form = new Form();
            FLogin login = new FLogin();
            FSetting setting = new FSetting();
            try {
                conn = DataProvider.Instance.Connect();
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                   form = setting;
                }
                else
                {
                    form = login;
                }
                conn.Close();
                Application.Run(form);
            }
            catch (Exception) {
               
            }        
        }
    }
}
