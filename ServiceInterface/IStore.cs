using ServiceInterface.Models;
using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface
{
    
    [ServiceContract]
   public interface IStore
    {


        [SwaggerWcfPath("/books", "Retrieve all books from the store")]

        [WebGet(UriTemplate = "/books?filter={filtername}", BodyStyle = WebMessageBodyStyle.Bare)]

       // [OperationContract]

        Book[] ReadBooks(string filtername=null);


    }
}
