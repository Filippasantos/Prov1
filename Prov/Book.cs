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
            
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Name: " + name + ", Rarity: " + rarity + ", Category:" + category + ", Price:" + price + ".");
        }

        public int Evaluate()
        {

        }

        public string GetCategory()
        {

        }

        public string GetName()
        {

        }

        public bool IsCursed()
        {

        }

    }
}
