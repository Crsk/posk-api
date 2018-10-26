using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoskApi.Models;
using System.IO;
using System.Net;

namespace PoskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PendientesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Pendientes
        [HttpGet]
        public List<Pendientes> Get() => db.Pendientes.ToList();

        // GET api/Pendientes/5
        [HttpGet("{id}")]
        public Pendientes Get(int id) => db.Pendientes.Find(id);

        // POST api/Pendientes
        [HttpPost]
        public void Post(Pendientes sync)
        {
            db.Pendientes.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Pendientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pendientes newObj)
        {
            var oldObj = db.Pendientes.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Pendientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Pendientes.Remove(db.Pendientes.Find(id));
            db.SaveChanges();
        }
    }
}
