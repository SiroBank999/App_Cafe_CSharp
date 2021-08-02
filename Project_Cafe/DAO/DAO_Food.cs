﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Collections.Generic;

namespace DAO
{
    public class DAO_Food
    {
        private static DAO_Food instance;
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private SqlDataReader dr = null;
        public static DAO_Food Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new DAO_Food();
                }
                return instance;
            }
                
        }
        public List<Foods> ListFoodByPrice(int price)
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFoodByPrice @price";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    //food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listFood;
        }
        public List<Foods> ListFoodByCate(string name)
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFoodByCate @name";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    //food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double)dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            return listFood;
        }
        public List<Foods> getListFood()
        {
            List<Foods> listFood = new List<Foods>();
            string query = "ListFood";
            try
            {
                conn = DataProvider.Instance.Connect();
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Foods food = new Foods();
                    food.IdFood = (int)dr["id"];
                    food.NameFood = dr["name"].ToString();
                    food.Id_categoryFood = (int)dr["idCategory"];
                    food.PriceFood = (double) dr["price"];
                    food.ImageFood = dr["image"].ToString();
                    listFood.Add(food);
                }
                conn.Close();
            }
            catch(Exception)
            {

            }
            return listFood;
        }


    }
}
