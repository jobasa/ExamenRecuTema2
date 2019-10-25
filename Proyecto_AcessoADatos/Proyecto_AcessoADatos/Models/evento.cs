using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class evento
    {
        public evento(int idPartido, string equipo_Local, string equipo_Visitante)
        {
            this.idPartido = idPartido;
            Equipo_Local = equipo_Local;
            Equipo_Visitante = equipo_Visitante;
        }

        public int idPartido { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
    }

    public class eventoDTO
    {
        public eventoDTO(string equipo_Local, string equipo_Visitante)
        {
            Equipo_Local = equipo_Local;
            Equipo_Visitante = equipo_Visitante;
        }

        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
    }
}