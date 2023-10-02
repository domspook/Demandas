using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demandas.Models
{
    public class Permissao
    {
        public int ID { get; set; }
        public string TP_PERMISSAO { get; set; }
        public string NM_CARGO { get; set; }
        public int USUARIO_ID { get; set; }
    }
}