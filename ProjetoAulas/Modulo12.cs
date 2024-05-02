namespace Modulo12
{
    public class TrabalhandoComExcecoes
    {
        public void AulaGerandoException()
        {
            while (true) //estrutura while para laço de repetição, usamos neste exemplo para gerar uma exception
            {
                Console.WriteLine("Informe um numero: ");
                var numero = Console.ReadLine(); //Ao informamos 0 na leitura para a var numero uma exception será gerada
                var resultado = 500 / int.Parse(numero);  // pois a divisão por 0 não é possivel.
                Console.WriteLine("Resultado = " + resultado);
            }
        }

        /*Nesta aula abaixo conhecemos a estrutura Try Catch para tratamento das excessões. ela é importante pois se
          ocorrer algum erro durante a execução da aplicação a mesma não é finalizada, ela faz o tratamento do erro
          e informa o usuário onde está o problema*/
        public void AulaTratandoException()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Informe um numero: ");
                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine("Resultado = " + resultado);
                }
                //neste caso usamos um Exception customizada, algumas destas classes de Exception customizada vem com o .net
                //como por exemplo DivideByZeroException que ja herda os comportamentos da classe Exception, esta neste caso
                //já é customizada para trabalhar com erros aritméticos
                catch (DivideByZeroException exception) 
                {
                    Console.WriteLine("Ocorreu um erro de divisão: " + exception.Message);
                    Console.WriteLine("Stack: " + exception.StackTrace);
                }
                //usando a Exception padrão
                catch (Exception e) // adicionando o (Exception e) conseguimos através da variavel "e" o acesso a mensagem
                {                   // do erro que ocorreu
                    //aqui passamos essa mensagem de erro através da variavel e com a propriedade Message
                    Console.WriteLine("Ocorreu um erro: " + e.Message);
                    //com a propriedade StackTrace conseguimos pegar toda a pilha do erro e a linha onde exatamente acontece
                    //o erro
                    Console.WriteLine("Stack: " + e.StackTrace);
                }

            }
        }
    }
}