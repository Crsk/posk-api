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
    public class BoletasController : ControllerBase
    {
        // GET api/boletas
        [HttpGet]
        public List<Boletas> Get()
        {
            var db = new PoskContext();
            return db.Boletas.ToList();
        }

        // GET api/boletas/5
        [HttpGet("{id}")]
        public Boletas Get(int id)
        {
            var db = new PoskContext();
            return db.Boletas.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/boletas
        [HttpPost]
        public void Post(Boletas boleta)
        {
            var db = new PoskContext();
            db.Boletas.Add(boleta);
            db.SaveChanges();
        }

        // PUT api/boletas/5
        [HttpPut("{id}")]
        public void Put(int id, Boletas boletaNew)
        {
            var db = new PoskContext();
            var boletaOld = db.Boletas.Where(x => x.Id == id).FirstOrDefault();
            boletaOld.NumeroBoleta = boletaNew.NumeroBoleta;
            boletaOld.Fecha = boletaNew.Fecha;
            boletaOld.PuntosCantidad = boletaNew.PuntosCantidad;
            boletaOld.Total = boletaNew.Total;
            boletaOld.ClienteId = boletaNew.ClienteId;
            boletaOld.UsuarioId = boletaNew.UsuarioId;
            boletaNew.Propina = boletaNew.Propina;
            db.SaveChanges();
        }

        // DELETE api/boletas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var db = new PoskContext();
            var boleta = db.Boletas.Where(x => x.Id == id).FirstOrDefault();
            db.Boletas.Remove(boleta);
            db.SaveChanges();
        }
    }
}
