using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNetCore.Models;

namespace WebApiNetCore.DAO
{
    public class UsuarioDAO
    {
        private WebApiNetCoreContext context = new WebApiNetCoreContext();

        public void Adicionar(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public IList<Usuario> ObterPorNome(string nome)
        {
            var listaDeUsuarios = from usuario in context.Usuarios
                                  where usuario.Nome.Equals(nome)
                                  select usuario;

            return listaDeUsuarios.ToList();
        }

        public IList<Usuario> ObterPorCPF(string CPF)
        {
            var listaDeUsuarios = from usuario in context.Usuarios
                                  where usuario.CPF.Equals(CPF)
                                  select usuario;

            return listaDeUsuarios.ToList();
        }

        public IList<Usuario> ObterPorRG(string RG)
        {
            var listaDeUsuarios = from usuario in context.Usuarios
                                  where usuario.RG.Equals(RG)
                                  select usuario;

            return listaDeUsuarios.ToList();
        }
        public IList<Usuario> ObterPorIdade(int idade)
        {
            var listaDeUsuarios = from usuario in context.Usuarios
                                  where usuario.Idade.Equals(idade)
                                  select usuario;

            return listaDeUsuarios.ToList();
        }
    }
}
