using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TableFood
    {
        private static DAO_TableFood instance;

        public static DAO_TableFood Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DAO_TableFood();
                return instance;
            }
        
        }
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public void UpdateStatusTable(int id,string status)
        {
            string query = "UpdateStatusTable @id , @status";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }
        public List<TableFood> getTableFood()
        {
            List<TableFood> list = new List<TableFood>();
            string query = "ListTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query,conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TableFood table = new TableFood();
                    table.Id = (int)dr["id"];
                    table.Name = dr["name"].ToString();
                    table.Status = dr["status"].ToString();
                    list.Add(table);
                }
                conn.Close();

            }
            catch(Exception)
            {
            }
            return list;
        }
    }
}
