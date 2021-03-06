﻿using System;
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
    public class BoletasController : ControllerBase
    {
        private PoskContext db { get; set; } = new PoskContext();

        // GET api/Boletas
        [HttpGet]
        public List<Boletas> Get() => db.Boletas.ToList();

        // GET api/Boletas/5
        [HttpGet("{id}")]
        public Boletas Get(int id) => db.Boletas.Find(id);

        // POST api/Boletas
        [HttpPost]
        public void Post(Boletas sync)
        {
            db.Boletas.Add(sync);
            db.SaveChanges();
        }

        // PUT api/Boletas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Boletas newObj)
        {
            var oldObj = db.Boletas.Find(id);
            if (oldObj == null) return;
            newObj.Id = oldObj.Id;
            db.Entry(oldObj).CurrentValues.SetValues(newObj);
            db.SaveChanges();
        }

        // DELETE api/Boletas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Boletas.Remove(db.Boletas.Find(id));
            db.SaveChanges();
        }
    }
}
