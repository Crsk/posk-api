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
    public class PromocionesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Promociones
        [HttpGet]
        public List<Promociones> Get() => db.Promociones.ToList();

        // GET api/Promociones/5
        [HttpGet("{id}")]
        public Promociones Get(int id) => db.Promociones.Find(id);

        // POST api/Promociones
        [HttpPost]
        public void Post(Promociones sync)
        {
            db.Promociones.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Promociones/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Promociones newObj)
        {
            var oldObj = db.Promociones.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Promociones/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Promociones.Remove(db.Promociones.Find(id));
            db.SaveChanges();
        }
    }
}
