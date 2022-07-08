using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]

public class Exercicio8 : ControllerBase {

    [HttpGet("{valor1}/{valor2}")]
    public string Get(int valor1, int valor2){
        int resultado = 10;
        try{
            resultado = valor1 + valor2;
            if(resultado >= 10)
                throw new Exception("Maior ou igual a 10");
        }
        catch(Exception ex){

        }
        finally {
            resultado = resultado < 10 ? resultado : new Random().Next();
        }
        return resultado.ToString();
    }
}