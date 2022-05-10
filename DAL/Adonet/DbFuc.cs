using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Adonet
{
  public  class DbFuc: Context
    {

        public void Add(Product entity)
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {           

                SqlCommand cmd = new SqlCommand("AddProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ProductName ", entity.ProductName);
            
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        public void Delete(Product entity)
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {

              

                SqlCommand cmd = new SqlCommand("DeleteProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Id", entity.Id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        public void Update(Product entity)
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {



                SqlCommand cmd = new SqlCommand("UpdateProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("GetAllProduct", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(dr[0]),
                        ProductName = (dr[1]).ToString(),
                        IsDelete = Convert.ToBoolean(dr[2])
                    };
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
