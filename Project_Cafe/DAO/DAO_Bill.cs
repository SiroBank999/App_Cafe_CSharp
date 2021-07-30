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
    public class DAO_Bill
    {
        private static DAO_Bill instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Bill Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DAO_Bill();
                return instance;
            }
        }
        public void InsertBill(int id)
        {
            string query = "InsertBill @idTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTable", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
        }
        public Bill getBillByIdTable(int id)
        {
            Bill bill = new Bill();
            string query = "getBillByIdTable @idTable";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@idTable", SqlDbType.Int).Value = id;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bill.Id = (int)dr["id"];
                    bill.DateCheckIn = (DateTime)dr["DateCheckIn"];
                    bill.IdTable = (int)dr["idTable"];
                    bill.Status = (int)dr["status"];
                    bill.DateCheckOut = (DateTime)dr["DateCheckOut"];
                }
                conn.Close();
            }
            catch(Exception)
            {

            }
            return bill;
        } 
    }
}
