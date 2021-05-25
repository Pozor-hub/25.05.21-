using System;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{    // написать программу оторая по номеру месяца выдает название следующего за ним месяца
			 //Console.WriteLine("Введите номер месяца");
			 //int m = int.Parse(Console.ReadLine());
			 //switch (++m)
			 //{ 
			 //	case 1: Console.WriteLine("Февраль"); break;
			 //	case 2: Console.WriteLine("Март"); break;
			 //	case 3: Console.WriteLine("Апрель"); break;
			 //	case 4: Console.WriteLine("Май"); break;
			 //	case 5: Console.WriteLine("Июнь"); break;
			 //	case 6: Console.WriteLine("Июль"); break;
			 //	case 7: Console.WriteLine("Август"); break;
			 //	case 8: Console.WriteLine("Сентябрь"); break;
			 //	case 9: Console.WriteLine("Октябрь"); break;
			 //	case 10: Console.WriteLine("Ноябрь"); break;
			 //	case 11: Console.WriteLine("Декабрь"); break;
			 //	case 12: Console.WriteLine("Январь"); break;
			 //	default:
			 //			Console.WriteLine( "Ошибка");break;
			 //}

			// Написать программу, позволяющую по последней цифре числа определить послуднюю цифру его квадрата
			//int n = int.Parse(Console.ReadLine());
			//Console.WriteLine(n * n % 10);
			//Console.ReadKey();

			// найти все делители натурального числа N
			Console.WriteLine("введите число N");
			int n = int.Parse(Console.ReadLine());
			for (int s = 1; s <= n; s++) 
			{
				if (n % s == 0) 
					Console.WriteLine("{0}" , s);

			}









		}

	}
}
