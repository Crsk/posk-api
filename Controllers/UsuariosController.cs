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
    public class UsuariosController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Usuarios
        [HttpGet]
        public List<Usuarios> Get() => db.Usuarios.ToList();

        // GET api/Usuarios/5
        [HttpGet("{id}")]
        public Usuarios Get(int id) => db.Usuarios.Find(id);

        // POST api/Usuarios
        [HttpPost]
        public void Post(Usuarios sync)
        {
            db.Usuarios.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Usuarios/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Usuarios newObj)
        {
            var oldObj = db.Usuarios.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Usuarios/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Usuarios.Remove(db.Usuarios.Find(id));
            db.SaveChanges();
        }
    }
}
