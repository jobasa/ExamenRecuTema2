using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class eventoRepository
    {
        internal evento Retrieve()
        {
            evento e = new evento(1,"Valencia","Barça");
            return e;
        }
    }
}