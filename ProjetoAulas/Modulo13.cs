namespace Modulo13
{
    public class TrabalhandoComArquivos
    {
        // Neste módulo conhecemos algumas funcionalidades que fazem parte do namespace System.IO que é uma biblioteca
        // especializada para trabalhar com arquivos
        public void AulaCriandoArquivo()
        {
            /* Uma das funcionalidades é a que nos permite criar um arquivo com o metodo StreamWriter, que possui varias
               variações, porem neste caso utilizamos os parametros Path e Append. 
               Com o path podemos passar o diretório onde queremos criar o arquivo ou apenas o seu nome e extensão
               do arquivo, sem informar o caminho ele vai criar o arquivo diretamente na raiz do projeto.
               Já o append vai verificar se o arquivo já é existente se sim ele só vai adicionar as informações recebidas
               caso for passado True no seu parametro que espera um bool (true ou false). */

            var escrever = new StreamWriter("Cadastro.txt", true); //instanciando a classe StreamWriter e criando o arquivo 
            Console.Write("Informe um nome: ");
            var nome = Console.ReadLine(); // Fazendo leitura do nome que queremos armazenar no nosso arquivo

            /*abaixo utilizamos o metodo Random.Shared.Next(intervalo), que vai preencher o nosso campo ID aleatoriamente
             com os números existentes no intervalo de 1 a 100 como está abaixo*/
            escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); // nossa var escrever após receber a instancia de 
            escrever.WriteLine("Nome.: " + nome);                      // StreamWriter acaba possuindo algumas propriedades
            escrever.WriteLine("----------------------------------");  // como o WriteLine que vai escrever no arquivo criado

            escrever.Close(); // Já o close fecha o arquivo que foi criado no caso o Cadastro.txt
        }

        public void AulaLendoArquivo()
        /*Nesta aula vimos 2 formas de estar lendo um arquivo, através do File.ReadAllText("nomearquivo.extensão")
          que já vai ler o arquivo no total colocando todas as informações na memória ou podemos usar a segunda opção.
          StreamReader("nomearquivo.extensão") com ele conseguimos ter um controle maior da leitura do arquivo linha
          por linha sem ter a necessidade de ler todas informações de uma unica vez pra memória*/
        {
            //var conteudo = File.ReadAllText("Cadastro.txt");
            //Console.WriteLine(conteudo);

            var ler = new StreamReader("Cadastro.txt"); //instanciando StreamReader e o parametro é o nome do arquivo
            while (!ler.EndOfStream) // aqui enquanto não chegar ao fim do arquivo ele vai continuar executando o
            {                       // while
                var linha = ler.ReadLine(); //com o ReadLine ele vai ler linha a linha o nosso arquivo
                Console.WriteLine(linha);
            }

            ler.Close(); //Fechando o arquivo
        }

        public void AulaExcluindoArquivo()
        /* Nesta aula vimos como realizar a exclusão de um arquivo, utilizando o metódo Exists da classe File 
        para verificar a existencia do arquivo que criamos, adicionamos a estrutura If pois retorna um Bool
        True ou false, então se verdadeiro o arquivo existe ai entramos no If e com o método Delete realizamos
        sua exclusão*/
        {
             if(File.Exists("Cadastro.txt")) // Verificando a existencia do arquivo se True entra no if
             {
                File.Delete("Cadastro.txt"); // Após verificar a existencia do arquivo aqui realizamos a exclusão
             }
        }
    }
}