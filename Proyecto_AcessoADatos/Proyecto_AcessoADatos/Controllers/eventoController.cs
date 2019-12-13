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
       /* public eventoDTO Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new eventoRepository();
            /*List<evento> eventos = repo.Retrieve();
            eventoDTO e = repo.RetrieveDTO();
            return e;
        }*/


        // GET: api/evento/5
        public evento Get(int id)
        {
            var repo = new eventoRepository();
            evento e= repo.Retrieve();
            return e;
        }

        // POST: api/evento
        public void Post([FromBody]evento Event)
        {
            var repo = new eventoRepository();
            //repo.Save(Event);
        }

        // PUT: api/evento/5
        public void Put(int id, [FromBody]string Equipo_Local, string Equipo_visitante)
        {
            var repo = new eventoRepository();
            //repo.Update(id, Equipo_Local, Equipo_visitante);
        }

        // DELETE: api/evento/5
        public void Delete(int id)
        {
            var repo = new eventoRepository();
            //repo.Delete(id);
        }
    }
}
