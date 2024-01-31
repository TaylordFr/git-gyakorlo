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

			while (bekert != 0)
			{
				Console.Write("Adjon egy számot a listához: ");
				bekert = int.Parse(Console.ReadLine());
				szamok.Add(bekert);

			}

			

			for (int i = 0; i < szamok.Count; i++)
			{
				Console.Write(szamok[i] + "");
            }
		


			






		}
	}
}
