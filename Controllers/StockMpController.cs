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
    public class StockMpController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/StockMp
        [HttpGet]
        public List<StockMp> Get() => db.StockMp.ToList();

        // GET api/StockMp/5
        [HttpGet("{id}")]
        public StockMp Get(int id) => db.StockMp.Find(id);

        // POST api/StockMp
        [HttpPost]
        public void Post(StockMp sync)
        {
            db.StockMp.Add(sync);
            db.SaveChanges();
        }

        // PUT api/StockMp/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockMp newObj)
        {
            var oldObj = db.StockMp.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/StockMp/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.StockMp.Remove(db.StockMp.Find(id));
            db.SaveChanges();
        }
    }
}
