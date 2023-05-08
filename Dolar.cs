using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    //Реалізація класу Dolar за принципом SRP в тому що клас виконує лише один обов'язок, та результат OCP а саме розширення сутності
    internal class Dolar:Money
    {
        public Dolar(int money, int coins) : base(money, coins)
        {

        }
        public void GetMoneyAltogether()
        {
            Console.WriteLine($"Тимчасова ціна: {money}.{coins} доларів");
        }
    }
}
