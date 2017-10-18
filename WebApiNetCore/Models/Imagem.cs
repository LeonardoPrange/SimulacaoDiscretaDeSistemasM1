using System;

namespace WebApiNetCore.Models
{
    public class Imagem
    {
        public Guid ID { get; set; }
        public string Caminho { get; set; }
        public string Nome { get; set; }

        public Imagem(Guid ID, string caminho, string nome)
        {
            this.ID = ID;
            this.Caminho = caminho;
            this.Nome = nome;
        }
    }
}
