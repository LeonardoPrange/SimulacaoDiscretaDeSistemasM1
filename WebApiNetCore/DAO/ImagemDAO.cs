//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WebApiNetCore.Models;

//namespace WebApiNetCore.DAO
//{
//    public class ImagemDAO
//    {
//        private WebApiNetCoreContext context = new WebApiNetCoreContext();

//        public Imagem Upload(HttpRequest requisicao)
//        {
//            var arquivo = requisicao.Files;
//            var id = Guid.NewGuid();
//            var caminhoParaSalvarArquivo = HttpContext.Current.Server.MapPath("~/Uploads/" + id + ".jpg");
//            arquivo[0].SaveAs(caminhoParaSalvarArquivo);
//            Imagem imagem = new Imagem(id, caminhoParaSalvarArquivo, arquivo[0].FileName);
//            context.Imagens.Add(imagem);
//            context.SaveChanges();
//            return imagem;
//        }
//    }
//}
