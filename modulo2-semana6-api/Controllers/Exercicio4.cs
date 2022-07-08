using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;
[ApiController]
[Route("[controller]")]
public class Exercicio4 : ControllerBase {

    [HttpGet("{email}")]
    public string Get(string email){
        if(Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return "E-mail válido";
        return "E-mail inválido";
    }
}