//#define CONSOLE
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
			Console.Write("Введите ваше Имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите вашу Фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите ваш Возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age); // Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age)); // Форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}"); // Интерполяция строк


		}
	}
}
