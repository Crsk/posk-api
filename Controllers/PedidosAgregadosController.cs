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
    public class PedidosAgregadosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/PedidosAgregados
        [HttpGet]
        public List<PedidosAgregados> Get() => db.PedidosAgregados.ToList();

        // GET api/PedidosAgregados/5
        [HttpGet("{id}")]
        public PedidosAgregados Get(int id) => db.PedidosAgregados.Find(id);

        // POST api/PedidosAgregados
        [HttpPost]
        public void Post(PedidosAgregados sync)
        {
            db.PedidosAgregados.Add(sync);
            db.SaveChanges();
        }

        // PUT api/PedidosAgregados/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PedidosAgregados newObj)
        {
            var oldObj = db.PedidosAgregados.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/PedidosAgregados/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.PedidosAgregados.Remove(db.PedidosAgregados.Find(id));
            db.SaveChanges();
        }
    }
}
