using Atividade04;

Console.Write("Digite o numero da vaga: ");
int numeroVaga = int.Parse(Console.ReadLine());

Console.Write("Digite o tipo do veiculo (carro, moto ou caminhão): ");
string tipoVeiculo = Console.ReadLine().ToLower();
VagaEstacionamento vaga = new VagaEstacionamento(numeroVaga, tipoVeiculo);

vaga.OcuparVaga();

Console.WriteLine();
Console.Write("Deseja alterar tipo do veiculo (s para sim) ou (n para nao) : ");
char opcao = char.Parse(Console.ReadLine().ToLower());
if (opcao == 's')
{
    if (!vaga.Ocupada)
    {
        Console.Write("Digite o novo tipo do veiculo (carro, moto ou caminhão): ");
        string novoTipo = Console.ReadLine().ToLower();
        vaga.AlterarTipoVeiculo(novoTipo);
        vaga.ExibirInformacoes();
    }

    else
    {
        
        Console.WriteLine("Tipo de veículo não alterado.");
        Console.Write("Deseja liberar a vaga para alterar o veiculo? ");
        opcao = char.Parse(Console.ReadLine().ToLower());

        if (opcao == 's') { 
        vaga.LiberarVaga();
        vaga.ExibirInformacoes();

        Console.Write("Digite o novo tipo do veiculo (carro, moto ou caminhão): ");
        string novoTipo = Console.ReadLine().ToLower();
        vaga.AlterarTipoVeiculo(novoTipo);
        Console.WriteLine();
        
        Console.WriteLine();
        vaga.ExibirInformacoes();

            Console.Write("Deseja ocupar a vaga novamente? ");
            opcao = char.Parse(Console.ReadLine().ToLower());
            if (opcao == 's')
            {
                vaga.OcuparVaga();
                Console.WriteLine();
                vaga.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Vaga livre.");
                vaga.ExibirInformacoes();
            }
        }
        else
        {
            Console.WriteLine("Vaga não liberada.");
            vaga.ExibirInformacoes();
        }

    }
    
}
else
{
    Console.WriteLine("Tipo de veículo não alterado.");
    vaga.ExibirInformacoes();
}

