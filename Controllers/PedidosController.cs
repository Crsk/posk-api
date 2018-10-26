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
    public class PedidosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Pedidos
        [HttpGet]
        public List<Pedidos> Get() => db.Pedidos.ToList();

        // GET api/Pedidos/5
        [HttpGet("{id}")]
        public Pedidos Get(int id) => db.Pedidos.Find(id);

        // POST api/Pedidos
        [HttpPost]
        public void Post(Pedidos sync)
        {
            db.Pedidos.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Pedidos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pedidos newObj)
        {
            var oldObj = db.Pedidos.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Pedidos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Pedidos.Remove(db.Pedidos.Find(id));
            db.SaveChanges();
        }
    }
}
