using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class EventoController : ApiController
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
        public Evento Get(int id)
        {
            var repo = new EventoRepository();
            Evento e= repo.Retrieve();
            return e;
        }

        // POST: api/evento
        public void Post([FromBody]Evento Event)
        {
            var repo = new EventoRepository();
            //repo.Save(Event);
        }

        // PUT: api/evento/5
        public void Put(int id, [FromBody]string Equipo_Local, string Equipo_visitante)
        {
            var repo = new EventoRepository();
            //repo.Update(id, Equipo_Local, Equipo_visitante);
        }

        // DELETE: api/evento/5
        public void Delete(int id)
        {
            var repo = new EventoRepository();
            //repo.Delete(id);
        }
    }
}
