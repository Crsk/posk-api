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
    public class StockPrController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/StockPr
        [HttpGet]
        public List<StockPr> Get() => db.StockPr.ToList();

        // GET api/StockPr/5
        [HttpGet("{id}")]
        public StockPr Get(int id) => db.StockPr.Find(id);

        // POST api/StockPr
        [HttpPost]
        public void Post(StockPr sync)
        {
            db.StockPr.Add(sync);
            db.SaveChanges();
        }

        // PUT api/StockPr/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockPr newObj)
        {
            var oldObj = db.StockPr.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/StockPr/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.StockPr.Remove(db.StockPr.Find(id));
            db.SaveChanges();
        }
    }
}
