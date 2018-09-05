using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace api
{
    public class servicoController : ApiController
    {
        private desafioapiEntities db = new desafioapiEntities();

        // GET: api/servico
        public IQueryable<servicos> Getservicos()
        {

            return db.servicos;
        }

        // GET: api/servico/5
        [ResponseType(typeof(servicos))]
        public IHttpActionResult Getservicos(int id)
        {
            
            servicos servicos = db.servicos.Find(id);
            if (servicos == null)
            {
                return NotFound();
            }

            return Ok(servicos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool servicosExists(int id)
        {
            return db.servicos.Count(e => e.Id == id) > 0;
        }
    }
}