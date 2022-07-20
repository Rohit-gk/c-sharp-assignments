using System;
using System.Collections;

namespace arrayList
{
	public class Program
	{
		public static void Main()
		{
			// 1. 

			var dummyList = new ArrayList();
			dummyList.Add(1);
			dummyList.Add("Rohit");
			dummyList.Add(true);
			dummyList.Add(80);

			var list = new ArrayList()
			{ 2, "Raj", false, 90 };

			Console.WriteLine("ArrayList First");

			for (int i = 0; i < dummyList.Count; i++)
				Console.WriteLine(dummyList[i]);

			Console.WriteLine("ArrayList Second");

			for (int i = 0; i < list.Count; i++)
				Console.WriteLine(list[i]);


			// 2.

			var studentListone = new ArrayList();

			var studentListtwo = new ArrayList()
			{ 1, "Rohit", "Sharma", 7.5 };

			string[] arr = { "Pravin", "Amol", "Dipak", "Dada" };

			studentListone.AddRange(studentListtwo);
			studentListone.AddRange(arr);

			Console.WriteLine("Output will be...");

			for (int i = 0; i < studentListone.Count; i++)
				Console.WriteLine(studentListone[i]);


			// 3.
			ArrayList testList = new ArrayList()
			{ 1, "TEST", 2300, 70.5};

			foreach (var item in testList)
				Console.Write(item + ", ");

			for (int i = 0; i < testList.Count; i++)
				Console.Write(testList[i] + ", ");


			// 4.
			ArrayList empList = new ArrayList()
				{ 1,"Trupti",500,"pune",9.7 };

			empList.Insert(1, "Second Item");

			foreach (var val in empList)
				Console.WriteLine(val);


			// 5.
			ArrayList add1 = new ArrayList()
				{
					100, 200, 600, 700 ,900
				};

			ArrayList add2 = new ArrayList()
				{
					300, 400, 500, 800
				};
			add1.InsertRange(2, add2);

			foreach (var item in add1)
				Console.Write(item + ", ");


			// 6.
			ArrayList flatList = new ArrayList()
				{ 1, "Flat-no-1", 243000, 4, 700 };

			flatList.RemoveAt(4);
			flatList.RemoveRange(0, 2);

		}
	}
}
