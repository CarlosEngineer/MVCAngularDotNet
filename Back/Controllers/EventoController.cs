using Microsoft.AspNetCore.Mvc;
using ProEventos.Models;

namespace ProEventos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento =  new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular",
                Local = "São Paulo",
                Lote = "1ª lote ",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "Foto.png"    
            },
             new Evento()
            {
                EventoId = 2,
                Tema = "DotNet",
                Local = "Minas Gerais",
                Lote = "2ª lote ",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemUrl = "Foto.png"    
            }
           
            
        };

    public EventoController()
    {
        
    }   

    [HttpGet]
    public  IEnumerable<Evento> Get()
    {
        return _evento;
                            
    }

    [HttpGet ("{id}")]
    public  IEnumerable<Evento> GetById(int id )
    {
        return _evento.Where(x => x.EventoId == id);
                        
    }
   

    [HttpPost]
    public string Post()
    {
        return "Hello world";
                            
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de id {id}";
                          
    }

    
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de id {id}";
                            
    }
}
