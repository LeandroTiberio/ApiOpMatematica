using Microsoft.AspNetCore.Mvc;
namespace APIOperacoesMatematicas.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PrimeiraController : ControllerBase 
    {

        [HttpGet("Soma")]
        public IActionResult SomaAPI(int Num1, int Num2)
        {
            if (Num1 == 0 || Num1 > 999 || Num2 == 0 || Num2 > 999)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = Num1 + Num2;
            return Ok($"Resultado da Soma é: {resultado}");
        }

        [HttpGet("Subtração")]
        public IActionResult SubtracaoAPI(int Num1, int Num2)
        {
            if (Num1 == 0 || Num1 > 999 || Num2 == 0 || Num2 > 999)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = Num1 - Num2;
            return Ok($"Resultado da Subtração é: {resultado}");
        }

        [HttpGet("Divisão")]
        public IActionResult DivisaoAPI(int Num1, int Num2)
        {
            if (Num1 == 0 || Num1 > 999 || Num2 == 0 || Num2 > 999)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = Num1 / Num2;
            return Ok($"Resultado da Divisão é: {resultado}");
        }

        [HttpGet("Multiplicação")]
        public IActionResult MultiplicacaoAPI(int Num1, int Num2)
        {
            if (Num1 == 0 || Num1 > 999 || Num2 == 0 || Num2 > 999)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = Num1 * Num2;
            return Ok($"Resultado da Multiplicação é: {resultado}");
        }
    }

}     