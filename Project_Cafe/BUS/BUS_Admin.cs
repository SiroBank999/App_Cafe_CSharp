﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_Admin
    {
        private static BUS_Admin intance;

        public static BUS_Admin Intance
        {
            get
            {
                if(intance == null)
                {
                    intance = new BUS_Admin();
                }
                return intance;
            } 
       
            set => intance = value; 
        }

        public DataTable CheckAccount(string username,string password)
        {
            return DAO_Admin.Instance.CheckAccount(username,password);
        }
    }
}
