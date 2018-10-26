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
    public class DireccionesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Direcciones
        [HttpGet]
        public List<Direcciones> Get() => db.Direcciones.ToList();

        // GET api/Direcciones/5
        [HttpGet("{id}")]
        public Direcciones Get(int id) => db.Direcciones.Find(id);

        // POST api/Direcciones
        [HttpPost]
        public void Post(Direcciones sync)
        {
            db.Direcciones.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Direcciones/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Direcciones newObj)
        {
            var oldObj = db.Direcciones.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Direcciones/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Direcciones.Remove(db.Direcciones.Find(id));
            db.SaveChanges();
        }
    }
}
