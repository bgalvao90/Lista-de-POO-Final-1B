using System;
using Atividade03;

internal class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Você irá cadastrar um funcionario (f) ou gerente (g)?");
        char funcao = char.Parse(Console.ReadLine());

        do
        {
            if (funcao == 'f')
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Salario: ");
                double salario = double.Parse(Console.ReadLine());


                Funcionario func = new Funcionario(nome, salario);

                func.ExibirDados();
                Console.Write("Digite (f) ou (g) para cadastrar um novo funcionario / gerente (s) para sair.");
                funcao = char.Parse(Console.ReadLine());

            }

            else if (funcao == 'g')
            {

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Salario: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Digite o departamento: ");
                string departamento = Console.ReadLine();

                Gerente func = new Gerente(nome, salario, departamento);

                func.ExibirDados();

                Console.Write("Digite (f) ou (g) para cadastrar um novo funcionario / gerente ou (s) para sair.");
                funcao = char.Parse(Console.ReadLine());
            }


            else
            {
                Console.WriteLine("Digite uma opção valida ou (s) para sair.");
                funcao = char.Parse(Console.ReadLine());
            }
        } while (funcao != 's');
    }
}