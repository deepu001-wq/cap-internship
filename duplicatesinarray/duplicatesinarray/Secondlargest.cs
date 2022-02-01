using System;
using System.Collections.Generic;
using System.Text;

namespace duplicatesinarray
{
    class Secondlargest

    {
		static void Main(string[] args)
		{
			int num;
			int[] arr = new int[100];
			Console.WriteLine("Enter size of the array: ");
			num = Convert.ToInt32(Console.ReadLine());

			//Reads elements in array
			Console.WriteLine("Enter elements in the array: ");
			for (int i = 0; i < num; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			
			int largest = int.MinValue;
			int second = int.MinValue;
			foreach (int i in arr)
			{
				if (i > largest)
				{
					second = largest;
					largest = i;
				}
				else if (i > second)
					second = i;
			}

			System.Console.WriteLine("the second largest element is:"+second);

		}
    } 
}
