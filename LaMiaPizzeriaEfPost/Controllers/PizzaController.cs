using LaMiaPizzeriaEfPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = new List<Pizza>();

            return View("Index", pizzas);
        }

        public IActionResult Dettagli(string nome)
        {
            List<Pizza> pizzas = new List<Pizza>();

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
