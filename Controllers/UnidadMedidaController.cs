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
    public class UnidadesMedidaController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/UnidadesMedida
        [HttpGet]
        public List<UnidadesMedida> Get() => db.UnidadesMedida.ToList();

        // GET api/UnidadesMedida/5
        [HttpGet("{id}")]
        public UnidadesMedida Get(int id) => db.UnidadesMedida.Find(id);

        // POST api/UnidadesMedida
        [HttpPost]
        public void Post(UnidadesMedida sync)
        {
            db.UnidadesMedida.Add(sync);
            db.SaveChanges();
        }

        // PUT api/UnidadesMedida/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UnidadesMedida newObj)
        {
            var oldObj = db.UnidadesMedida.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/UnidadesMedida/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.UnidadesMedida.Remove(db.UnidadesMedida.Find(id));
            db.SaveChanges();
        }
    }
}
