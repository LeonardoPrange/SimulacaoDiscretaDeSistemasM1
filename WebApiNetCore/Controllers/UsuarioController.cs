using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiNetCore.DAO;
using System.Net.Http;
using WebApiNetCore.Models;
using System.Net;

namespace WebApiNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        [HttpPost]
        [Route("Cadastrar")]
        public HttpResponseMessage Cadastrar(Usuario usuario)
        {
            usuarioDAO.Adicionar(usuario);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}