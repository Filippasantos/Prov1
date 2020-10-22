using System.Collections.Generic;
using System;

namespace Prov
{
    public class Customer
    {
        private int ownValue; //kundens gissning av bokens värde så att kunden kan bestämma om hen vill köpa eller inte
        private string favoriteCategory; //favoritkategorin. Kan tänka mig att man har större chans att köpa boken om den är overpriced eller nåt ifall det är favoritkategorin
        private Random generator; //slumpgenerator för när kunden gissar priset

        public Customer() //man får reda på vad kunden gillar och ska kunna presentera en bok för kunden typ
        {
            System.Console.WriteLine("Hello, I really enjoy " + favoriteCategory + ", do you have any of those?");
        }

        public int OwnEvaluation() //kunden får gissa sig till ett pris
        {
            return 
        }
        
        public bool Buy()//här bestäms det om kunden vill köpa boken eller inte
        {

        }



    }
}
