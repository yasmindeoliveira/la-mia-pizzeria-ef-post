using LaMiaPizzeriaEfPost.Models;
using LaMiaPizzeriaEfPost.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza>pizzas= PizzaData.GetPizzas();

            return View("Index", pizzas);
        }

        public IActionResult Dettagli(string nome)
        {
            List<Pizza> pizzas = PizzaData.GetPizzas();

            foreach (Pizza pizza in pizzas)
            {
                if (pizza.nome == nome)
                {
                    return View(pizza);
                }
            }

            return NotFound("La pizza con il nome cercato non è disponibile");
        }

    }
}
