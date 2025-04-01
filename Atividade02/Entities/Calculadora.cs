using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Entities
{
    internal class Calculadora
    {
        public void LerValores(out double valorA, out double valorB)
        {
            Console.Write("Digite o primeiro valor: ");
            valorA = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valorB = double.Parse(Console.ReadLine());
        }
        Calculo calculo = new Calculo();
        public void ExecutarCalculadora()
        {
            double valorA, valorB;
            LerValores(out valorA, out valorB);
            calculo.ValorA = valorA;
            calculo.ValorB = valorB;
            calculo.Soma();
            Console.WriteLine("Soma: " + calculo.Imprimir());
            calculo.Subtracao();
            Console.WriteLine("Subtração: " + calculo.Imprimir());
            calculo.Multiplicacao();
            Console.WriteLine("Multiplicação: " + calculo.Imprimir());
            Console.WriteLine("Maior: " + calculo.Maior());
            Console.WriteLine("Soma Geral: " + calculo.SomarGeral(new double[] { valorA, valorB }));
        }
    }
}
