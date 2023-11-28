using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_idades {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            double idade1, idade2, media;

            Console.WriteLine("Dados da 1a pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados da 2a pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = double.Parse(Console.ReadLine(), CI);

            media = ((idade1 + idade2) / 2);
            Console.WriteLine("Idade media de " + nome1 + " e " + nome2 +
            " é de " + media.ToString("F2", CI) + " anos.");
        }
    }
}
