using LaMiaPizzeriaEfPost.Models;

namespace LaMiaPizzeriaEfPost.Utils
{
    public static class PizzaData
    {
        private static List<Pizza> pizzas;

        public static List<Pizza> GetPizzas()
        {
            if (pizzas != null)
            {
                return pizzas;
            }

            pizzas = new List<Pizza>()
            {
                new Pizza ("Margherita", "/img/Margherita.png", "(Pomodoro, Mozzarella)", 4.50),
                new Pizza ("Ortolana", "/img/Ortolana.png", "(Pomodoro, Mozzarella, Verdure Grigliate)", 6.50),
                new Pizza ("Prosciutto", "/img/Prosciutto.png", "(Pomodoro, Mozzarella, Prosciutto Cotto)", 5)
            };

            return pizzas; 

        }
        
    }
}
