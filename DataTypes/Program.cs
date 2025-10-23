#define DATA_TYPES
//#define CONSTANS
//#define TYPE_CONVERSIONS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		const string delimiter = "\n----------------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);

			//////////////////////////////////////////////////////////
			Console.WriteLine
				(
				   $@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения в диапазоне
				   от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				   @"RAW-строка - игнорирует все специальные символы и Esc-последовательности \t\n,
                   т.е., воспринимается как есть 'as-is'"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				   $@"byte занимает {sizeof(byte)} Байт памяти, 
		           и принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue},
			       класс-обвертка {typeof(byte)}"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				   $@"byte занимает {sizeof(sbyte)} Байт памяти, 
		           и принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue},
			       класс-обвертка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine($@" decimal занимает {sizeof(decimal)} Байт памяти");
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
				   $@"ushort занимает {sizeof(ushort)} Байт памяти, 
		           и принимает значения в диапазоне от {ushort.MinValue} до {ushort.MaxValue},
			       класс-обвертка {typeof(ushort)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
				   $@"uint занимает {sizeof(uint)} Байт памяти, 
		           и принимает значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
			       класс-обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
				   $@"ulong занимает {sizeof(ulong)} Байт памяти, 
		           и принимает значения в диапазоне от {ulong.MinValue} до {ulong.MaxValue},
			       класс-обвертка {typeof(ulong)}"
				);
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////

			Console.WriteLine("Hello".GetType());
			Console.WriteLine(5.0.GetType());
#endif

#if CONSTANS

#endif

#if TYPE_CONVERSIONS

			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine(delimiter);

			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(b);

			//bool rain = Convert.ToBoolean("true");
			bool rain = bool.Parse("FaLsE");
			Console.WriteLine(rain);

		}
#endif
		}
	}
}
