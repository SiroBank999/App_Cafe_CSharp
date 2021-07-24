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
            Bill bills = DAO_Bill.Instance.getBillByIdTable(2);
            
          
                Console.WriteLine(bills.DateCheckIn);
           
            Console.ReadLine();
        }
    }
}
