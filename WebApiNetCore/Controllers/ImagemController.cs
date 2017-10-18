using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiNetCore.Context;
using WebApiNetCore.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApiNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Imagem")]
    public class ImagemController : Controller
    {
        private readonly WebApiNetCoreContext _context;
        private readonly IHostingEnvironment _env;

        public ImagemController(WebApiNetCoreContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }
        [HttpPost]
        [Route("Upload")]
        public Object Upload()
        {
            var imagem = HttpContext.Request.Form.Files[0];
            //var rotaVirtual = _Env.WebRootPath;
            var rotaVirtual = _env.ContentRootPath;
            var id = Guid.NewGuid();
            var caminhoParaSalvarArquivo = Path.Combine(rotaVirtual, "Uploads\\" + id + ".jpg");
            var fileStream = new FileStream(caminhoParaSalvarArquivo, FileMode.Create);
            imagem.CopyTo(fileStream);
            Imagem novaImagem = new Imagem(id, caminhoParaSalvarArquivo, imagem.FileName);
            _context.Imagens.Add(novaImagem);
            _context.SaveChanges();
            return novaImagem;
        }
    }
}