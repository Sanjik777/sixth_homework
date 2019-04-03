using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Индексаторы и свойства.

1.	Создать индексатор для одномерного массива который
при установке значения будет возводить в квадрат передаваемое значение переменной
и устанавливать его для указанного индекса.
При получении элемента массива по индексу будет возвращаться его текущее значение.
 */
namespace Sixth_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			const int arraySize = 10;
			const int selectedIndex = 6;
			
			Matrix matrix = new Matrix(arraySize);
			
			matrix[selectedIndex] = 6;
		
			Console.WriteLine("Powered element = " +
				matrix[selectedIndex]);

			matrix.Print();

			Console.ReadKey();
		}
	}
}
