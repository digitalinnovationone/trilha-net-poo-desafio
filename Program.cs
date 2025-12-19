using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Iniciando testes dos Smartphones ===");
            Console.WriteLine();

            // Testes com Nokia (memória limitada para demonstrar falhas/recuperação)
            var nokia = new Nokia(numero: "11987654321", modelo: "Nokia 3310", imei: "IMEI-NOK-0001", memoria: 32);
            Console.WriteLine("== Nokia ==");
            Console.WriteLine(nokia); // ToString()

            Console.WriteLine($"Memória disponível: {nokia.GetMemoriaDisponivel()} MB");
            nokia.InstalarAplicativo("WhatsApp");   // 10 MB
            nokia.InstalarAplicativo("Facebook");   // 10 MB
            nokia.InstalarAplicativo("Instagram");  // 10 MB -> deve caber (total 30 MB usado)
            Console.WriteLine($"Memória disponível após instalações: {nokia.GetMemoriaDisponivel()} MB");

            Console.WriteLine("Tentando instalar WhatsApp novamente (deve falhar):");
            nokia.InstalarAplicativo("WhatsApp"); // duplicata

            Console.WriteLine("Tentando instalar Telegram (espaço insuficiente):");
            nokia.InstalarAplicativo("Telegram"); // deve falhar (só 2 MB restante)

            Console.WriteLine("Aplicativos instalados no Nokia:");
            foreach (var app in nokia.ListarAplicativos())
                Console.WriteLine($" - {app}");

            Console.WriteLine("Desinstalando Facebook...");
            if (nokia.DesinstalarAplicativo("Facebook"))
                Console.WriteLine("Facebook desinstalado com sucesso.");

            Console.WriteLine($"Memória disponível após desinstalar: {nokia.GetMemoriaDisponivel()} MB");
            Console.WriteLine("Instalando Telegram novamente (deve agora caber)...");
            nokia.InstalarAplicativo("Telegram");

            Console.WriteLine();
            Console.WriteLine("Aplicativos finais no Nokia:");
            foreach (var app in nokia.AplicativosInstalados)
                Console.WriteLine($" - {app}");

            Console.WriteLine();
            // Testes com iPhone
            var iphone = new Iphone(numero: "11912345678", modelo: "iPhone 13", imei: "IMEI-IPH-0001", memoria: 128);
            Console.WriteLine("== iPhone ==");
            Console.WriteLine(iphone);

            Console.WriteLine($"Memória disponível: {iphone.GetMemoriaDisponivel()} MB");
            iphone.InstalarAplicativo("Telegram");     // 15 MB
            iphone.InstalarAplicativo("Spotify");      // 15 MB
            iphone.InstalarAplicativo("YouTube");      // 15 MB

            Console.WriteLine($"Memória disponível após instalações: {iphone.GetMemoriaDisponivel()} MB");
            Console.WriteLine("Aplicativos instalados no iPhone:");
            foreach (var app in iphone.ListarAplicativos())
                Console.WriteLine($" - {app}");

            Console.WriteLine();
            Console.WriteLine("Teste concluído. Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}