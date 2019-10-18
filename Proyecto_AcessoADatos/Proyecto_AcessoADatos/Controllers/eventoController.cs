using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class eventoController : ApiController
    {
        // GET: api/evento
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/evento/5
        public evento Get(int id)
        {
            var repo= new eventoRepository();
            evento e= repo.Retrieve();
            return e;
        }

        // POST: api/evento
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/evento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/evento/5
        public void Delete(int id)
        {
        }
    }
}
