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
    public class BodegaStockController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/BodegaStock
        [HttpGet]
        public List<BodegaStock> Get() => db.BodegaStock.ToList();

        // GET api/BodegaStock/5
        [HttpGet("{id}")]
        public BodegaStock Get(int id) => db.BodegaStock.Find(id);

        // POST api/BodegaStock
        [HttpPost]
        public void Post(BodegaStock sync)
        {
            db.BodegaStock.Add(sync);
            db.SaveChanges();
        }

        // PUT api/BodegaStock/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BodegaStock newObj)
        {
            var oldObj = db.BodegaStock.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/BodegaStock/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.BodegaStock.Remove(db.BodegaStock.Find(id));
            db.SaveChanges();
        }
    }
}
