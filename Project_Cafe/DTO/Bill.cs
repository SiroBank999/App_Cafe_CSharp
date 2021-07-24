﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int id;
        private DateTime dateCheckIn;
        private DateTime dateCheckOut;
        private int idTable;
        private int status;

        public Bill()
        {
        }

        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, int idTable, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.IdTable = idTable;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
    }
}