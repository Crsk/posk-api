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
    public class DetalleBoletaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/DetalleBoleta
        [HttpGet]
        public List<DetalleBoleta> Get() => db.DetalleBoleta.ToList();

        // GET api/DetalleBoleta/5
        [HttpGet("{id}")]
        public DetalleBoleta Get(int id) => db.DetalleBoleta.Find(id);

        // POST api/DetalleBoleta
        [HttpPost]
        public void Post(DetalleBoleta sync)
        {
            db.DetalleBoleta.Add(sync);
            db.SaveChanges();
        }

        // PUT api/DetalleBoleta/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DetalleBoleta newObj)
        {
            var oldObj = db.DetalleBoleta.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/DetalleBoleta/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.DetalleBoleta.Remove(db.DetalleBoleta.Find(id));
            db.SaveChanges();
        }
    }
}
