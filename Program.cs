using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Program
	{
		/* Дана матрица, определить является ли она магической, т.е. в которой суммы элементов во всех строка и столбцах одинаковы.*/
		static void Main(string[] args)
		{
			int n, m, i, j, sum, sum1;

			Console.WriteLine("Введите количество строк в массиве");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите количество столбцов в массиве");
			m = Convert.ToInt32(Console.ReadLine());
			Random rand = new Random();
			int[,] arr = new int[n, m];
			for (i = 0; i < n; i++)
			{
				Console.WriteLine("");
				for (j = 0; j < m; j++)
				{
					arr[i, j] = rand.Next(-15, 15);
					Console.Write(arr[i, j] + " ");
				}
			}
			Console.WriteLine(" ");
			sum = 0;
			for (j = 0; j < m; j++)
				for (i = 0; i < n; i++)
					sum = sum + arr[i, j];

			Console.WriteLine("Сумма элементов всех столбцов=" + sum);
			sum1 = 0;
			Console.WriteLine(" ");
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					sum1 = sum1 + arr[i, j];

			Console.WriteLine("Сумма элементов всех строк=" + sum1);

			Console.WriteLine(" ");
			if (sum==sum1)
			{
				Console.WriteLine("Матрица является магическим квадратом!!!");
			}
			 if (sum!=sum1)
			 {
				Console.WriteLine("Матрица не является магическим квадратом!!!!");
			 }
 

			
			Console.ReadKey();
		}
	}
}
