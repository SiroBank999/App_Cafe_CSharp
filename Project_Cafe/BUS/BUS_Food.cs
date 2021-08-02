using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Food
    {
        private static BUS_Food instance;

        public static BUS_Food Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new BUS_Food();
                }
                return instance;
            }
            set => instance = value;
        }
        public List<Foods> getListFood()
        {
            return DAO_Food.Instance.getListFood();
        }
        public List<Foods> ListFoodByCate(string name)
        {
            return DAO_Food.Instance.ListFoodByCate(name);
        }
        public List<Foods> ListFoodByPrice(int price)
        {
            return DAO_Food.Instance.ListFoodByPrice(price);
        }
    }
}
