using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bill> bills = DAO_Bill.Instance.getBillByDate(DateTime.Now, DateTime.Now);
            int no = 1;
            foreach (Bill bill in bills)
            {
             
            }
        }
    }
}
