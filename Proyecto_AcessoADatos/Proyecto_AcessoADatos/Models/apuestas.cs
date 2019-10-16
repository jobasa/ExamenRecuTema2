using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestas
    {
        public int idApuestas { get; set; }
        public int Dinero_apostado { get; set; }
        public int Cuota { get; set; }
        public int Mercado_apuesta { get; set; }
        public int Tipo_apuesta { get; set; }
        public int idMercado { get; set; }
        public int Dni { get; set; }
    }
}