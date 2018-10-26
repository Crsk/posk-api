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
    public class OpcionalesIngredientesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/OpcionalesIngredientes
        [HttpGet]
        public List<OpcionalesIngredientes> Get() => db.OpcionalesIngredientes.ToList();

        // GET api/OpcionalesIngredientes/5
        [HttpGet("{id}")]
        public OpcionalesIngredientes Get(int id) => db.OpcionalesIngredientes.Find(id);

        // POST api/OpcionalesIngredientes
        [HttpPost]
        public void Post(OpcionalesIngredientes sync)
        {
            db.OpcionalesIngredientes.Add(sync);
            db.SaveChanges();
        }

        // PUT api/OpcionalesIngredientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OpcionalesIngredientes newObj)
        {
            var oldObj = db.OpcionalesIngredientes.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/OpcionalesIngredientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.OpcionalesIngredientes.Remove(db.OpcionalesIngredientes.Find(id));
            db.SaveChanges();
        }
    }
}
