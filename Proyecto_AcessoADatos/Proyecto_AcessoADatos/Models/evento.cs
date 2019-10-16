using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class evento
    {
        public int idPartido { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
    }
}