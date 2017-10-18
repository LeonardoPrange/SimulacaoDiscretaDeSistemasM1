using System;
using System.Web;
using WebApiNetFramework.Models;

namespace WebApiNetFramework.DAO
{
    public class ImagemDAO
    {
        private WebApiNetFrameworkContext context = new WebApiNetFrameworkContext();

        public Imagem Upload(HttpRequest requisicao)
        {
            var arquivo = requisicao.Files;
            var id = Guid.NewGuid();
            var caminhoParaSalvarArquivo = HttpContext.Current.Server.MapPath("~/Uploads/" + id + ".jpg");
            arquivo[0].SaveAs(caminhoParaSalvarArquivo);
            Imagem imagem = new Imagem(id, caminhoParaSalvarArquivo, arquivo[0].FileName);
            context.Imagens.Add(imagem);
            context.SaveChanges();
            return imagem;
        }
    }
}