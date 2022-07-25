using System;

namespace ArrayOptionalAssignment
{
    class Program
    {
        public class ArrayDisplay
        {
            public Array Demo()
            {
                int a;
                int b;

                Console.WriteLine("\n Enter Array Size which You Want: ");
                b = Convert.ToInt32(Console.ReadLine());

                string[] test = new string[b];
                for (a = 0; a < b; a++)
                {
                    Console.Write("\n Enter String Here: ");
                    test[a] = Console.ReadLine();
                }

                Console.WriteLine("\n");


                for (a = 0; a < b; a++)
                {
                    Console.WriteLine("New Array String: {0}", test[a]);
                }
                return test;
            }

        }
        public class ArrayMethod
        {
            public void sortArray(Array arr1)
            {
                Array.Sort(arr1);
                // Sort array  

                Console.WriteLine("\n Sorted array list: \n");

                foreach (var item in arr1)
                {
                    Console.WriteLine(item);
                }

            }

            public void reverseArr(Array arr2)
            {
                Array.Reverse(arr2);

                // Reverse array  
                Console.WriteLine("\n Reverse Array: \n");

                foreach (var item in arr2)
                {
                    Console.WriteLine(item);
                }

            }

            public void equalArr(Array arr3)
            {
                Array a1 = arr3;
                Console.WriteLine("\n" + a1.Equals(arr3));
            }
        }
        static void Main(string[] args)
        {
            ArrayDisplay demoArray = new ArrayDisplay();
            Array demo = demoArray.Demo();

            ArrayMethod arrayDM = new ArrayMethod();
            arrayDM.sortArray(demo);
            arrayDM.reverseArr(demo);
            arrayDM.equalArr(demo); 
        }
    }

    
}
