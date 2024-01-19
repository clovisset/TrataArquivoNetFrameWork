using Serilog;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace TrataArquivoNetFrameWorl
{
	class Program
	{
		static Stopwatch stopWatch = new Stopwatch();
		static void Main(string[] args)
		{
			LeituraArquivo();
			RegrasNegocio();
			EscritaArquivo();
		}
		public static void GeraLog()
		{
			string nomePastaLog = ConfigurationManager.AppSettings["ArqLog"].ToString();
			string dia = DateTime.Now.ToString("yyyy-MM-dd");
			dia = $@"{nomePastaLog}\ArquivoLog_{dia}.txt";
			Log.Logger = new LoggerConfiguration()
			.WriteTo.File(dia)
		   .CreateLogger();

		}
		private static void LeituraArquivo()
		{
			GeraLog();
			Console.WriteLine($"Início LeituraArquivo  -> {DateTime.Now.ToString("yyyy'-'MM'-'dd HH'(H):'mm'(Min):'ss'(seg)'fff'(Miliseg)'")}");

			
			stopWatch.Start();
			Log.Information($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
			Log.Information($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
		//	Console.WriteLine($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
		//	Console.WriteLine($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");

			//RegrasNegocio();
			Thread.Sleep(1001);
			TimeSpan ts = stopWatch.Elapsed;
			stopWatch.Stop();
			Log.Information($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Log.Information($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");
		//	Console.WriteLine($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Console.WriteLine($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");

		}
		private static void RegrasNegocio()
		{
			Console.WriteLine($"Início RegrasNegocio  -> {DateTime.Now.ToString("yyyy'-'MM'-'dd HH'(H):'mm'(Min):'ss'(seg)'fff'(Miliseg)'")}");
			GeraLog();
			//Console.WriteLine($"Início LeituraArquivo  -> {DateTime.Now.ToString("yyyy'-'MM'-'dd HH'(H):'mm'(Min):'ss'(seg)'fff'(Miliseg)'")}");


			stopWatch.Start();
			Log.Information($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
			Log.Information($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			//	Console.WriteLine($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
			//	Console.WriteLine($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");

			//RegrasNegocio();
		//	Thread.Sleep(1001);
			TimeSpan ts = stopWatch.Elapsed;
			stopWatch.Stop();
			Log.Information($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Log.Information($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");
			//	Console.WriteLine($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Console.WriteLine($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");

			Thread.Sleep(1011);
		}
		private static void EscritaArquivo()
		{
			Console.WriteLine($"Início EscritaArquivo -> {DateTime.Now.ToString("yyyy'-'MM'-'dd HH'(H):'mm'(Min):'ss'(seg)'fff'(Miliseg)'")}");

			GeraLog();
			//Console.WriteLine($"Início LeituraArquivo  -> {DateTime.Now.ToString("yyyy'-'MM'-'dd HH'(H):'mm'(Min):'ss'(seg)'fff'(Miliseg)'")}");


			stopWatch.Start();
			Log.Information($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
			Log.Information($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			//	Console.WriteLine($"--------------------------------- {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} ------------------------------------------");
			//	Console.WriteLine($"Início do Processo {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");

			//RegrasNegocio();
			//	Thread.Sleep(1001);
			TimeSpan ts = stopWatch.Elapsed;
			stopWatch.Stop();
			Log.Information($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Log.Information($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");
			//	Console.WriteLine($"Fim do Processo -> {DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss.fff")}");
			Console.WriteLine($" Duracao do Processo = {ts.Minutes.ToString()} minutos e {ts.Seconds.ToString()} segundos e {ts.Milliseconds.ToString()} Milisegundos");
			Thread.Sleep(1021);
			Console.ReadLine();
		}
	}
}
