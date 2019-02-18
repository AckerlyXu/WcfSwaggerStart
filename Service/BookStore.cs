using ServiceInterface;
using ServiceInterface.Models;
using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   [SwaggerWcf("Store.svc")]
    public class BookStore : IStore
    {
      //  [SwaggerWcfTag("Books")]
      //  [SwaggerWcfResponse(HttpStatusCode.Created, "Book created, value in the response body with id updated")]
      //  [SwaggerWcfResponse(HttpStatusCode.BadRequest, "Bad request", true)]
      //  [SwaggerWcfResponse(HttpStatusCode.InternalServerError,
      //"Internal error (can be forced using ERROR_500 as book title)", true)]
      //  public Book CreateBook(Book value)
      //  {
      //      return null;
      //  }

        [SwaggerWcfTag("Books")]

        [SwaggerWcfResponse(HttpStatusCode.OK, "Book found, value in the response body")]

       [SwaggerWcfResponse(HttpStatusCode.NoContent, "No books", true)]

        public Book[] ReadBooks(string filtername=null)

        {

            WebOperationContext woc = WebOperationContext.Current;



            if (woc == null)

                return null;



            if (Store.Books.Any())

            {

                woc.OutgoingResponse.StatusCode = HttpStatusCode.OK;

                return string.IsNullOrEmpty(filtername)

                    ? Store.Books.ToArray()

                    : Store.Books.Where(b => b.Author.Name.Contains(filtername) || b.Title.Contains(filtername)).ToArray();

            }



            woc.OutgoingResponse.StatusCode = HttpStatusCode.OK;

            return Store.Books.ToArray();

        }
    }
}
