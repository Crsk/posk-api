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
    public class TipoProductoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/TipoProducto
        [HttpGet]
        public List<TipoProducto> Get() => db.TipoProducto.ToList();

        // GET api/TipoProducto/5
        [HttpGet("{id}")]
        public TipoProducto Get(int id) => db.TipoProducto.Find(id);

        // POST api/TipoProducto
        [HttpPost]
        public void Post(TipoProducto sync)
        {
            db.TipoProducto.Add(sync);
            db.SaveChanges();
        }

        // PUT api/TipoProducto/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TipoProducto newObj)
        {
            var oldObj = db.TipoProducto.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/TipoProducto/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.TipoProducto.Remove(db.TipoProducto.Find(id));
            db.SaveChanges();
        }
    }
}
