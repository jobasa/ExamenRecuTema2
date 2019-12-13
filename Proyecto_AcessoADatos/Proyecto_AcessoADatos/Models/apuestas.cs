using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestas
    {
        public apuestas(int Id, float Dinero_apostado, decimal Cuota, string Tipo_apuesta, int ID_MERCADO, int ID_USUARIOS)
        {
            this.Id = Id;
            this.Dinero_apostado = Dinero_apostado;
            this.Cuota = Cuota;
            this.Tipo_apuesta = Tipo_apuesta;
            this.ID_MERCADO = ID_MERCADO;
            this.ID_USUARIOS = ID_USUARIOS;
        }

        public int Id { get; set; }
        public float Dinero_apostado { get; set; }
        public decimal Cuota { get; set; }
        public string Tipo_apuesta { get; set; }
        public int ID_MERCADO { get; set; }
        public int ID_USUARIOS { get; set; }
        public mercado mercado { get; set; }
    }

    public class apuestasDTO
    {
        public apuestasDTO(string tipo_apuesta, decimal cuota, float dinero_apostado, int iD_MERCADO, int iD_USUARIOS)
        {
            Tipo_apuesta = tipo_apuesta;
            Cuota = cuota;
            Dinero_apostado = dinero_apostado;
            ID_MERCADO = iD_MERCADO;
            ID_USUARIOS = iD_USUARIOS;
        }

        public string Tipo_apuesta { get; set; }
        public decimal Cuota { get; set; }
        public float Dinero_apostado { get; set; }
        public int ID_MERCADO { get; set; }
        public int ID_USUARIOS { get; set; }




    }
}