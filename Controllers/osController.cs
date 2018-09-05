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
    public class osController : ApiController
    {
        private desafioapiEntities db = new desafioapiEntities();

        // GET: api/os
        public IQueryable<os> Getos()
        {
            return db.os;
        }

        // GET: api/os/5
        [ResponseType(typeof(os))]
        public IHttpActionResult Getos(int id)
        {
            os os = db.os.Find(id);
            if (os == null)
            {
                return NotFound();
            }

            return Ok(os);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool osExists(int id)
        {
            return db.os.Count(e => e.Id == id) > 0;
        }
    }
}