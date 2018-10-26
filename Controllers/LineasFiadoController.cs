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
    public class LineasFiadoController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/LineasFiado
        [HttpGet]
        public List<LineasFiado> Get() => db.LineasFiado.ToList();

        // GET api/LineasFiado/5
        [HttpGet("{id}")]
        public LineasFiado Get(int id) => db.LineasFiado.Find(id);

        // POST api/LineasFiado
        [HttpPost]
        public void Post(LineasFiado sync)
        {
            db.LineasFiado.Add(sync);
            db.SaveChanges();
        }

        // PUT api/LineasFiado/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LineasFiado newObj)
        {
            var oldObj = db.LineasFiado.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/LineasFiado/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.LineasFiado.Remove(db.LineasFiado.Find(id));
            db.SaveChanges();
        }
    }
}
