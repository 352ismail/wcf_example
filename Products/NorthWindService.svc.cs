using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Products
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NorthWindService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NorthWindService.svc or NorthWindService.svc.cs at the Solution Explorer and start debugging.
    public class NorthWindService : INorthWindService
    {
        ProductDbEntity context = new ProductDbEntity();
       
        public List<Product> GetProducts()
        {
            //var conn = ConfigurationManager.ConnectionStrings["ProductDbEntity"].ConnectionString;
            return context.Products.ToList();
        }
        public Product GetProductsDetails(int Id)
        {
            return context.Products.Where(x=>x.Id == Id).FirstOrDefault();
        }
        public Product EditProducts(int Id , string productsName)
        {
            var product = context.Products.Where(x => x.Id == Id).FirstOrDefault();
            product.ProductName = productsName;
            context.SaveChanges();
            return product;
        }
    }

}
