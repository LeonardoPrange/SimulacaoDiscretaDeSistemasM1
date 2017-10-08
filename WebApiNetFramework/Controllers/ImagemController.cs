using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using WebApiNetFramework.DAO;

namespace WebApiNetFramework.Controllers
{
    [RoutePrefix("api/Imagem")]
    public class ImagemController : ApiController
    {
        private ImagemDAO imagemDAO = new ImagemDAO();
        
        [HttpPost]
        [Route("Upload")]
        public HttpResponseMessage Upload()
        {
            var imagem = imagemDAO.Upload(HttpContext.Current.Request);
            return Request.CreateResponse(HttpStatusCode.Created, imagem);
        }
    }
}
