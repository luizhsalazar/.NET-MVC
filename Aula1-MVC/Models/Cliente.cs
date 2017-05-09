using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1_MVC.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataCadastro { get; set; }


    }
}