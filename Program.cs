using System;
using System.Collections;

namespace arrayAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 
            string[] teachers = { "Pramod", "Shubham", "Balaji", "Pankaj", "Raviraj" };
            Console.WriteLine(teachers[0]);


            // 2. 
            string[] employee = { "Rohit", "Trupti", "Raj", "Nikita", "Vedant" };
            employee[1] = "Shardul";
            Console.WriteLine(employee[1]);


            // 3. 
            string[] comapny = { "TCS", "INFOSYS", "INCUBXPERTS", "TECH-M" };
            Console.WriteLine(comapny.Length + "\n");


            // 4. 
            string[] company = { "TCS", "INFOSYS", "INCUBXPERTS", "TECH-M" };
            for (int i = 0; i < company.Length; i++)
            {
                Console.WriteLine(company[i]);
            }


            // 5. 
            string[] language = { "Angular", "C-Sharp", "Flutter", "Javascript" };
            foreach (string i in language)
            {
                Console.WriteLine(i);
            }


            // 6. 
            string[] city = { "Pune", "Mumbai", "Nagpur", "Satara", "Sangli", "Nashik", "Kolhapur", "Latur" };
            Array.Sort(city);
            foreach (string i in city)
            {
                Console.WriteLine(i);
            }


            // 7. 
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }


            // 8.
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            Array.Sort(nums);
            Array.Reverse(nums);
            Array.ForEach(nums, n => Console.WriteLine(n));
            Array.BinarySearch(nums, 5);


            // 9.
            int[] array = { 2, 4, 6, 8 };
            Array.Reverse(array);
            Console.WriteLine(String.Join(',', array));

            // 10.
            Stack amount = new Stack();
            amount.Push(10000);
            amount.Push(20000);
            amount.Push(30000);
            amount.Push(40000);
            amount.Push(50000);

            Console.WriteLine("Output is");
            foreach (int val in amount)
            {
                Console.WriteLine(val);
            }

            // 11.
            int[,] arr = new int[3, 3];  
            arr[0, 1] = 10;  
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                } 
                Console.WriteLine();  
            }

            // 12.
            int[,] test = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(test[i, j] + " ");
                }
                Console.WriteLine();  
            }


        }
    }
}
