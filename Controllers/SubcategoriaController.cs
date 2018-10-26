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
    public class SubcategoriasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Subcategorias
        [HttpGet]
        public List<Subcategorias> Get() => db.Subcategorias.ToList();

        // GET api/Subcategorias/5
        [HttpGet("{id}")]
        public Subcategorias Get(int id) => db.Subcategorias.Find(id);

        // POST api/Subcategorias
        [HttpPost]
        public void Post(Subcategorias sync)
        {
            db.Subcategorias.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Subcategorias/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Subcategorias newObj)
        {
            var oldObj = db.Subcategorias.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Subcategorias/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Subcategorias.Remove(db.Subcategorias.Find(id));
            db.SaveChanges();
        }
    }
}
