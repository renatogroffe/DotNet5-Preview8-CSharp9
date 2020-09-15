using System;
using System.IO;

namespace ExemploPropertyPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Utilizando Property Patterns...");

            var arquivos = new string[]
            {
                @"D:\Temp\teste.txt",
                @"C:\Windows\explorer.exe",
                @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Preview\Common7\IDE\devenv.exe",
                @"D:\Temp\qualquercoisa.txt"
            };

            foreach (string nomeArquivo in arquivos)
            {
                FileInfo fileInfo = new FileInfo(nomeArquivo);
                if (fileInfo is { Exists: true, Length: > 1000 })
                    Console.WriteLine($"{fileInfo.FullName} - Tamanho: {fileInfo.Length:0,000} bytes");
            }
        }
    }
}