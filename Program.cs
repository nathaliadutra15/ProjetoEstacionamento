using ProjetoEstacionamento.Models;

double precoInic, precoHora = 0;

Console.WriteLine("Seja bem vindo(a) ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
string getPrecoInic = Console.ReadLine();
Console.WriteLine("Agora digite o preço por hora: ");
string getPrecoHora = Console.ReadLine();

double.TryParse(getPrecoInic, out precoInic);
double.TryParse(getPrecoHora, out precoHora);

Estacionamento e = new Estacionamento(precoInic, precoHora);

string getOpcao = "";

do
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    getOpcao = Console.ReadLine();

    switch (getOpcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            e.addVeiculo(placa);
            Console.WriteLine("Veículo cadastrado! Pressione uma tecla para continuar.");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("Digite a placa do veículo para remover: ");
            placa = Console.ReadLine();
            e.removeVeiculo(placa);
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            string getTempo = Console.ReadLine();
            double.TryParse(getTempo, out double tempo);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R${e.calcPreco(tempo)}");
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadLine();
            break;
        case "3":
            e.listVeiculos();
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadLine();
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Comando inválido! Pressione uma tecla para tentar novamente.");
            Console.ReadLine();
            break;
    }

} while (getOpcao != "4");



