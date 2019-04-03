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
	public class Matrix
	{
		public int[] mas;

		public Matrix(int size)
		{
			mas = new int[size];

			for(int i=0; i<mas.Length; i++)
			{
				mas[i] = i;
			}
		}
		public int this[int index]
		{
			get
			{
				return mas[index];
			}
			set { mas[index] = Convert.ToInt32(Math.Pow(mas[index], 2)); }
		}
		public void Print()
		{
			foreach (var i in mas)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine("\n");
		}
	}
}