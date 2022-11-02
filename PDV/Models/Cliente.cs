using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Models
{
    public class Cliente
    {
        [Key]
        public string CPF { get; set; }
        public string Nome { get; set; }
 
        public DateTime DataNascimento { get; set; }


    }
}
