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
    public class ReservasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Reservas
        [HttpGet]
        public List<Reservas> Get() => db.Reservas.ToList();

        // GET api/Reservas/5
        [HttpGet("{id}")]
        public Reservas Get(int id) => db.Reservas.Find(id);

        // POST api/Reservas
        [HttpPost]
        public void Post(Reservas sync)
        {
            db.Reservas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Reservas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Reservas newObj)
        {
            var oldObj = db.Reservas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Reservas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Reservas.Remove(db.Reservas.Find(id));
            db.SaveChanges();
        }
    }
}
