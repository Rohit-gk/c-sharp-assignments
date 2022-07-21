using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
            // add hashtable 
            Hashtable hash = new Hashtable();

            hash.Add(1, "One");
            hash.Add(2, "two");

            Console.WriteLine(hash[1]);
            Console.WriteLine(hash[2]);


            // display with key and value
            Console.WriteLine("\n");
            Hashtable addhash = new Hashtable();

            addhash.Add(1, "One");
            addhash.Add(5, "Five");
            addhash.Add("Thirty", 30);
            addhash.Add(3.14f, 3.14);
            addhash.Add(99, null);

            foreach (DictionaryEntry entry in addhash)
            {
                Console.WriteLine("Key: {0} | Value: {1}", entry.Key, entry.Value);
            }


            // remove elements from the hashtable
            Console.WriteLine("\n");
            Hashtable removehash = new Hashtable();

            removehash.Add(1, "Rohit");
            removehash.Add(2, "Gulabrao");
            removehash.Add(3, "Kalebag");

            removehash.Remove(2);

            foreach (DictionaryEntry element in removehash)
            {
                Console.WriteLine("{0}  {1} ", element.Key, element.Value);
            }


            // update hashtable
            Console.WriteLine("\n");
            var cars = new Hashtable()
            {
                {"Renault", "Triber, Kwid, Duster"},
                {"Toyota", "Etios, Glanza, Ennova"},
                {"Hyundai", "i20, Creata, i10"},
                {"Tata", "Tiago, Tigor, Punch"}
            };

            string carRenault = (string)cars["Renault"];
            string carToyota = (string)cars["Toyota"];
            string carHyundai = (string)cars["Hyundai"];
            string carTata = (string)cars["Tata"];

            Console.WriteLine(carRenault);
            Console.WriteLine(carToyota);
            Console.WriteLine(carHyundai);
            Console.WriteLine(carTata);

            cars["Renault"] = "Kiger, Mercedez, Audi";
            cars["Toyota"] = "Fortuner, Endevour";

            Console.WriteLine("\n");
            Console.WriteLine("Updated Values are.....");
            Console.WriteLine("\n");

            foreach (DictionaryEntry car in cars)
            Console.WriteLine("key: {0}, Value: {1}", car.Key, car.Value);


            // contains start
            Console.WriteLine("\n");
            Hashtable containstable = new Hashtable();

            containstable.Add(1, "Rohit");
            containstable.Add(2, "Trupti");
            containstable.Add(3, "Nikita");
            containstable.Add(4, "Raj");
            containstable.Add(5, "Piyu");

            // contains
            Console.WriteLine(containstable.Contains(8));

            // containsKey
            Console.WriteLine(containstable.ContainsKey(4));

            // containsValue
            Console.WriteLine(containstable.ContainsValue("Rohit"));
        }
    }

}
   

