using System;

namespace ArrayOptionalAssignment
{
    class Program
    {
        public class ArrayDisplay
        {
            public Array Demo()
            {
                string[] test = { "Rohit","Raj","Piyu","Nikita","Nitin","Ajinkya","Vedant","Shardul" };
                
                return test;
            }

        }
        public class ArrayFunction
        {
            public void arraySort(Array a1)
            {
                Array.Sort(a1);
                // Sort array  

                Console.WriteLine("\n Sorted array list: \n");

                foreach (var item in a1)
                {
                    Console.WriteLine(item);
                }

            }

            public void arrayReverse(Array a2)
            {
                Array.Reverse(a2);

                // Reverse array  
                Console.WriteLine("\n Reverse Array: ");

                foreach (var data in a2)
                {
                    Console.WriteLine(data);
                }

            }

            public void arrayEqual(Array a3)
            {
                Array a1 = a3;
                Console.WriteLine("\n" + a1.Equals(a3));
            }
        }
        static void Main(string[] args)
        {
            ArrayDisplay demoArray = new ArrayDisplay();
            Array demo = demoArray.Demo();

            ArrayFunction arrayDM = new ArrayFunction();
            arrayDM.arraySort(demo);
            arrayDM.arrayReverse(demo);
            arrayDM.arrayEqual(demo); 
        }
    }

    
}
