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
       /* public IEnumerable<evento> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new eventoRepository();
            List<evento> eventos = repo.Retrieve();
            return eventos;
        }*/

        // GET: api/evento
        public IEnumerable<eventoDTO> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new eventoRepository();
            List<eventoDTO> eventos = repo.RetrieveDTO();
            return eventos;
        }


        // GET: api/evento/5
        public evento Get(int id)
        {
            /*var repo= new eventoRepository();
            evento e= repo.Retrieve();*/
            return null;
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
