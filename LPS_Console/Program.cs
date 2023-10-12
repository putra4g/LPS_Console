using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SOAL B
			//
			Console.WriteLine("SOAL B");
			Console.WriteLine("=============");
			Console.WriteLine("");
			Console.WriteLine("input : 1.225.441");
			Console.WriteLine("");
			Console.WriteLine("result :");

			string sinput = "1.225.441";

			string value = sinput.Replace(".", "");

			int[] arrVal = value.Select(c => c - '0').ToArray();

			for (int i = 0; i < arrVal.Length; i++)
			{
				string cmb = arrVal[i].ToString();
				int x = 1;
				for (int j = 0; j < (arrVal.Length-i) - x; j++)
				{
					cmb += "0";
				}

				Console.WriteLine(cmb);
				x = x + 1;

			}

			Console.WriteLine("");
			Console.WriteLine("SOAL C");
			Console.WriteLine("=============");
			Console.WriteLine("");
			Console.WriteLine("input : hello world");
			Console.WriteLine("");
			Console.WriteLine("result :");

			string value2 = "hello world";
			value2 = value2.Replace(" ", "");
			string[] arrP = new string[value2.Length];
			for (int i = 0; i < value2.Length; i++)
			{
				arrP[i] = value2[i] + " - " + countSameString(value2,value2[i].ToString()).ToString(); 
			}

			var ress = arrP.Distinct();

			foreach (var r in ress)
			{
				Console.WriteLine(r);
			}

			Console.WriteLine("");
			Console.WriteLine("SOAL D");
			Console.WriteLine("=============");
			Console.WriteLine("");
			Console.WriteLine("urutan angka 1 - 50");
			Console.WriteLine("");
			Console.WriteLine("result :");

			for (int i = 1; i <= 50; i++)
			{
				string res = i.ToString();
				if (i % 5 == 0 && i != 5)
				{
					res = "IDIC";
				}
				else if (i % 6 == 0 && i != 6)
				{
					res = "LPS";
				}
				Console.Write(res);
			}


			Console.WriteLine("");
			Console.WriteLine("SOAL E");
			Console.WriteLine("=============");
			Console.WriteLine("");
			Console.WriteLine("input : SeLamAT PAGi semua halOo");
			Console.WriteLine("");
			Console.WriteLine("result :");
			Console.WriteLine("");
			string inpt = "SeLamAT PAGi semua halOo";
			Console.WriteLine("Format Judul : " + FormatJudul(inpt));
			Console.WriteLine("Format Biasa : " + FormatBiasa(inpt));
			Console.ReadLine();
		}

		private static int countSameString(string fullString, string p) {
			int res = 0;
			for (int i = 0; i < fullString.Length; i++)
			{
				if (fullString[i].ToString() == p)
				{
					res++;
				}
			}
			return res;
		}

		private static string FormatBiasa(string input)
		{
			string res = input.ToLower();
			res = res[0].ToString().ToUpper() + res.Substring(1);
			return res;
		}

		private static string FormatJudul(string input)
		{
			string[] _arrInput = input.Split(' ');
			string res = "";
			foreach (var r in _arrInput)
			{
				res += FormatBiasa(r) + " ";
			}
			return res.Trim();
		}
	}
}
