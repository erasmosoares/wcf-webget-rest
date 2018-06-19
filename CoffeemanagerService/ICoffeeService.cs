using ContentType;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CoffeemanagerService
{
    [ServiceContract]
    public interface ICoffeeService
    {
        [WebGet(UriTemplate = "coffee/{id}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Coffee GetCoffee(string id);

        [WebInvoke(Method = "POST", UriTemplate = "coffees")]
        [OperationContract]
        bool SaveCoffee(Coffee currentCoffee);

        [WebInvoke(Method = "DELETE",  UriTemplate = "coffee/{id}")]
        [OperationContract]
        bool RemoveCoffee(string id);

        [WebGet(UriTemplate = "coffees", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Coffee> GetAllCoffees();
    }
}
