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
    public class CategoriaSubcategoriaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/CategoriaSubcategoria
        [HttpGet]
        public List<CategoriaSubcategoria> Get() => db.CategoriaSubcategoria.ToList();

        // GET api/CategoriaSubcategoria/5
        [HttpGet("{id}")]
        public CategoriaSubcategoria Get(int id) => db.CategoriaSubcategoria.Find(id);

        // POST api/CategoriaSubcategoria
        [HttpPost]
        public void Post(CategoriaSubcategoria sync)
        {
            db.CategoriaSubcategoria.Add(sync);
            db.SaveChanges();
        }

        // PUT api/CategoriaSubcategoria/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoriaSubcategoria newObj)
        {
            var oldObj = db.CategoriaSubcategoria.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/CategoriaSubcategoria/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.CategoriaSubcategoria.Remove(db.CategoriaSubcategoria.Find(id));
            db.SaveChanges();
        }
    }
}
