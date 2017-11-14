using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiNetFramework.Context;
using WebApiNetFramework.Models;
namespace WebApiNetFramework.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        private WebApiNetFrameworkContext _context = new WebApiNetFrameworkContext();

        [HttpPost]
        [Route("Cadastrar")]
        public HttpResponseMessage Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("ObterPorNome/{nome}")]
        public HttpResponseMessage ObterPorNome(string nome)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.Nome.Equals(nome)
                                  select _usuario;
            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        [HttpGet]
        [Route("ObterPorCPF/{cpf}")]
        public HttpResponseMessage ObterPorCPF(string cpf)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.CPF.Equals(cpf)
                                  select _usuario;
            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        [HttpGet]
        [Route("ObterPorRG/{rg}")]
        public HttpResponseMessage ObterPorRG(string rg)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.RG.Equals(rg)
                                  select _usuario;
            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public HttpResponseMessage ObterTodos()
        {
            var usuarios = _context.Usuarios.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, usuarios);
        }
    }
}
