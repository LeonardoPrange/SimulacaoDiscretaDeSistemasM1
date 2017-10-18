using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using WebApiNetFramework.Models;
using WebApiNetFramework.Context;

namespace WebApiNetFramework.Controllers
{
    [RoutePrefix("api/Imagem")]
    public class ImagemController : ApiController
    {
        private WebApiNetFrameworkContext _context = new WebApiNetFrameworkContext();
        
        [HttpPost]
        [Route("Upload")]
        public HttpResponseMessage Upload()
        {
            var requisicao = HttpContext.Current.Request;
            var arquivo = requisicao.Files;
            var id = Guid.NewGuid();
            var caminhoParaSalvarArquivo = HttpContext.Current.Server.MapPath("~/Uploads/" + id + ".jpg");
            arquivo[0].SaveAs(caminhoParaSalvarArquivo);
            Imagem imagem = new Imagem(id, caminhoParaSalvarArquivo, arquivo[0].FileName);
            _context.Imagens.Add(imagem);
            _context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, imagem);
        }
    }
}
