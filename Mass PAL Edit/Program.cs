using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Mass_PAL_Edit
{
    internal static class Program
    {
        private static void GenerateDerivativePalette(IReadOnlyList<uint> colors, string originalFilePath, string derivativeFilePath)
        {
            var pal1 = File.ReadAllBytes(originalFilePath);
            var colIndex = 0;
            
            const int start = 16 * 8 * 4 - 1;
            const int end = 17 * 8 * 4 - 1;
            for (var i = start; i < end; i += 4)
            {
                var bytes = BitConverter.GetBytes(colors[colIndex]);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(bytes);
                for (var j = 0; j < bytes.Length; j++)
                {
                    pal1[i+j] = bytes[j];
                    
                }
                colIndex++;
            }
            File.WriteAllBytes(derivativeFilePath, pal1);
        }
        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(" ---- Este programa deve ser rodado um diretório acima da pasta onde estão os palettes base, de onde todos os novos serão derivados. ---- \n");
            Console.Write("Digite o nome da pasta que contém os palettes base: ");
            var baseFolder = Console.ReadLine();

            Console.Write("Digite um nome para a pasta do primeiro conjunto de palettes derivadas: ");
            var targetFolder = Console.ReadLine();
            while (!string.Equals(targetFolder, "", StringComparison.Ordinal))
            {
                ReadNewGradient(baseFolder, targetFolder);
                Console.WriteLine($"Palettes {targetFolder} geradas com sucesso!");
                Console.Write("Digite um nome para a pasta do próximo conjunto de palettes derivadas: ");
                targetFolder = Console.ReadLine();
            }
        }

        private static void ReadNewGradient(string baseFolder, string targetFolder)
        {
            Console.Write("Digite o gradiente de cores: ");
            var input = Console.ReadLine();
            if (input == null) return;

            var colors =
                input.Split(',')
                    .Select((s) =>
                        uint.Parse(s.Substring(2), System.Globalization.NumberStyles.AllowHexSpecifier))
                    .ToArray();


            var baseDir = $@"{AppDomain.CurrentDomain.BaseDirectory}\{baseFolder}";
            var targetDir = $@"{AppDomain.CurrentDomain.BaseDirectory}\{targetFolder}";

            Directory.CreateDirectory(targetDir);
            foreach (var palFileFullLocation in Directory.EnumerateFiles(baseDir))
            {
                var fileName = palFileFullLocation.Substring(baseDir.Length);
                GenerateDerivativePalette(colors, palFileFullLocation, $@"{targetDir}\{fileName}");
            }
        }
    }
}