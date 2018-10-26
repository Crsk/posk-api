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
    public class MedioPagoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/MedioPago
        [HttpGet]
        public List<MedioPago> Get() => db.MedioPago.ToList();

        // GET api/MedioPago/5
        [HttpGet("{id}")]
        public MedioPago Get(int id) => db.MedioPago.Find(id);

        // POST api/MedioPago
        [HttpPost]
        public void Post(MedioPago sync)
        {
            db.MedioPago.Add(sync);
            db.SaveChanges();
        }

        // PUT api/MedioPago/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MedioPago newObj)
        {
            var oldObj = db.MedioPago.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/MedioPago/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.MedioPago.Remove(db.MedioPago.Find(id));
            db.SaveChanges();
        }
    }
}
