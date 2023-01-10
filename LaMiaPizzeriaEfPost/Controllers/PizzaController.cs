﻿using LaMiaPizzeriaEfPost.Database;
using LaMiaPizzeriaEfPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizzas= db.Pizzas.ToList<Pizza>();
                return View("Index", pizzas);
            }
   
        }

        public IActionResult Dettagli(string nome)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza pizza = (from p in db.Pizzas
                               where p.nome == nome
                               select p).FirstOrDefault();

                if (pizza != null)
                {
                    return View(pizza);
                }

                return NotFound("La pizza con il nome cercato non è disponibile");
            }
            
        }

    }
}
