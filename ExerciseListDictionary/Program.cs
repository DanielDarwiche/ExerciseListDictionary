using System;
using System.Collections.Generic;

namespace ExerciseListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Sweden = new Country("Sweden", 46, "Stockholm");
            Country Norway = new Country("Norway", 47, "Oslo");
            Country Denmark = new Country("Denmark", 45, "Copenhagen");
            Country Finland = new Country("Finland", 49, "Helsinki");
            Country Germany = new Country("Germany", 50, "Berlin");


            List<Country> CountryList = new List<Country>();
            CountryList.Add(Sweden);
            CountryList.Add(Norway);
            CountryList.Add(Denmark);
            CountryList.Add(Finland);
            CountryList.Add(Germany);

            //List
            //bool yttreloop = true;
            //do
            //{
            //    Console.WriteLine("Enter a countrycode:");
            //    int inputCode = int.Parse(Console.ReadLine());
            //    bool found=false;
            //    Country Found = new Country();
            //    foreach(Country c in CountryList)
            //    {
            //        if (c.Code == inputCode)
            //        {
            //            Found = c;
            //            found = true;
            //        }
            //    }
            //    if (found)
            //    {
            //        Console.WriteLine("Country code valid - Country:" + Found.Name );
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country code not valid");
            //    }
            //    bool inre = true;
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue ?");
            //        string yesNo = Console.ReadLine().ToLower();
            //        if (yesNo == "yes")
            //        {
            //            inre = false;
            //        }
            //        else if (yesNo == "no")
            //        {
            //            inre = false;
            //            yttreloop = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong input. Enter 'Yes' or 'No'");
            //        }

            //    } while (inre);
             
            //} while (yttreloop);
            Dictionary<int, Country> CountryD = new Dictionary<int, Country>();
            CountryD.Add(Sweden.Code, Sweden);
            CountryD.Add(Norway.Code, Norway);
            CountryD.Add(Denmark.Code, Denmark);
            CountryD.Add(Finland.Code, Finland);
            CountryD.Add(Germany.Code, Germany);

            //Dictionary 
            bool yttreloop = true;
            do
            {
                Console.WriteLine("Enter a countrycode:");
                int inputCode = int.Parse(Console.ReadLine());
                bool found = false;
                Country Found = new Country();
                foreach (KeyValuePair<int, Country> c in CountryD)
                {
                    if (c.Key == inputCode)
                    {
                        Found = c.Value;
                        found = true;
                    }
                }
                if (found)
                {
                    Console.WriteLine("Country code valid - Country:" + Found.Name);
                }
                else
                {
                    Console.WriteLine("Country code not valid");
                }
                bool inre = true;
                do
                {
                    Console.WriteLine("Do you want to continue ?");
                    string yesNo = Console.ReadLine().ToLower();
                    if (yesNo == "yes")
                    {
                        inre = false;
                    }
                    else if (yesNo == "no")
                    {
                        inre = false;
                        yttreloop = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input. Enter 'Yes' or 'No'");
                    }
                } while (inre);
            } while (yttreloop);
        }
    }
    public class Country
    {
        public string Name;
        public int Code;
        public string Capital;

        public Country(string name, int code, string capital)
        {
            Name = name;
            Code = code;
            Capital = capital;
        }
        public Country() { }
    }
}
