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
    public class clienteController : ApiController
    {
        private desafioapiEntities db = new desafioapiEntities();

        // GET: api/cliente
        public IQueryable<cliente> Getcliente()
        {
            List<cliente> aux = new List<cliente>();
            IQueryable<cliente> queryClientes =
                from client in db.cliente
                orderby client.Nome ascending
                select client;
            foreach (cliente client in queryClientes)
            {
                aux.Add(client);
            }
            
            return aux.AsQueryable();
        }

        // GET: api/cliente/5
        [ResponseType(typeof(cliente))]
        public IHttpActionResult Getcliente(int id)
        {
            cliente cliente = db.cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        
        // POST: api/cliente
        [ResponseType(typeof(cliente))]
        public IHttpActionResult Postcliente(cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(cliente==null)
            {
                return BadRequest(ModelState);
            }

            List<cliente> aux = db.cliente.ToList();
            if(aux.Find(x => x.Email == cliente.Email)!=null)
            {
                return BadRequest(ModelState);
            }
            db.cliente.Add(cliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool clienteExists(int id)
        {
            return db.cliente.Count(e => e.Id == id) > 0;
        }
    }
}