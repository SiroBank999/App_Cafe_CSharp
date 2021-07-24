using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TableFood
    {
        private static BUS_TableFood instance;

        public static BUS_TableFood Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BUS_TableFood();
                return instance;
            }

        }
        public List<TableFood> getTableFood()
        {
            return DAO_TableFood.Instance.getTableFood();
        }
        public void UpdateStatusTable(int id, string status)
        {
            DAO_TableFood.Instance.UpdateStatusTable(id, status);
        }
    }
}
