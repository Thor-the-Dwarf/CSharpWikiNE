

namespace _110_base;

    public class Base
    {
        public static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            Pizza pizza1 = new Pizza("Salami");
            Pizza pizza2 = new Pizza(35);
            Pizza pizza3 = new Pizza("Speziale", 20);
            
            DoppeldeckerPizza doppeldeckerPizza = new DoppeldeckerPizza();
            DoppeldeckerPizza doppeldeckerPizza1 = new DoppeldeckerPizza("Salami");
            DoppeldeckerPizza doppeldeckerPizza2 = new DoppeldeckerPizza(35);
            DoppeldeckerPizza doppeldeckerPizza3 = new DoppeldeckerPizza("Speziale", 20);
        }
    }

