using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiNetFramework.DAO;
using WebApiNetFramework.Models;

namespace WebApiNetFramework.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        [HttpPost]
        [Route("Cadastrar")]
        public HttpResponseMessage Cadastrar(Usuario usuario)
        {
            usuarioDAO.Adicionar(usuario);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("ObterPorNome/{nome}")]
        public HttpResponseMessage ObterPorNome(string nome)
        {
            var retorno = usuarioDAO.ObterPorNome(nome);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }

        [HttpGet]
        [Route("ObterPorCPF/{cpf}")]
        public HttpResponseMessage ObterPorCPF(string cpf)
        {
            var retorno = usuarioDAO.ObterPorCPF(cpf);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }

        [HttpGet]
        [Route("ObterPorIdade/{idade}")]
        public HttpResponseMessage ObterPorRG(int idade)
        {
            var retorno = usuarioDAO.ObterPorIdade(idade);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }
    }
}
