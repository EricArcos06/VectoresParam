using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectoresParam
{
	class Program
	{
		const int MAX = 10;
		static void Main(string[] args)
		{
			int[] x = new int[MAX];
			leer(x);
			imprimir(x);
			if (buscar(x, 15) == true)
				Console.WriteLine("\n15 encontrado");
			else
				Console.WriteLine("\n15 NO EXISTE");
			Console.ReadKey();
		
		}
		public static void leer(int[] x)
		{
			for (int i = 0; i <= MAX; i++)
			{
				Console.WriteLine("\nIngrese el elemento {0}", i + 1);
				x[i] = Int32.Parse(Console.ReadLine());
			}
		}
		public static void imprimir(int[] x)
		{
			foreach (int num in x)
			{
				Console.WriteLine("\nElemento {0}", num);
			}
		}

		public static bool buscar(int[] x, int y)
		{
			bool encontrado = false;
			foreach (int num in x)
			{
				if (num == y)
				{
					encontrado = true;
					break;

				}
			}
			return encontrado;
		}
	}
}