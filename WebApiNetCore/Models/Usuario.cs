using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNetCore.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
    }
}
