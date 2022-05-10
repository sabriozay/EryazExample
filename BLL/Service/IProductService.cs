using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Service
{
    public interface IProductService
    {

        void Add(Product product);
        List<Product> GetAll();
        void Delete(Product product);
        void Update(Product product);
    }
}
