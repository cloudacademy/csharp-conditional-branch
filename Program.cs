using System;
using System.Collections.Generic;

namespace ConditionBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch

            //Console.WriteLine(Rating.ToString(0)); 

            #endregion

            # region Moth light
             int porchLumens = 800;
            int moonLumens = 200;
            int neighborsPorch = 900;
            string flightPath = "undefined";

            if (porchLumens >= moonLumens || porchLumens >= neighborsPorch)
            {
                flightPath = "Head to porch";
                porchLumens = 0;
            }
            else if (neighborsPorch >= moonLumens)
            {
                flightPath = "Visit neighbors";
                neighborsPorch = 0;
            }
            else 
                flightPath = "Fly to moon"; 

            Console.WriteLine(flightPath);  
            #endregion
        
            #region Pasta
            /*decimal freshPriceHigh = 10;
            decimal dryPriceHigh = 3;

            string[] pastaPreference = { "Lasagne", "Cannelloni", "Fettuccine", "Tagliatelle", "Ravioli", "Tortellini" };
            string[] brandPreference = { "Rana", "Barilla", "Delmaine", "San Remo", "House brand" };

            List<Pasta> pastas = new List<Pasta>();
            pastas.Add(new Lasagne(false, "San Remo", 2.79M));
            pastas.Add(new Lasagne(true, "Barilla", 10.59M));
            pastas.Add(new Fettuccine(false, "San Remo", 2.99M));
            pastas.Add(new Cannelloni(true, "Delmaine", 9.79M));
            pastas.Add(new Ravioli(true, "Rana", 8.75M));
            pastas.Add(new Tagliatelle(true, "Barilla", 8.99M));
            pastas.Add(new Tortellini(false, "San Remo", 3.00M));
            pastas.Add(new Tortellini(false, "Diamond", 2.70M));
            pastas.Add(new Tortellini(true, "Rana", 9.99M));
            pastas.Add(new Cannelloni(true, "Rana", 8.99M));
            pastas.Add(new Fettuccine(true, "Delmaine", 6.99M));            

            List<Pasta> pastaChoice = new List<Pasta>();
            foreach(Pasta pasta in pastas)
            {
                string pastaName = pasta.GetType().ToString();
                pasta.BrandRank = 0;
                pasta.TypeRank = 0;


                if ((pasta.Fresh && pasta.Price <= freshPriceHigh) || (!pasta.Fresh && pasta.Price <= dryPriceHigh))


                {
                    // rank the pasta variety
                    for (int i = 0; i < pastaPreference.Length; i++) 
                    {
                        if (pastaName == pastaPreference[i])
                        {
                            pasta.TypeRank = ++i;
                            break;
                        }
                    }
                    // rank the pasta brand
                    for (int i = 0; i < brandPreference.Length; i++)
                    {
                        if (pasta.Brand == brandPreference[i])
                        {
                            pasta.BrandRank = ++i;
                            break;
                        }
                    }  

                    if (pasta.TypeRank > 0 && pasta.BrandRank > 0)                 
                    {
                        int i = 0;
                        while (i < pastaChoice.Count)
                        {
                            if ((pasta.Rating < pastaChoice[i].Rating) || (pasta.Rating == pastaChoice[i].Rating && pasta.Price < pastaChoice[i].Price))
                            {
                                pastaChoice.Insert(i, pasta);
                                break;
                            }
                            i++;
                        }
                        if (i == pastaChoice.Count)
                            pastaChoice.Add(pasta);
                    }
                }
            }
            foreach(Pasta pasta in pastaChoice)
            {
                Console.WriteLine(pasta.ToString());
            }*/

            #endregion
        }
    }
}
