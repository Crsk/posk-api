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
    public class CantidadesvendidasJornadaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/CantidadesvendidasJornada
        [HttpGet]
        public List<CantidadesvendidasJornada> Get() => db.CantidadesvendidasJornada.ToList();

        // GET api/CantidadesvendidasJornada/5
        [HttpGet("{id}")]
        public CantidadesvendidasJornada Get(int id) => db.CantidadesvendidasJornada.Find(id);

        // POST api/CantidadesvendidasJornada
        [HttpPost]
        public void Post(CantidadesvendidasJornada sync)
        {
            db.CantidadesvendidasJornada.Add(sync);
            db.SaveChanges();
        }

        // PUT api/CantidadesvendidasJornada/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CantidadesvendidasJornada newObj)
        {
            var oldObj = db.CantidadesvendidasJornada.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/CantidadesvendidasJornada/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.CantidadesvendidasJornada.Remove(db.CantidadesvendidasJornada.Find(id));
            db.SaveChanges();
        }
    }
}
