using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiNetFramework.Models
{
    public class Usuario
    {
        [Key]
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public Usuario()
        {
            ID = Guid.NewGuid();
        }
    }
}