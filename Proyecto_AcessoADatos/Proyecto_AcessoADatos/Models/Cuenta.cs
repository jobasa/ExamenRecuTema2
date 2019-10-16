using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class cuenta
    {
        public int Dni { get; set; }
        public int Saldo_actual { get; set; }
        public string Nombre_banco { get; set; }
        public string Num_tarjeta_vinculada { get; set; }
    }
}