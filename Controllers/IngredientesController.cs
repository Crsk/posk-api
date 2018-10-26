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
    public class IngredientesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Ingredientes
        [HttpGet]
        public List<Ingredientes> Get() => db.Ingredientes.ToList();

        // GET api/Ingredientes/5
        [HttpGet("{id}")]
        public Ingredientes Get(int id) => db.Ingredientes.Find(id);

        // POST api/Ingredientes
        [HttpPost]
        public void Post(Ingredientes sync)
        {
            db.Ingredientes.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Ingredientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingredientes newObj)
        {
            var oldObj = db.Ingredientes.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Ingredientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Ingredientes.Remove(db.Ingredientes.Find(id));
            db.SaveChanges();
        }
    }
}
