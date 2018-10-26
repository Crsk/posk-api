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
    public class DatosNegocioController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/DatosNegocio
        [HttpGet]
        public List<DatosNegocio> Get() => db.DatosNegocio.ToList();

        // GET api/DatosNegocio/5
        [HttpGet("{id}")]
        public DatosNegocio Get(int id) => db.DatosNegocio.Find(id);

        // POST api/DatosNegocio
        [HttpPost]
        public void Post(DatosNegocio sync)
        {
            db.DatosNegocio.Add(sync);
            db.SaveChanges();
        }

        // PUT api/DatosNegocio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DatosNegocio newObj)
        {
            var oldObj = db.DatosNegocio.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/DatosNegocio/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.DatosNegocio.Remove(db.DatosNegocio.Find(id));
            db.SaveChanges();
        }
    }
}
