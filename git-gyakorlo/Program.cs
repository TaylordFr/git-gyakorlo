using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_gyakorlo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1.feladat:
			//Létrehozva

			//2.feladat:
			List<int> szamok = new List<int>();

            Console.Write("Adjon egy számot a listához: ");
			int bekert = int.Parse(Console.ReadLine());
			Console.WriteLine(bekert);
			szamok.Add(bekert);

            while (bekert != 0)
			{
				Console.Write("Adjon egy számot a listához: ");
				bekert = int.Parse(Console.ReadLine());
				if(bekert != 0)
				{
					Console.WriteLine(bekert);
					szamok.Add(bekert);
				}
				
			}

			//3.feladat:
			for (int i = 0; i < szamok.Count; i++)
			{
				Console.Write(szamok[i] + ", ");
            }

			//4.feladat:
			int min = int.MaxValue;

			for (int i = 0; i < szamok.Count; i++)
			{
				if (szamok[i] < min)
				{
					min = szamok[i];
				}
			}
            Console.WriteLine($"\nA listában a minimum szám a(z): {min}");


			//5.feladat:

			int max = int.MinValue;

			for (int i = 0; i < szamok.Count; i++)
			{
				if (szamok[i] > max)
				{
					max = szamok[i];
				}
			}
            Console.WriteLine($"A listában a maximum szám a(z): {max}");





            Console.ReadKey();
		}
	}
}
