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
    public class PrestamoEnvasesController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/PrestamoEnvases
        [HttpGet]
        public List<PrestamoEnvases> Get() => db.PrestamoEnvases.ToList();

        // GET api/PrestamoEnvases/5
        [HttpGet("{id}")]
        public PrestamoEnvases Get(int id) => db.PrestamoEnvases.Find(id);

        // POST api/PrestamoEnvases
        [HttpPost]
        public void Post(PrestamoEnvases sync)
        {
            db.PrestamoEnvases.Add(sync);
            db.SaveChanges();
        }

        // PUT api/PrestamoEnvases/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PrestamoEnvases newObj)
        {
            var oldObj = db.PrestamoEnvases.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/PrestamoEnvases/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.PrestamoEnvases.Remove(db.PrestamoEnvases.Find(id));
            db.SaveChanges();
        }
    }
}
