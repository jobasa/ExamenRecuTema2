using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class mercado
    {
        public int idMercado { get; set; }
        public string Cuota_over { get; set; }
        public string Cuota_under { get; set; }
        public string Dinero_over { get; set; }
        public string Dinero_under { get; set; }
        public int idPartido { get; set; }
    }
}