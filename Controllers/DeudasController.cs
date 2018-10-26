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
    public class DeudasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Deudas
        [HttpGet]
        public List<Deudas> Get() => db.Deudas.ToList();

        // GET api/Deudas/5
        [HttpGet("{id}")]
        public Deudas Get(int id) => db.Deudas.Find(id);

        // POST api/Deudas
        [HttpPost]
        public void Post(Deudas sync)
        {
            db.Deudas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Deudas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Deudas newObj)
        {
            var oldObj = db.Deudas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Deudas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Deudas.Remove(db.Deudas.Find(id));
            db.SaveChanges();
        }
    }
}
