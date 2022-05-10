using BLL.Service;
using DAL.Adonet;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Manegement
{
    public class ProductManegement : IProductService
    {
        DbFuc _dbFuc=new DbFuc();
        public void Add(Product product)
        {
            _dbFuc.Add(product);

        }

        public void Delete(Product product)
        {
            _dbFuc.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _dbFuc.GetAll();
        }

        public void Update(Product product)
        {
             _dbFuc.Update(product);
        }
    }
}
