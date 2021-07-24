using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Bill
    {
        private static BUS_Bill instance;

        public static BUS_Bill Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Bill();
                return instance;
            } 
        }
        public Bill getBillByIdTable(int id)
        {
            return DAO_Bill.Instance.getBillByIdTable(id);
        }
        public void InsertBill(int id)
        {
            DAO_Bill.Instance.InsertBill(id);
        }
    }
}
