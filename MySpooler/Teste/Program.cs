using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] diretorios = Directory.GetDirectories("C:\\");
            string[] arquivos = Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures");

            Console.WriteLine("Diretórios:");
            foreach (string dir in diretorios)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Arquivos:");
            foreach (string arq in arquivos)
            {
                Console.WriteLine(arq);
            }
        }
    }
}
