using System;

namespace Prov
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;

        public Book()
        {
            actualValue = generator.Next(0, 100);
            rarity = generator.Next(0, 10);
            int cursedChance = generator.Next(0,100);
            if (cursedChance > 25) //det är 25% chans att boken är cursed
            {
                cursed = false;
            }
            else
            {
                cursed = true;
            }
            //här ska ja slumpa kategori och namn ur listor

        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Out of time so weird string hello!");
            // System.Console.WriteLine("Name: " + name + ", Rarity: " + rarity + ", Category:" + category + ", Price:" + price + ".");
        }

        public int Evaluate()
        {
            int priceBefore = actualValue * rarity;
            int guessChance = generator.Next(1, 3); //int kan inte ha decimaler så får göra det lite krångligare
            price = priceBefore * guessChance;
            price = price / 2;
            return price;
        }

        public string GetCategory()
        {
            string outOfTime = "";
            return outOfTime;
        }

        public string GetName()
        {
            string hello = "";
            return hello;
        }

        public bool IsCursed()
        {
            return true;
        }

    }
}
