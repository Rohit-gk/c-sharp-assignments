using System;
using System.Collections.Generic;

namespace SortedList1
{
    class Program
    {
        class Hero
        {
            public int Id;
            public string HeroName;
            public string Movie;
            public int Salary;

        }
        static void Main(string[] args)
        {
            Hero hero1 = new Hero()
            {
                Id = 1,
                HeroName = "Akshay Kumar",
                Movie = "ABC",
                Salary = 5500000,
            };
            Hero hero2 = new Hero()
            {
                Id = 2,
                HeroName = "Salman Khan",
                Movie = "XYZ",
                Salary = 9800000,
            };
            Hero hero3 = new Hero()
            {
                Id = 3,
                HeroName = "Sharukh Khan",
                Movie = "LMN",
                Salary = 78780000,
            };
            Hero hero4 = new Hero()
            {
                Id = 4,
                HeroName = "Sunny deol",
                Movie = "PQR",
                Salary = 76000000,
            };

            List<Hero> herolist = new List<Hero>();
            herolist.Add(hero1);
            herolist.Add(hero2);
            herolist.Add(hero3);
            herolist.Add(hero4);

            Hero h1 = herolist[0];
            Hero h2 = herolist[1];
            Hero h3 = herolist[2];
            Hero h4 = herolist[3];

            Console.WriteLine("Id={0}, HeroName={1}, Movie={2}, Salary={3}", h1.Id, h1.HeroName, h1.Movie, h1.Salary);
            Console.WriteLine("Id={0}, HeroName={1}, Movie={2}, Salary={3}", h2.Id, h2.HeroName, h2.Movie, h2.Salary);
            Console.WriteLine("Id={0}, HeroName={1}, Movie={2}, Salary={3}", h3.Id, h3.HeroName, h3.Movie, h3.Salary);
            Console.WriteLine("Id={0}, HeroName={1}, Movie={2}, Salary={3}", h4.Id, h4.HeroName, h4.Movie, h4.Salary);

            // IndexOf 
            Console.WriteLine(herolist.IndexOf(h1));
            // Remove
            herolist.Remove(h1);
            // RemoveAt
            herolist.RemoveAt(0);


            List<Hero> newherolist = new List<Hero>();
            newherolist.Add(hero1);
            newherolist.Add(hero2);
            newherolist.AddRange(newherolist);

            // foreach loop
            foreach (Hero heroo in newherolist)
            {
                Console.WriteLine("Id={0}, HeroName={1},Movie={2}, Salary={3}", heroo.Id, heroo.HeroName,heroo.Movie, heroo.Salary);
            }

            Console.WriteLine("\n");

           

            // Dictionary Example 

            Dictionary<int, string> laptopList = new Dictionary<int, string>();
            laptopList.Add(1, "Dell");
            laptopList.Add(2, "Hp");
            laptopList.Add(3, "Lenovo");
            laptopList.Add(4, "Thinkpad");
            laptopList.Add(5, "Notebook");

            Console.WriteLine(laptopList[5]);

            foreach (KeyValuePair<int, string> lap in laptopList)
            {
                Console.WriteLine("key={0}, Value={1}", lap.Key, lap.Value);
            }

            // Remove
            laptopList.Remove(2);
            foreach (KeyValuePair<int, string> lap in laptopList)
            {
                Console.WriteLine("key={0}, Value={1}", lap.Key, lap.Value);
            }
            Console.WriteLine("\n");

            // Update key
            laptopList[4] = "Laptop";
            foreach (KeyValuePair<int, string> lap in laptopList)
            {
                Console.WriteLine("key={0}, Value={1}", lap.Key, lap.Value);
            }

            // ContainsKey
            Console.WriteLine(laptopList.ContainsKey(4));

            // TryGetValue
            string tryGet;
            if (laptopList.TryGetValue(3, out tryGet))
            {
                Console.WriteLine(tryGet);
            }

            Console.WriteLine("\n");




            // Stack Example
            
            Stack<string> games = new Stack<string>();
            
            games.Push("Cricket");
            games.Push("Vollyball");
            games.Push("Baseball");
            games.Push("Caram");
            games.Push("Tennis");
            games.Push("Basketball");

            foreach (string gamesname in games)
            {
                Console.WriteLine(gamesname);
            }

            // Contains
            Console.WriteLine(games.Contains("Vollyball"));
            // Count
            Console.WriteLine(games.Count);
            // Pop
            Console.WriteLine(games.Pop());
            // Peek
            Console.WriteLine(games.Peek());


            Console.WriteLine("\n");




            // Queue Example 
        
            Queue<string> rivers = new Queue<string>();

            rivers.Enqueue("Krushna");
            rivers.Enqueue("Koyna");
            rivers.Enqueue("Ganga");
            rivers.Enqueue("Kaveri");
            rivers.Enqueue("Nil");
            foreach (string rivname in rivers)
            {
                Console.WriteLine(rivname);
            }

            // Count
            Console.WriteLine(rivers.Count);

            // Dequeue
            Console.WriteLine(rivers.Dequeue());

            // Peek
            Console.WriteLine(rivers.Peek());

            // Contains
            Console.WriteLine(rivers.Contains("Nil"));
           
            // Clear
            rivers.Clear();

            // After clear count
            Console.WriteLine(rivers.Count);

            Console.WriteLine("\n");





            // SORTED LIST EXAMPLE 

            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "Alia Bhatt");
            names.Add("2", "Shraddha Kapur");
            names.Add("3", "Jacklin Fernandis");
            names.Add("4", "Karina Kapur");
            names.Add("5", "Suuny Leone");
            names.Add("6", "Sonam Kapur");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // remove
            names.Remove("1");
            // removeAt
            names.RemoveAt(3);
           
            Console.WriteLine("  Count:    {0}", names.Count);
            Console.WriteLine("  Capacity: {0}", names.Capacity);
            Console.WriteLine("\n");


            // String Example

            SortedSet<string> country = new SortedSet<string>();
            country.Add("India");
            country.Add("USA");
            country.Add("England");
            country.Add("Australia");
            country.Add("New Zealand");
            foreach (string str in country)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\n");


            SortedList<int, string> companyList = new SortedList<int, string>();
            companyList.Add(1, "IncubXperts");
            companyList.Add(2, "Infosys");
            companyList.Add(3, "TCS");
            companyList.Add(4, "Vodafone");
            companyList.Add(5, "Capgemini");
            companyList.Add(6, "Cognizant");

            // for loop
            for (int i = 0; i < companyList.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", companyList.Keys[i], companyList.Values[i]);
            }

            Console.WriteLine("\n");
            // foreach loop
            foreach (KeyValuePair<int, string> pair in companyList)
            {
                Console.WriteLine("Key: {0} \t Value: {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("\n");

            Console.WriteLine(companyList[1]);
            Console.WriteLine(companyList[6]);

            // remove
            companyList.Remove(2);
            // removeAt
            companyList.RemoveAt(3);


        }
    }
}


