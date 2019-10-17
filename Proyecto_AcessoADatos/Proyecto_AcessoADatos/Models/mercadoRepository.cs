using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class mercadoRepository
    {
        internal mercado Retrieve()
        {
            mercado m = new mercado(1,"1.43","2.85","100","50",1);
            return m;
        }
    }
}