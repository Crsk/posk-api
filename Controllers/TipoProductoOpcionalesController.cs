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
    public class TipoProductoOpcionalesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/TipoProductoOpcionales
        [HttpGet]
        public List<TipoProductoOpcionales> Get() => db.TipoProductoOpcionales.ToList();

        // GET api/TipoProductoOpcionales/5
        [HttpGet("{id}")]
        public TipoProductoOpcionales Get(int id) => db.TipoProductoOpcionales.Find(id);

        // POST api/TipoProductoOpcionales
        [HttpPost]
        public void Post(TipoProductoOpcionales sync)
        {
            db.TipoProductoOpcionales.Add(sync);
            db.SaveChanges();
        }

        // PUT api/TipoProductoOpcionales/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TipoProductoOpcionales newObj)
        {
            var oldObj = db.TipoProductoOpcionales.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/TipoProductoOpcionales/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.TipoProductoOpcionales.Remove(db.TipoProductoOpcionales.Find(id));
            db.SaveChanges();
        }
    }
}
