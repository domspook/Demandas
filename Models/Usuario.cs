using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demandas.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOME { set; get; }
        public string CPF { set; get; }
    }
}