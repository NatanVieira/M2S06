using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;
[ApiController]
[Route("[controller]")]
public class Exercicio4 : ControllerBase {

    [HttpGet("{email}")]
    public string Get(string email){
        var minuto = DateTime.Now.Minute;
        if(minuto <= 30){
            validaEmail(email);
            return "E-mail válido";
        }
        else
            throw new Exception("Erro na requisição o minuto está acima de 30");
    }
    
    private static void validaEmail(string email){
        if(!Regex.IsMatch(email,@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$"))
            throw new Exception("E-mail inválido");
    }
}