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
    public class CategoriasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Categorias
        [HttpGet]
        public List<Categorias> Get() => db.Categorias.ToList();

        // GET api/Categorias/5
        [HttpGet("{id}")]
        public Categorias Get(int id) => db.Categorias.Find(id);

        // POST api/Categorias
        [HttpPost]
        public void Post(Categorias sync)
        {
            db.Categorias.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Categorias/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Categorias newObj)
        {
            var oldObj = db.Categorias.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Categorias/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Categorias.Remove(db.Categorias.Find(id));
            db.SaveChanges();
        }
    }
}
