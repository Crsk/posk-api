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
    public class ComprasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Compras
        [HttpGet]
        public List<Compras> Get() => db.Compras.ToList();

        // GET api/Compras/5
        [HttpGet("{id}")]
        public Compras Get(int id) => db.Compras.Find(id);

        // POST api/Compras
        [HttpPost]
        public void Post(Compras sync)
        {
            db.Compras.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Compras/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Compras newObj)
        {
            var oldObj = db.Compras.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Compras/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Compras.Remove(db.Compras.Find(id));
            db.SaveChanges();
        }
    }
}
