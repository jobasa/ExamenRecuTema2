﻿using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class apuestasController : ApiController
    {
        // GET: api/apuestas
        public IEnumerable<apuestas> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new apuestasRepository();
            List<apuestas> apuesta = repo.Retrieve();
            return apuesta;
        }

        // GET: api/apuestas/5
        public apuestas Get(int id)
        {
            /*var repo = new apuestasRepository();
            apuestas a = repo.Retrieve();*/
            return null;
        }

        // POST: api/apuestas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/apuestas/5
        public void Delete(int id)
        {
        }
    }
}
