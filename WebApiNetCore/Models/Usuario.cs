using System;

namespace WebApiNetCore.Models
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
    }
}
