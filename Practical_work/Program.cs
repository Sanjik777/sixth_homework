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
	class Program
	{
		static void Main(string[] args)
		{
			RangeOfArray range = new RangeOfArray();
			int input = -9;
			range.UpperBound = 8;
			range.LowerBound = -10;

			if (range.UpperBound > range.LowerBound)
			{
				int temp = range.UpperBound;
				range.UpperBound = range.LowerBound;
				range.LowerBound = temp;
			}

			WriteLine($"Верхний и нижний диапазон: {range.UpperBound}, {range.LowerBound}");

			WriteLine("\nнаши индексы (в виде массива): ");

			range.InitRange();
			range.PrintRange();

			WriteLine("\n\nнаш массив: ");
			range.PrintArray();

			WriteLine("\n\nРабота с массивом по индексу: ");
			if (input>= range.UpperBound && input<=range.LowerBound)
			{
				WriteLine($"Array[{input}] = { range[input]}");
			}
			else { WriteLine(range[input]); }


			ReadKey();
		}
	}
}
