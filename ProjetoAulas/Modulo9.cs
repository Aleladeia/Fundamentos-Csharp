using System;

namespace Conversores{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            //ANTES DE INICIAR, O MAIS RECOMENDADO COMO BOAS PRATICAS PARA SE UTILIZAR É O MÉTODO PARSE PARA 
            //CONVERSÃO POIS É MAIS OTIMIZADO QUE O CONVERT;

            //convertendo string numerico para inteiro com método Parse
            int numero = int.Parse("1"); 
            //convertendo string numerico para inteiro com método Convert
            int numero2 = Convert.ToInt32("1"); 
            //convertendo string para inteiro com método Convert, neste caso teremos uma excessão pois a letra "a"
            // não está no formato correto, ou seja o dado informado não é valido para converssão
            //int numero3 = Convert.ToInt32("a"); 
            Console.WriteLine(numero);
            Console.WriteLine(numero2);

            //convertendo string para inteiro com método Convert que nos retorna 0 e isso dependendo do cenário
            //aplicado pode ser um grande problema para a aplicação
            int numero4 = Convert.ToInt32(null);  
            //convertendo null para inteiro com método Parse, porém no caso ele não permite a conversão e cria uma
            //excessão pra mim, não permitindo que a conversão aconteça
            //int numero5 = int.Parse(null); 
            Console.WriteLine(numero4);

            //Convertendo string "verdadeiro" para bool, porém não é possivel pois a string verdadeiro não é um tipo
            //real da linguagem C#
            //bool verdadeiro = bool.Parse("Verdadeiro");//retorna excessão

            //neste caso utilizando o true, conseguimos executar pois true é um valor de double, ele consegue então
            //fazer a conversão
            bool verdadeiro1 = bool.Parse("true");
            Console.WriteLine(verdadeiro1);
        }

        public void ConversorTryParse()
        {
            //OUTRO TIPO DE CONVERSOR PORÉM ESTE TEM ALGUNS BENEFICIOS EM RELAÇÃO AO PARSE E O CONVERT COMO
            //POR EXEMPLO CONVERTER UM VALOR PARA OUTRO SEM RECEBER A EXCESSÃO QUE RECEBEMOS NOS MÉTODOS ANTERIORES
            
            var numero = "123456";

            /* Abaixo temos o método TryParse dentro de uma estrutura condicional, pois se trata de um metodo
               boleano, seu retorno é true ou false, e sua declaração é feita da seguinte forma como exemplo
               tipoDeDadoQueQueremos.TryParse(VarComValorAConverter, out tipoDadoSaida nomeVarSaida).
               O valor do tipoDadoSaida tem que ser o mesmo do tipoDeDadoQueQueremos, se for int, usar int
               se for string, usar string e etc.
             */
            if(int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Numero convertido com sucesso"); //Se true retorna a mensagem abaixo
            }

            Console.WriteLine(numeroConvertido); // escrevendo var com valor convertido no console;

        }
    }
}