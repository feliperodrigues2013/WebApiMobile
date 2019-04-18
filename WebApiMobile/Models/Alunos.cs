using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiMobile.Models
{
    public class Alunos
    {
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }    
        public string MUNICIPIO { get; set; }
        public string UF { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }
    }
}