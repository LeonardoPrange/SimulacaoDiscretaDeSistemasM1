using System;
using System.Linq;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApiNetCore.Context;
using WebApiNetCore.Models;
using System.Collections.Generic;

namespace WebApiNetCore.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly WebApiNetCoreContext _context;

        public UsuarioController (WebApiNetCoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public HttpResponseMessage Cadastrar([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IList<Usuario> ObterTodos()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet]
        [Route("ObterPorNome/{nome}")]
        public Object ObterPorNome(string nome)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.Nome.Equals(nome)
                                  select _usuario;
            return usuario;
        }

        [HttpGet]
        [Route("ObterPorCPF/{cpf}")]
        public Object ObterPorCPF(string cpf)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.CPF.Equals(cpf)
                                  select _usuario;
            return usuario;
        }

        [HttpGet]
        [Route("ObterPorIdade/{idade}")]
        public Object ObterPorRG(int rg)
        {
            var usuario = from _usuario in _context.Usuarios
                                  where _usuario.RG.Equals(rg)
                                  select _usuario;

            return usuario;
        }
    }
}