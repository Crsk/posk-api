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
    public class VentasJornadaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/VentasJornada
        [HttpGet]
        public List<VentasJornada> Get() => db.VentasJornada.ToList();

        // GET api/VentasJornada/5
        [HttpGet("{id}")]
        public VentasJornada Get(int id) => db.VentasJornada.Find(id);

        // POST api/VentasJornada
        [HttpPost]
        public void Post(VentasJornada sync)
        {
            db.VentasJornada.Add(sync);
            db.SaveChanges();
        }

        // PUT api/VentasJornada/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VentasJornada newObj)
        {
            var oldObj = db.VentasJornada.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/VentasJornada/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.VentasJornada.Remove(db.VentasJornada.Find(id));
            db.SaveChanges();
        }
    }
}
