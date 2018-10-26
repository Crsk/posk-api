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
    public class PedidosProductosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/PedidosProductos
        [HttpGet]
        public List<PedidosProductos> Get() => db.PedidosProductos.ToList();

        // GET api/PedidosProductos/5
        [HttpGet("{id}")]
        public PedidosProductos Get(int id) => db.PedidosProductos.Find(id);

        // POST api/PedidosProductos
        [HttpPost]
        public void Post(PedidosProductos sync)
        {
            db.PedidosProductos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/PedidosProductos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PedidosProductos newObj)
        {
            var oldObj = db.PedidosProductos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/PedidosProductos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.PedidosProductos.Remove(db.PedidosProductos.Find(id));
            db.SaveChanges();
        }
    }
}
