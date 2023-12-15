using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Products
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INorthWindService" in both code and config file together.

    [ServiceContract]
    public interface INorthWindService
    {
        [OperationContract]
        List<Product> GetProducts();
        Product GetProductsDetails(int Id);
        Product EditProducts(int Id, string productsName);
    }
    [DataContract]
    public class Products
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        [DataMember]
        public Nullable<decimal> UnitPrice { get; set; }
        [DataMember]
        public Nullable<int> UnitsInStock { get; set; }
    }

}
