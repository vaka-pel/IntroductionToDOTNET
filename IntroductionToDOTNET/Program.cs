//#define CONSOLE
//#define NAME
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET");
            Console.WriteLine();
            Console.Title = "Introduction to .NET";
            Console.Beep(100, 200);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor(); 
#endif
#if NAME
			Console.Write("Введите ваше Имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите вашу Фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите ваш Возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age); // Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age)); // Форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}"); // Интерполяция строк

#endif

			for (int rows = 0; rows < 8; rows++)
			{
				for (int cols = 0; cols < 8; cols++)
				{
					Console.Write(rows % 2 == cols % 2 ? "* " : "* ");
				}
				Console.WriteLine();
			}
				Console.WriteLine();



			for (int rows = 0; rows < 8; rows++)
			{
				for (int cols = 0; cols < 8; cols++)
				{
					Console.Write(rows % 2 == cols % 2 ? "- " : "+ ");
				}
				Console.WriteLine();

			}	
			    Console.WriteLine();

			for (int i = 0; i < 8; i++)
			{
				for (int rows = 0; rows < 8; rows++)
				{
					for (int cols = 0; cols < 5; cols++)
					{
						for (int k = 0; k < 8; k++)
						{
							if (i % 2 == cols % 2)

								Console.Write("* ");

							else

								Console.Write("  ");
						}
					}
					Console.WriteLine();
				}
			}
		}
	}
}
