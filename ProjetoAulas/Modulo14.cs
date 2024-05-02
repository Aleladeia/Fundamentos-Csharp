using System.Net.Mail;
using Cadastro;

namespace Modulo14
{
    public class TrabalhandoComLinq
    {

        //Como os metodos usados são todos genéricos, estes são capases de serem aplicados
        //a qualquer tipo de dado (string, caracter, inteiro, float, double e etc).
        public void AulaWhere()
        {
            // Cenário de Filtro para cadeia de caracteres
            //=================== SINTAXE DE METODO ===================

            //Consulta com Linq utilizando SINTAXE DE METODO

            //EXPRESSÃO LAMBDA: consiste na formula abaixo 
            //alias => alias + condição, exemplo: a => a == 'A'
            //sabemos que é uma expressão lambda por conta do sinal "=>" que é assim que definimos este tipo de expressão

            //Aqui abaixo na atribuição a var resultado está sendo utilizado um filtro com metodo de extensão Where  
            //que faz parte do LINQ junto com uma expressão LAMBDA que é a parte do p => p == 'A' 

            //string nomeCompleto = "ALEXANDRE JOSE";
            //var resultado = nomeCompleto.Where(p => p == 'A');

            //Outra forma de fazer, utilizando a func que é nosso Delegate para aplicar o filtro, a vantagem de usar a
            //Func é que podemos reaproveitala em vários lugares

            //Func<char,bool> filtro = c => c == 'A'; // atribuimos ao filtro a mesma expressão lambda usada anteriormente
            //var resultado = nomeCompleto.Where(filtro); // com isso temos o mesmo resultado

            //=================== SINTAXE DE CONSULTA ===================

            //Outro tipo de FILTRO utilizando o Linq é com o uso da SINTAXE DE CONSULTA sem utilizar metodos de extensão
            //explicando estrutura abaixo: palavra chave from, declarando tipo do caractere no caso o c para nossa 
            //cadeia de caracteres, palavra chave in, informamos nossa cadeia de caracteres que no caso é a var
            //nomeCompleto isso é como se fosse a iteração feita no nosso foreach logo abaixo, onde definimos
            // a var que vamos usar "c" que é um tipo/item da nossa coleção "nomeCompleto" na sequencia aplicamos
            //o filtro que queremos utilizando a palavra chave where(é um operador de restrição) e depois o filtro
            //de fato com o c == 'E' palavra chave select e o "c" que é o nosso alias que corresponde ao tipo char
            // os caracteres.

            /*var resultado = from c in nomeCompleto where c == 'E' select c;

            foreach(var letra in resultado)
            {
                Console.WriteLine(letra);
            }*/

            // Cenário de Filtro para array de numeros

            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
            var resultado = numeros.Where(p => p >= 10); // aplicando filtro para recuperar numeros acima ou iguais a 10
            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

            //Expressões LAMBDA são a forma mais simples para se aplicar um filtro
        }

        public void AulaOrdenacao()
        {
            //var numeros = new int[] {10, 6, 5, 50, 15, 2};
            //com OrderBy ordena de forma crescente, já OrderByDescending decrescente
            //var resultado = numeros.OrderBy(p => p); 

            var nomes = new string[] { "Alexandre", "Lucas", "Mayan", "Matheus", "Joao", "Vitor" };
            var resultado = nomes.OrderByDescending(p => p); //ordenando em ordem decrescente

            foreach (var nome in resultado)
            {
                Console.WriteLine(nome);
            }

        }

        public void AulaTake()
        {
            //Operador de paginação Take, nos fornece a capacidade de pegar uma parte de uma coleção
            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

            //aqui informamos a quantidade de elementos que queremos pegar da nossa coleção numeros
            var resultado = numeros.Take(3); //pega os 3 iniciais 10, 6 e 5   

            //Junto com o Take, podemos usar outros métodos aninhados como mostrado abaixo
            //var resultado = numeros.Take(3).OrderBy(p => p); //com OrderBy e expressão lambda para ordenar a exibição

            //Com o Where para aplicar filtro que é expressão lambda + condição
            //var resultado = numeros.Where(p => p > 6).Take(3).OrderBy(p => p);

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }
        }

        public void AulaCount()
        {
            //Count é um operador de agregação.

            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

            //Count nos mostra a quantidade de elementos presente na nossa coleção/ no nosso array.
            var resultado = numeros.Count();

            //Além do uso anterior o método Count possui uma sobrecarga que é um método adicional que
            //recebe parametros também e no caso podemos passar uma expressão lambda para aplicar um filtro no momento
            //que fizer a contagem, como no exemplo abaixo.
            //var resultado = numeros.Count(p => p > 10);

            Console.WriteLine(resultado);
        }

        public void AulaFirstEFirstOrDefault()
        {
            //Metódo que nos permite pegar primeiro elemento de uma coleção com ou sem filtro.

            var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
            //var numeros = new int[] { }; //caso a coleção esteja vazia o metodo First retorna uma excessão

            //var resultado = numeros.First(); //o metodo first também possui uma sobrecarga como no exemplo abaixo
            //Podemos passar um filtro com a expressão lambda e caso o filtro não seja uma condição valida para nossa
            //coleção ele também retorna uma exception por exemplo se o filtro fosse p => p > 100, daria erro.
            //var resultado = numeros.First(p => p > 100); 

            // no firstOrDefault diferente do first se nossa coleção estivesse vazia retornaria o valor default 
            //e não uma exception
            //var resultado = numeros.FirstOrDefault();  

            //O mesmo também possui uma sobrecarga para aplicação do filtro e além disso uma sobrecarga para definir
            //o valor padrão caso a coleção esteja vazia ou não atenda ao filtro.
            //var resultado = numeros.FirstOrDefault(p => p > 10);
            var resultado = numeros.FirstOrDefault(p => p > 100, -30); //retornou o -30 valor definido como default
                                                                      //pois não tem valor maior que 100 na coleção

            Console.WriteLine(resultado);

            //Abaixo temos outros exemplos de metodos de extensão disponibilizados pelo Linq

            //var outrosOperadoresLinq = numeros.Average(); //MEDIA
            //var outrosOperadoresLinq = numeros.Max(); //MAIOR VALOR
            //var outrosOperadoresLinq = numeros.Min(); //MENOR VALOR
            //var outrosOperadoresLinq = numeros.Distinct();
            //var outrosOperadoresLinq = numeros.Single();
            //var outrosOperadoresLinq = numeros.SingleOrDefault();

            //Console.WriteLine(outrosOperadoresLinq);

        }


    }
}