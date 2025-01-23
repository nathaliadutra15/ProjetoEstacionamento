using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        private List<EstacionamentoModel> lista = new List<EstacionamentoModel>();
        private double precoInic;
        private double procoHora;

        public Estacionamento (double precoInic, double procoHora) {
            this.precoInic = precoInic;
            this.procoHora = procoHora;
        }

        public void addVeiculo(string placa)
        {
            lista.Add(new EstacionamentoModel { placa = placa });
        }

        public void listVeiculos()
        {
            if (lista.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (var veiculo in lista)
                {
                    Console.WriteLine($"* {veiculo.placa}");

                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }

        public void removeVeiculo(string placa)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].placa == placa) lista.RemoveAt(i);
            }
        }

        public double calcPreco(double tempo)
        {
            return this.precoInic + (this.procoHora * tempo);
        }
    }
}