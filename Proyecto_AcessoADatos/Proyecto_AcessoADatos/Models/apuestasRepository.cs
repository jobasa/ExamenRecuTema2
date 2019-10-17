using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestasRepository
    {
        internal apuestas Retrieve()
        {
            apuestas a = new apuestas(1,100,"1.43",50,"over",1,"12345678X");
            return a;
        }
    }
}