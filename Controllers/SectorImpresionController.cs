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
    public class SectorImpresionController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/SectorImpresion
        [HttpGet]
        public List<SectorImpresion> Get() => db.SectorImpresion.ToList();

        // GET api/SectorImpresion/5
        [HttpGet("{id}")]
        public SectorImpresion Get(int id) => db.SectorImpresion.Find(id);

        // POST api/SectorImpresion
        [HttpPost]
        public void Post(SectorImpresion sync)
        {
            db.SectorImpresion.Add(sync);
            db.SaveChanges();
        }

        // PUT api/SectorImpresion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SectorImpresion newObj)
        {
            var oldObj = db.SectorImpresion.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/SectorImpresion/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.SectorImpresion.Remove(db.SectorImpresion.Find(id));
            db.SaveChanges();
        }
    }
}
