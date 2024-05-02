//using System.Globalization;
using Repositorio;

namespace AppClientes;

class Program
{

    static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();

    static void Main(string[] args)
    {
        /* 
        um problema enfrentado pelo professor deste curso na implementação deste projeto foi na execução
        do mesmo, onde no cadastro de cliente na parte de informar a data de nascimento ocorreu um erro pois o professor
        utiliza o sistema operacional de sua maquina em inglês e ele passou a data no formato pt-br neste sistema, no meu
        caso não ocorreu este problema pois uso o SO todo em português então não tive este problema. Para resolver o problema 
        segue código abaixo. */

        /*
        var cultura = new CultureInfo("pt-BR"); // temos que fazer o import da classe CultureInfo com o using System.Globalization;
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura
        */

        _clienteRepositorio.LerDadosClientes();
        while(true)
        {
            Menu();
            
            Console.ReadKey(); //Trava a aplicação até que uma tecla seja pressionada
        }
    }

    static void Menu()
    {

        Console.Clear();

        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");

        EscolherOpcao();

    }

    static void EscolherOpcao()
    {
        Console.Write("Escolha uma opção: ");
        var opcao = Console.ReadLine();

        switch(int.Parse(opcao))
        {
            case 1:
            {
                _clienteRepositorio.CadastrarCliente();
                Menu();
                break;
            }
            case 2:
            {
                _clienteRepositorio.ExibirClientes();
                Menu();
                break;
            }
            case 3:
            {
                _clienteRepositorio.EditarCliente();
                Menu();
                break;
            }case 4:
            {
                _clienteRepositorio.ExcluirCliente();
                Menu();
                break;
            }case 5:
            {
                _clienteRepositorio.GravarDadosClientes();
                Environment.Exit(0);
                break;
            }
            default:
            {
                Console.Clear();
                Console.WriteLine("Opção Inválida");
                break;
            }

        }
    }

}
