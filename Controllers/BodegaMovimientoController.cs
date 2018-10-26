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
    public class BodegaMovimientoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/BodegaMovimiento
        [HttpGet]
        public List<BodegaMovimiento> Get() => db.BodegaMovimiento.ToList();

        // GET api/BodegaMovimiento/5
        [HttpGet("{id}")]
        public BodegaMovimiento Get(int id) => db.BodegaMovimiento.Find(id);

        // POST api/BodegaMovimiento
        [HttpPost]
        public void Post(BodegaMovimiento sync)
        {
            db.BodegaMovimiento.Add(sync);
            db.SaveChanges();
        }

        // PUT api/BodegaMovimiento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BodegaMovimiento newObj)
        {
            var oldObj = db.BodegaMovimiento.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/BodegaMovimiento/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.BodegaMovimiento.Remove(db.BodegaMovimiento.Find(id));
            db.SaveChanges();
        }
    }
}
