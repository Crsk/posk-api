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
    public class ClientesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Clientes
        [HttpGet]
        public List<Clientes> Get() => db.Clientes.ToList();

        // GET api/Clientes/5
        [HttpGet("{id}")]
        public Clientes Get(int id) => db.Clientes.Find(id);

        // POST api/Clientes
        [HttpPost]
        public void Post(Clientes sync)
        {
            db.Clientes.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Clientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clientes newObj)
        {
            var oldObj = db.Clientes.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Clientes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Clientes.Remove(db.Clientes.Find(id));
            db.SaveChanges();
        }
    }
}
