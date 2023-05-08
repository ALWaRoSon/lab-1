using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    //Реалізація Інтерфейсу для демонстрування приципу OSP, внаслідок якого ми зможемо розширювати сутності, але не змінювати їх
    //(Наприклад для того щоб вивести гроші в євро ми просто додамо класа Evro замість внесення змін в метод GetMoneyAltogether())
    interface IGetterMoney
    {
        void GetMoneyAltogether();
    }
    //Реалізація класу Money за принципом SRP в тому що клас виконує лише один обов'язок
    internal class Money : IGetterMoney
    {
        protected int money;
        protected int coins;

        public Money(int money_, int coins_)
        {
            money = money_;
            coins = coins_;
        }

        public int _money { get { return money; } set { money = value; } }
        public int _coins { get { return coins; } set { coins = value; } }

        public void GetMoneyAltogether()
        {
            global::System.Console.WriteLine($"Тимчасова ціна: {money}.{coins}");
        }

        
    }
}
