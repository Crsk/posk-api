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
    public class DeliveryItemController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/DeliveryItem
        [HttpGet]
        public List<DeliveryItem> Get() => db.DeliveryItem.ToList();

        // GET api/DeliveryItem/5
        [HttpGet("{id}")]
        public DeliveryItem Get(int id) => db.DeliveryItem.Find(id);

        // POST api/DeliveryItem
        [HttpPost]
        public void Post(DeliveryItem sync)
        {
            db.DeliveryItem.Add(sync);
            db.SaveChanges();
        }

        // PUT api/DeliveryItem/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeliveryItem newObj)
        {
            var oldObj = db.DeliveryItem.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/DeliveryItem/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.DeliveryItem.Remove(db.DeliveryItem.Find(id));
            db.SaveChanges();
        }
    }
}
