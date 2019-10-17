using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{

    public class mercado
    {
        public mercado(int idMercado, string cuota_over, string cuota_under, string dinero_over, string dinero_under, int idPartido)
        {
            this.idMercado = idMercado;
            Cuota_over = cuota_over;
            Cuota_under = cuota_under;
            Dinero_over = dinero_over;
            Dinero_under = dinero_under;
            this.idPartido = idPartido;
        }

        public int idMercado { get; set; }
        public string Cuota_over { get; set; }
        public string Cuota_under { get; set; }
        public string Dinero_over { get; set; }
        public string Dinero_under { get; set; }
        public int idPartido { get; set; }
    }
}