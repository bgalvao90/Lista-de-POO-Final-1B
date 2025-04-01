using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Entities
{
    internal class Calculo
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public double Result { get; set; }

        public Calculo()
        {
        }
        public Calculo(double valorA, double valorB)
        {
            ValorA = valorA;
            ValorB = valorB;
        }

        public void Soma()
        {
            Result = ValorA + ValorB;
        }

        public void Subtracao()
        {
            Result = ValorA - ValorB;
        }

        public void Multiplicacao()
        {
            Result = ValorA * ValorB;
        }

        public double Maior()
        {
           return Result = ValorA > ValorB ? ValorA : ValorB;
        }

        public double SomarGeral(double[] valores)
        {
            Console.Write("Digite o valor a ser somado: ");
            double soma = double.Parse(Console.ReadLine());

            foreach (double valor in valores)
            {
                soma += valor;
            }
            return soma;
        }
        public double Imprimir()
        {
            return Result;
        }
    }
}
