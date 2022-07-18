using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("This is for loop" + " " + i);
            }


            // foreach loop

            string[] studentList = { "Rohit", "Trupti", "Raj", "Piyu", "Nikita", "Ajinkya" };
            foreach (string stud in studentList)
            {
                Console.WriteLine(stud);
            }


            // while loop

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("This is while loop" + " " + j);
                j++;
            }

            // if condition

            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            // if condition

            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            // if else condition

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }


            // else if condition

            int age = 22;
            if (age < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (age < 23)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }


            // short if condition

            int day = 20;
            string result = (day < 21) ? "Good day" : "Good evening";
            Console.WriteLine(result);


            // if else condition

            int number1 = 50;
            int number2 = 50;
            if
             (number1 == number2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            // switch statement

            string days = "Tues";
            switch (days)
            {

                case "Mon":
                    Console.WriteLine("Monday");
                    break;

                case "Tues":
                    Console.WriteLine("Tuesday");
                    break;
            }


            // switch statement 2nd example

            int weekDays = 10;
            switch (weekDays)
            {
                case 1:
                    Console.WriteLine("Today is Saturday");
                    break;

                case 2:
                    Console.WriteLine("Today is Sunday");
                    break;

                default:
                    Console.WriteLine("Weekend");
                    break;
            }


            // while loop

            int z = 1;
            while (z <= 10)
            {
                Console.WriteLine(z);
                z++;
            }


            // do while loop

            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 6);


            // stop for loop 

            for (int b = 0; b < 10; b++)
            {
                if (b == 3)
                {
                    break;
                }
                Console.WriteLine(b);
            }


            // return statement

            Console.WriteLine("Hello Rohit");
            Display(6);

            Console.WriteLine("Hello Everyone");
            Display(5);

            void Display(int number)
            {
                if (number == 6)
                {
                    return;
                }
                Console.WriteLine(number);
            }


        }
    }
}

