using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    public class Gerente : Funcionario
    {
        string Departamento { get; set; }

        public Gerente(string nome, double salario, string departamento) : base(nome,  salario) 
            {

                Departamento = departamento;
            }

        public void ExibirDados()
        {
            string[] partes = NomeCompleto.Split(' ');
            string ultimoNome = partes[partes.Length - 1];

            Console.WriteLine(Salario < 10000.00? ultimoNome.ToUpper() + ", " 
                + Salario.ToString("F2") + ", " + Departamento 
                : ultimoNome.ToUpper() + ", " + Salario.ToString("F2") + ", "
                + Departamento + ", " +"Alta Gestão");
        }
    }
}
