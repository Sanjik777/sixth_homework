using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
/*
 1.	В С # индексация начинается с нуля, но в некоторых языках программирования это не так. 
 Например, в Turbo Pascal индексация массиве начинается с 1.
 Напишите класс RangeOfArray, который позволяет работать с массивом такого типа,
 в котором индексный диапазон устанавливается пользователем.
 Например, в диапазоне от 6 до 10, или от –9 до 15.
Подсказка: В классе можно объявить две переменных, 
которые будут содержать верхний и нижний индекс допустимого диапазона.
 */
namespace Practical_work
{
	public class RangeOfArray
	{
		const int DEFAULT_NUMBER_FOR_RANGE = 1;
		const int DEFAULT_MULTIPLY = 10;

		public int UpperBound { set; get; }
		public int LowerBound { set; get; }
		public int[] ourRange;
		public int[] ourArray;

		public int this[int index]
		{
			get
			{
				// например index = -9 (от -10...до 8)
				// range[i] == index  ==> где реальный индекс i = 1
				// -9(ourRange) == -9(index)
				if (Array.Find(ourRange, i => i == index) == index)
				{
					//то вернем ourArray[i], где i = 1 при index = -9
					return ourArray[Array.IndexOf(ourRange, index)];
				}
				else { WriteLine("\nИндекс не входит в диапазон!\n"); return 0; }
			}
			set
			{
				if (Array.Find(ourRange, i => i == index) == index)
				{
					ourArray[Array.IndexOf(ourRange, index)] = value;
				}
				else { WriteLine("\nИндекс не входит в диапазон!\n"); }
			}
		}
		public void InitRange()
		{
			ourRange = new int[LowerBound - UpperBound + DEFAULT_NUMBER_FOR_RANGE];
			int temp = UpperBound;
			
			for (int i = 0; i < ourRange.Length; i++)
			{
				ourRange[i] = temp;
				temp++;
			}

			ourArray = new int[LowerBound - UpperBound + DEFAULT_NUMBER_FOR_RANGE];

			for (int i = 0; i < ourArray.Length; i++)
			{
				ourArray[i] = i* DEFAULT_MULTIPLY + i;
			}
		}
		public void PrintRange()
		{
			foreach (var i in ourRange)
			{
				Write(i + " ");
			}
		}
		public void PrintArray()
		{
			foreach (var i in ourArray)
			{
				Write(i + " ");
			}
		}
	}
}
