using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class usuarioRepository
    {
        internal usuario Retrieve()
        {
            usuario u = new usuario("12345678X","Joan","Banyuls",19,"jobanyuls@gamail.com");
            return u;
        }
    }
}