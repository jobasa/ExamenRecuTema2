using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class cuentaRepository
    {
        internal cuenta Retrieve()
        {
            cuenta c = new cuenta("12345678X",100,"Bankia", "5390700823285988");
            return c;
        }
    }
}