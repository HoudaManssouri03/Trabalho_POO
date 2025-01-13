// Ignore Spelling: AAS Veiculos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Veiculos : AbstrataVeiculos,IVeiculos
    {
        #region Atributos
        private string sigla; // ligeiro, pesado 
        private string categoria;//florestal,urbano,aereo,maritimos
        private int lugares;
        #endregion

        #region Construtores
        public Veiculos()
        {
        }

        public Veiculos(string siglaPar, string categoriaPar, int lugaresPar)
        {
            this.sigla = siglaPar;
            this.categoria = categoriaPar;
            this.lugares = lugaresPar;
        }

        #endregion

        #region Destrutor
        ~Veiculos()
        {
        }

        #endregion

        #region Encapsulamento

        public string Sigla1
        {
            get
            {
                return this.sigla;
            }
            set
            {
                this.sigla = value;
            }
        }
        public string Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        public int Lugares
        {
            get
            {
                return this.lugares;
            }
            set
            {
                this.lugares = value;
            }
        }
        #endregion

        public void Transporte(string morada, int numeroDePassageiros)
        {

            if (numeroDePassageiros > lugares)
            {
                Console.WriteLine($"Não é possível transportar {numeroDePassageiros} pessoas. O veículo {sigla} tem capacidade para {lugares} pessoas.");
                return;
            }


            Console.WriteLine($"O veículo {sigla} está em movimento para {morada} e pode transportar {numeroDePassageiros} pessoas.");



        }



        public void TipoVeiculos(string marca, string modelo, int ano)
        {

            Console.WriteLine($"Informações do Veículo:");
            Console.WriteLine($"Sigla: {this.sigla}");
            Console.WriteLine($"Categoria: {this.categoria}");
            Console.WriteLine($"Capacidade: {this.lugares} lugares");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");

        }

       
    public string TipoVeiculos()
    {
        return this.categoria;
    }



   
    public void ExibirHistoricoViagens()
    {
        Console.WriteLine($"Histórico de viagens do veículo {sigla}:");
        if (historicoViagens.Count == 0)
        {
            Console.WriteLine("Nenhuma viagem registada.");
        }
        else
        {
            foreach (var viagem in historicoViagens)
            {
                Console.WriteLine(viagem);
            }
        }
    }

    public void Manutencao(bool emManutencao)
    {
        if (emManutencao)
        {
            Console.WriteLine($"O veículo {sigla} está em manutenção.");
        }
        else
        {
            Console.WriteLine($"O veículo {sigla} está operacional.");
        }
    }

    public bool DisponivelParaViagem()
    {
        return !emMovimento;
    }

    public void AtualizarLugares(int novosLugares)
    {
        if (novosLugares > 0)
        {
            lugares = novosLugares;
            Console.WriteLine($"A capacidade do veículo {sigla} foi atualizada para {lugares} lugares.");
        }
        else
        {
            Console.WriteLine("Número de lugares inválido.");
        }
    }

    #endregion
}

