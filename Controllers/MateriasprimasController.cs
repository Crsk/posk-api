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
    public class MateriasprimasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Materiasprimas
        [HttpGet]
        public List<Materiasprimas> Get() => db.Materiasprimas.ToList();

        // GET api/Materiasprimas/5
        [HttpGet("{id}")]
        public Materiasprimas Get(int id) => db.Materiasprimas.Find(id);

        // POST api/Materiasprimas
        [HttpPost]
        public void Post(Materiasprimas sync)
        {
            db.Materiasprimas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Materiasprimas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Materiasprimas newObj)
        {
            var oldObj = db.Materiasprimas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Materiasprimas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Materiasprimas.Remove(db.Materiasprimas.Find(id));
            db.SaveChanges();
        }
    }
}
