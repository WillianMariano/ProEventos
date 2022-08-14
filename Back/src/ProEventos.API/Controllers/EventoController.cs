using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento =  new Evento[]{
                new Evento(){
                    EventoId=1,
                    Tema="Angular e .Net Core",
                    Local="Belo Horizonte",
                    Lote="1º lote",
                    QtdPessoas=250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
            },     new Evento(){
                    EventoId=2,
                    Tema="Angular e .Net Core",
                    Local="São Paulo",
                    Lote="2º lote",
                    QtdPessoas=250,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemURL = "foto.png"
            }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x=>x.EventoId==id);
        }

        
        [HttpPost]
        public string Post()
        {
            return "Teste 2";
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Teste"+id;
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Teste"+id;
        }
    }
}
