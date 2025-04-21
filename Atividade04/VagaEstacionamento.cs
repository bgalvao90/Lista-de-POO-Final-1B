using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    class VagaEstacionamento
    {
     
        public int NumeroVaga { get; private set; }
        public bool Ocupada { get; private set; }
        public string TipoVeiculo { get; private set; }

        public VagaEstacionamento(int numerovaga, string tipoveiculo)
        {
            if (!TipoValido(tipoveiculo))
            {
                throw new ArgumentException("Tipo de veículo inválido. Aceito: carro, moto ou caminhão.");
            }

            NumeroVaga = numerovaga;
            TipoVeiculo = tipoveiculo;
            Ocupada = false;
        }

        public void OcuparVaga()
        {
            Console.WriteLine("Vaga Ocupada");
            Ocupada = true;
        }

        public void LiberarVaga()
        {
            Console.WriteLine("Vaga liberada!");
            Ocupada = false;
        }

        public void AlterarTipoVeiculo(string novoTipo)
        {
            if (!Ocupada)
            {
                Console.WriteLine("Tipo de veículo alterado com sucesso.");
                TipoVeiculo = novoTipo;
            }

            if (TipoValido(novoTipo))
            {
                TipoVeiculo = novoTipo;
            }

            else
            {
                Console.WriteLine("A vaga está ocupada. Não é possível alterar o tipo de veículo.");
            }
        }

        public void ExibirInformacoes()
        {

            Console.WriteLine($"Número da Vaga: {NumeroVaga}");
            Console.WriteLine($"Tipo de Veículo: {TipoVeiculo}");
            Console.WriteLine($"{(Ocupada ? "Ocupada" : "Livre")}");
        }

        public bool TipoValido(string tipoVeiculo)
        {
            return tipoVeiculo == "carro" || tipoVeiculo == "moto" || tipoVeiculo == "caminhão" || tipoVeiculo == "caminhao";
        }
    }
    
}
