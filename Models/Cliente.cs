using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name= "CPF")]
        public string? Cpf {get; set;}
        [Display(Name= "Data de Nascimento")]
        public string? Nascimento {get; set;}
    }
}