using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class mercadoController : ApiController
    {
        // GET: api/mercado
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/mercado/5
        public mercado Get(int id)
        {
            var repo = new mercadoRepository();
            mercado m = repo.Retrieve();
            return m;
        }

        // POST: api/mercado
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/mercado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/mercado/5
        public void Delete(int id)
        {
        }
    }
}
