using System;
using System.Threading;

namespace TrataArquivoNetFrameWorl
{
	class Program
	{
		static void Main(string[] args)
		{
			LeituraArquivo();
			RegrasNegocio();
			EscritaArquivo();
		}

		private static void LeituraArquivo()
		{
			Console.WriteLine($"Início LeituraArquivo -> {DateTime.Now.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff")}");
			//Console.WriteLine("LeituraArquivo");
			//RegrasNegocio();
			Thread.Sleep(1001);
		}
		private static void RegrasNegocio()
		{
			Console.WriteLine($"Inicio RegrasNegocio -> {DateTime.Now.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff")}");
			//Console.WriteLine("RegrasNegocio");
			//EscritaArquivo();
			Thread.Sleep(1011);
		}
		private static void EscritaArquivo()
		{
			Console.WriteLine($"Inicio EscritaArquivo -> {DateTime.Now.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff")}");
			//	Console.WriteLine("EscritaArquivo");
			Thread.Sleep(1021);
			Console.ReadLine();
		}
	}
}
