using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        
        [OperationContract]
        String GetProductName(int productId);

        [OperationContract]
        IEnumerable<ProductInformation> GetProductInfo(int productId);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ProductService.ContractType".
    [DataContract]
    public class ProductInformation
    {
        [DataMember]
        public int ProductId
        {
            get;
            set;
        }
        [DataMember]
        public String ProductName
        {
            get;
            set;
        }
        [DataMember]
        public int ProductPrice
        {
            get;
            set;
        }
    }
}
