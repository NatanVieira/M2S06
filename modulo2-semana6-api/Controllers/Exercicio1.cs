using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]

public class Exercicio1 : ControllerBase {
    
    [HttpGet("{tipo}")]
    public string Get(string tipo){
        if(tipo == "true")
            return "true";
        if(tipo == "false")
            return "false";
        return "Não é o tipo desejado";
    }
}