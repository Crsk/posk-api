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
    public class ProductoProductocomplejoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/ProductoProductocomplejo
        [HttpGet]
        public List<ProductoProductocomplejo> Get() => db.ProductoProductocomplejo.ToList();

        // GET api/ProductoProductocomplejo/5
        [HttpGet("{id}")]
        public ProductoProductocomplejo Get(int id) => db.ProductoProductocomplejo.Find(id);

        // POST api/ProductoProductocomplejo
        [HttpPost]
        public void Post(ProductoProductocomplejo sync)
        {
            db.ProductoProductocomplejo.Add(sync);
            db.SaveChanges();
        }

        // PUT api/ProductoProductocomplejo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductoProductocomplejo newObj)
        {
            var oldObj = db.ProductoProductocomplejo.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/ProductoProductocomplejo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ProductoProductocomplejo.Remove(db.ProductoProductocomplejo.Find(id));
            db.SaveChanges();
        }
    }
}
