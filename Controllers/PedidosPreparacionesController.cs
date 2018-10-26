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
    public class PedidosPreparacionesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/PedidosPreparaciones
        [HttpGet]
        public List<PedidosPreparaciones> Get() => db.PedidosPreparaciones.ToList();

        // GET api/PedidosPreparaciones/5
        [HttpGet("{id}")]
        public PedidosPreparaciones Get(int id) => db.PedidosPreparaciones.Find(id);

        // POST api/PedidosPreparaciones
        [HttpPost]
        public void Post(PedidosPreparaciones sync)
        {
            db.PedidosPreparaciones.Add(sync);
            db.SaveChanges();
        }

        // PUT api/PedidosPreparaciones/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PedidosPreparaciones newObj)
        {
            var oldObj = db.PedidosPreparaciones.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/PedidosPreparaciones/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.PedidosPreparaciones.Remove(db.PedidosPreparaciones.Find(id));
            db.SaveChanges();
        }
    }
}
