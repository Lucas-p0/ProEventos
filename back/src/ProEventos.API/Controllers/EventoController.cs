using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using ProEventos.API.Controllers;




namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }

        [HttpGet]
        public Evento Get()
        {
            return new Evento()
            {
                EventoId = 1,
                Tema = "Angular"
            };
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete = {id}";
        }


    }
}
