using Proyecto_AcessoADatos.Models;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/apuestas/5
        public apuestas Get(int id)
        {
            var repo = new apuestasRepository();
            apuestas a = repo.Retrieve();
            return a;
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
