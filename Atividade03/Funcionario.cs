using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    public class Funcionario
    {
        public string NomeCompleto { get; set; }
        public double Salario { get; set; }
    

    public Funcionario() { }

        public Funcionario(string nomeCompleto, double salario)
        {
            NomeCompleto = nomeCompleto;
            Salario = salario;
        }

        public virtual void ExibirDados()
        {
            string[] partes = NomeCompleto.Split(' ');
            string ultimoNome = partes[partes.Length - 1];
            Console.WriteLine(ultimoNome.ToUpper() + ", " + Salario.ToString("F2")); 
        }
    }
}
