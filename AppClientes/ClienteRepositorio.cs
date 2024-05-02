//Responsabilidade deste arquivo é de concentrar a manipulação dos dados
using System.Runtime.CompilerServices;
using Cadastro;

namespace Repositorio
{

    public class ClienteRepositorio
    {
        public List<Cliente> clientes = new List<Cliente>(); // Criando nova coleção/lista de clientes.

        public void GravarDadosClientes() //Metodo criado na aula Salvando e Recuperando dados
        {   
            //Metodo criado para evitar a perca dos cadastros ao finalizar o programa pois os dados
            //estão armazenados apenas na memória
            //para gravar os dados da coleção clientes em um arquivo foi feito primeiro uma serialização
            //da coleção para um formato json.
            var json = System.Text.Json.JsonSerializer.Serialize(clientes); 

            //depois criamos um arquivo txt que armazena este conteudo serializado na var json.
            File.WriteAllText("clientes.txt", json); 
        }

        public void LerDadosClientes() //Metodo criado na aula Salvando e Recuperando dados
        {
            //Já para a leitura dos dados para restauralos no momento que o programa é iniciado
            //primeiro verificamos a existência do arquivo criado no encerramento do programa
            //para ai sim restauralo.

            if (File.Exists("clientes.txt"))
            {
                //Fazemos a leitura dos dados armazenados no arquivo e atribuimos a var dados
                var dados = File.ReadAllText("clientes.txt");

                //Aqui ao contrario do que fizemos no método de guardar dados, que foi através da 
                //serialização, aqui fazemos a Desserialização e especificamos que estes dados
                //devem ser convertidos para o tipo Coleção/Lista de Cliente
                var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

                //Aqui adicionamos para a coleção clientes todos os dados recuperados com o AddRange que
                //adiciona todo o conteúdo e não apenas uma unica instancia. Estamos basicamente adicionando 
                //uma coleção a uma outra coleção.
                clientes.AddRange(clientesArquivo);

            }

        }

        
        //Metodos abaixo criados na aula Implementando Funcionalidades.
        public void ExcluirCliente()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            clientes.Remove(cliente);

            Console.WriteLine("Cliente Removido com sucesso! [Enter]");

            Console.ReadKey();
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do cliente: ");
            var codigo = Console.ReadLine(); //Informando código do cliente para editar

            //fazendo um filtro na coleção de clientes para encontrar o cliente com o Id compativel ao
            //código informado na var codigo se não encontrado o retorno padrão será 0 ou false;
            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)//após filtrar verifica se há dados se não houver e o obj cliente for vazio retorna a mensagem abaixo
            {
                Console.WriteLine("Cliente não encontrado! [Enter]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente); // após todo processo imprimi os dados do cliente encontrado

            Console.Write("Nome do Cliente: "); //e daqui em diante é como se fosse o cadastro porém estamos editando o obj que selecionamos
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento: ");
            var dataDeNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto: ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            cliente.Nome = nome;
            cliente.DataNascimento = dataDeNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            Console.WriteLine("Cliente Alterado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }

        public void CadastrarCliente()
        {
            Console.Clear(); //limpando console

            //recebendo dados para atribuir ao objeto cliente
            Console.Write("Nome do Cliente: ");
            var nome = Console.ReadLine(); // realizando a leitura de nome
            Console.Write(Environment.NewLine); //quebrando uma linha após receber o nome do cliente

            Console.Write("Data de Nascimento: ");
            var dataDeNascimento = DateOnly.Parse(Console.ReadLine()); //leitura de data de nascimento e convertendo para formato certo.
            Console.Write(Environment.NewLine); //quebrando uma linha após receber data de nascimento

            Console.Write("Desconto: ");
            var desconto = decimal.Parse(Console.ReadLine()); //leitura da quantidade de desconto e convertendo para formato certo.
            Console.Write(Environment.NewLine);

            var cliente = new Cliente(); // instanciando objeto cliente, para atribuir os dados recebidos as propriedades do obj
            cliente.Id = clientes.Count + 1; //para a Prop id contamos a quantidade existente na coleção e somamos + 1.
            cliente.Nome = nome; // atribuindo o que foi recebido na var nome para a prop Nome de cliente.
            cliente.DataNascimento = dataDeNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now; // Para a Prop CadastradoEm, atribuimos no momento da instancia do cliente data e hora
                                                 //que foi registrado com o DateTime.Now 

            clientes.Add(cliente); //Após receber todos os dados para o objeto, adicionamos o mesmo a coleção clientes criada anteriormente

            Console.WriteLine("Cliente Cadastrado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();
        }

        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine("ID.............: " + cliente.Id);
            Console.WriteLine("Nome...........: " + cliente.Nome);
            Console.WriteLine("Desconto.......: " + cliente.Desconto.ToString("0.00"));
            Console.WriteLine("Data Nascimento: " + cliente.DataNascimento);
            Console.WriteLine("Data Cadastro..: " + cliente.CadastradoEm);
            Console.WriteLine("------------------------------------");
        }

        public void ExibirClientes()
        {
            Console.Clear();
            foreach (var cliente in clientes)
            {
                ImprimirCliente(cliente);
            }

            Console.ReadKey();
        }
    }
}



