using System;

namespace Exercicio_6
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b, calculo;
		
			Console.WriteLine("Digite um valo em reais: ");
			a = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a cotação dolar: ");
			b = Convert.ToDouble(Console.ReadLine());

			calculo = a * b;

			Console.WriteLine("O valor convertido é: " + calculo);

			Console.ReadKey();
			
		}
	}
}