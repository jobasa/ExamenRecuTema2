using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestas
    {
        public apuestas(int idApuestas, int dinero_apostado, string cuota, int mercado_apuesta, string tipo_apuesta, int idMercado, string dni)
        {
            this.idApuestas = idApuestas;
            Dinero_apostado = dinero_apostado;
            Cuota = cuota;
            Mercado_apuesta = mercado_apuesta;
            Tipo_apuesta = tipo_apuesta;
            this.idMercado = idMercado;
            Dni = dni;
        }

        public int idApuestas { get; set; }
        public int Dinero_apostado { get; set; }
        public string Cuota { get; set; }
        public int Mercado_apuesta { get; set; }
        public string Tipo_apuesta { get; set; }
        public int idMercado { get; set; }
        public string Dni { get; set; }
    }
}