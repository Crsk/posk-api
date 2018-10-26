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
    public class BoletaMediopagoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/BoletaMediopago
        [HttpGet]
        public List<BoletaMediopago> Get() => db.BoletaMediopago.ToList();

        // GET api/BoletaMediopago/5
        [HttpGet("{id}")]
        public BoletaMediopago Get(int id) => db.BoletaMediopago.Find(id);

        // POST api/BoletaMediopago
        [HttpPost]
        public void Post(BoletaMediopago sync)
        {
            db.BoletaMediopago.Add(sync);
            db.SaveChanges();
        }

        // PUT api/BoletaMediopago/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BoletaMediopago newObj)
        {
            var oldObj = db.BoletaMediopago.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/BoletaMediopago/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.BoletaMediopago.Remove(db.BoletaMediopago.Find(id));
            db.SaveChanges();
        }
    }
}
