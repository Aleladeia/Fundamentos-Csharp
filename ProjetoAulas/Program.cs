// --- POO - Programação Orientada a Objetos  ---

// ==== Top-Level-Statement ====
//Console.WriteLine("Primeiro programa"); <= exemplo de top level statement

//Estrutura abaixo era obrigatória até no .net 5 para definir o ponto de partida da aplicação.
//using Cadastro;
using System;
using System.Net.NetworkInformation;
using Cadastro;
using Conversores;
using Modulo13;

namespace Application // namespace é uma forma de organizar o código dentro da aplicação. dividir módulo de um
{                     // ERP por exemplo, com namespace Cadastros, Financeiro, Funcionários e etc...
    public class Program
    {
        static void Main(string[] args) // a partir do método main é que é executado a nossa aplicação
        {
            //Console.WriteLine("Olá Mundo");

            //AULAS MÓDULO 8 CLASSES E OUTROS TIPOS
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata();
            //AulaRecord();
            //AulaInterface();

            //AULAS MÓDULO 9 CONVERSORES DE VALOR
            //AulaConvertParse();
            //AulaTryParse();

            //AULAS MÓDULO 10 TRABALHANDO COM STRINGS
            //AulaToLower();
            //AulaToUpper();
            //AulaSubstring();
            //AulaRange();
            //AulaContains();
            //AulaTrim();
            //AulaStartsAndEndsWith();
            //AulaReplace();
            //AulaLenght();

            //AULAS MÓDULO 11 TRABALHANDO COM DATAS
            //TrabalhandoComDatas();

            //AULAS MÓDULO 12 TRABALHANDO COM EXCEÇÕES
            //TrabalhandoComExcecoes();

            //AULAS MÓDULO 13 TRABALHANDO COM ARQUIVOS
            //TrabalhandoComArquivos();

            //AULAS MÓDULO 14 TRABALHANDO COM LINQ
            TrabalhandoComLinq();

        }
        //AULAS MÓDULO 8 CLASSES E OUTROS TIPOS
        private static void AulaClasses()
        {
            // acessando classe Calculos sem instanciar a mesma pois ela é static
            var resultado = Cadastro.Calculos.CalculaValor(5, 3);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto(); //Instanciando classe Produto
            produto.Descricao = "Vassoura";//Acessando instancia produto e atribuindo valor a propriedade Descricao
            produto.SetId(1); // definindo o Id do produto com o método criado que acessa a propriedade privada Id

            produto.ImprimirDescricao(); //Invocando método da classe produto
        }

        private static void AulaPropriedadeSomenteLeitura()
        {

            var produto = new Cadastro.Produto();
            produto.Descricao = "Teclado";
            //produto.Estoque = 1; não é possivel adicionar o valor ao estoque pois é uma prop readonly
            Console.WriteLine(produto.Estoque);
            //porém acessar o valor é possivel, valor que foi atribuido no construtor da classe Produto
        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica(); //instanciando PessoaFisica, que tem o comportamento de Pessoa
            pessoaFisica.Id = 1;                   //e além dele a prop CPF exclusiva de PessoaFisica
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Cidade Teste";
            pessoaFisica.Cep = "87910000";
            pessoaFisica.CPF = "08063016947";

            pessoaFisica.ImprimirDados(); //Invocação dos metodos.
            pessoaFisica.ImprimirCPF();

            var funcionario = new Cadastro.Funcionario(); //instanciando Funcionário que acaba tendo o mesmo comportamento 
            funcionario.Id = 10;                 //de PessoaFisica e Pessoa por conta da herança e além deles a
            funcionario.Endereco = "Enderecoi Teste"; //prop matricula exclusiva de funcionario que não foi 
            funcionario.Cidade = "Cidadei Teste";     //usada neste caso
            funcionario.Cep = "879100001";
            funcionario.CPF = "080630169479";
            //funcionario.Matricula = "Soldador";
            funcionario.ImprimirDados();//Invocação dos metodos. Estes no caso para exibir os dados no console
            funcionario.ImprimirCPF();
        }

        private static void AulaClasseSelada()
        {
            var configuracao = new Cadastro.Configuracao //forma mais clean de setar valor para propriedade de uma
            {                                            //instancia
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaClasseAbstrata() //um dos pilares da POO a abstração
        {
            // var animal = new Cadastro.Animal <= não é possivel instanciar uma classe abstrata
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Klebinho";
            cachorro.ImprimirDados();
        }


        public static void AulaRecord()
        {
            //============================== PROBLEMA 1 ============================================================
            // Comparação entre objetos do mesmo tipo um utilizando tipo class e outro com tipo Record
            //==== EXEMPLO SEM USO DO RECORD ====
            var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

            // retorna false no console pois ele está comparando a refêrencia e não os valores das propriedades
            //Console.WriteLine(curso1 == curso2); 

            // false também, porém para mudar este cenário sobrescrevemos o método equals no arquivo Modulo8.cs
            //Console.WriteLine(curso1.Equals(curso2)); 

            // Para mudar o cénario do uso do operador de == temos que sobrescrever a validação feita pelo 
            // operador para que ela use a do método equals que sobrescrevemos como exibido no arquivo modulo8.cs
            // linhas 173 a 181

            // aqui após sobrescrever a validação do operador == o resultado é true
            // Console.WriteLine(curso1 == curso2);  

            // as abordagens acima funcionam porém são mais complexas e precisam escrever bastanta código para
            // contornar a situação, abaixo segue a implementação com uso do RECORD que deixa mais simples este
            // processo feito anteriormente.


            //==== EXEMPLO COM USO DO RECORD COMO SERIA ====
            // Instanciando da forma padrão.    
            // var cursoRecord1 = new Cadastro.CursoRecord{Id = 1, Descricao = "Curso"};
            // var cursoRecord2 = new Cadastro.CursoRecord{Id = 1, Descricao = "Curso"};
            // Console.WriteLine(cursoRecord1 == cursoRecord2); Resultado neste caso é true

            //Instanciado com dados imutaveis (readonly) onde nosso objeto do tipo record está parametrizado
            //com (int Id, string Descricao), por isso abrimos parenteses no caso abaixo para passar o valor
            //aos parametros que ao compilar são identificados como propriedades
            var cursoRecord1 = new Cadastro.CursoRecord(1, "Curso");
            var cursoRecord2 = new Cadastro.CursoRecord(1, "Curso");
            //cursoRecord1.Descricao = "Teste"; <= imutavel pois não é possivel alterar o valor da prop após
            // instanciar o objeto

            // com uso do record em vez da classe padrão o resultado neste caso é true.
            //Console.WriteLine(cursoRecord1 == cursoRecord2);



            //============================== PROBLEMA 2 ============================================================
            // Exemplo para o problema de caso queira copiar os valores de todas propriedades de uma instancia já  
            // existente para outra de mesma classe

            //==== EXEMPLO SEM USO DO RECORD ====
            //var cursoTeste1 = new Cadastro.CursoTeste{Id = 1, Descricao = "Curso Teste"};
            //var cursoTeste2 = cursoTeste1; 
            //fazer desta forma não resolve o problema, mas sim cria outro pois quando criamos a instancia de uma  
            //classe nós criamos uma referência um apontamento lá na memória, quando atribuimos essa instancia para
            //outra var/instancia estamos pegando o mesmo apontamento da instancia anterior e atribuindo para a nova 
            //instancia, fazendo com que ambas apontem para o mesmo endereço da memória.

            //cursoTeste2.Descricao = "TESTE TESTE";

            //Ambos cursoTeste1 e 2 imprimem TESTE TESTE pois ao modificar a descrição de cursoTeste2 alterou também 
            //no 1 pois ambos estão apontando para o mesmo endereço da memória
            //Console.WriteLine(cursoTeste1.Descricao); 
            //Console.WriteLine(cursoTeste2.Descricao);  


            //Resolvendo problema acima
            var cursoTeste1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso Teste" };
            //Aqui foi criado uma instancia nova para cursoTeste2 e não foi atribuido uma instancia existente 
            //como na linha 149. Assim temos 2 endereços de memória sendo usados 1 pra cada instancia.
            var cursoTeste2 = new Cadastro.CursoTeste();
            cursoTeste2.Id = cursoTeste1.Id;
            cursoTeste2.Descricao = "TESTE TESTE";

            //==== EXEMPLO COM USO DO RECORD COMO SERIA ====
            //nossa classe CursoTesteRecord é do tipo Record e com isso com o auxilio da keywork with que vai 
            //copiar os valores das propriedades de cursoTesteRecord1 para nossa cursoTesteRecord2 e se quisermos
            //modificar alguma das props basta passar dentro de chaves a propriedade e o novo valor dela como 
            //vemos a seguir, cursoTesteRecord1 with {Descricao = "Curso Novo"}, criando uma nova instancia para
            //cursoTesteRecord2. Muito mais simples do que usando com class
            var cursoTesteRecord1 = new Cadastro.CursoTesteRecord(1, "Curso Record");
            var cursoTesteRecord2 = cursoTesteRecord1 with { Descricao = "Curso Novo" };
            Console.WriteLine(cursoTesteRecord1.Descricao);
            Console.WriteLine(cursoTesteRecord2.Descricao);

        }

        public static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificarCliente(); //instanciando classe NotificarCliente
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();


            //var notificacao = new Cadastro.INotificacao(); Instanciar diretamente a interface não é possivel

            //Mas é possivel atribuir uma instancia para nossa interface, como feito abaixo, pois estamos atribuindo
            //um objeto para uma interface, criamos uma instância da interface que está sendo atribuido através de 
            //outro objeto que está sendo criado
            Cadastro.INotificacao notificacao = new Cadastro.NotificarFuncionario();
            notificacao.Notificar();
            //notificacao.NotificarOutros(); este caso já não é possivel pois ele vai obedecer o que está definido 
            //dentro do contrato, só fica visivel o que está dentro de fato no contrato.

            //Concluindo..
            //utilizamos as interfaces como espécie de contrato forte forçando com que as classes que herdam essa
            //interface sejam obrigadas a implementar um código, é uma forma de organizar o processo de 
            //desenvolvimento e utilização do nosso código melhorando segurança, fazendo com que parte dos nossos
            //códigos sigam um determinado padrão/contrato definido por nós.
        }

        //AULAS MÓDULO 9 CONVERSORES DE VALOR
        public static void AulaConvertParse()
        {
            var conversor = new Conversores.Conversor();
            conversor.ConvertAndParse();
        }

        public static void AulaTryParse()
        {
            var conversor = new Conversores.Conversor();
            conversor.ConversorTryParse();
        }

        //AULAS MÓDULO 10 TRABALHANDO COM STRINGS
        public static void AulaToLower()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.ConverterParaLetrasMinusculas();
        }

        public static void AulaToUpper()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.ConverterParaLetrasMaiusculas();
        }

        public static void AulaSubstring()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoSubstring();
        }

        public static void AulaRange()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoRange();
        }

        public static void AulaContains()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoContains();
        }

        public static void AulaTrim()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoTrim();
        }

        public static void AulaStartsAndEndsWith()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoStartsAndEndsWith();
        }

        public static void AulaReplace()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoReplace();
        }

        public static void AulaLenght()
        {
            var trabComStrings = new Modulo10.TrabComStrings();
            trabComStrings.UsandoLenght();
        }

        //AULAS MÓDULO 11 TRABALHANDO COM DATAS

        public static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutosSegundos();
            //trabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }


        //AULAS MÓDULO 12 TRABALHANDO COM EXCEÇÕES

        private static void TrabalhandoComExcecoes()
        {
            var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
            //trabalhandoComExcecoes.AulaGerandoException();
            trabalhandoComExcecoes.AulaTratandoException();
        }


        //AULAS MÓDULO 13 TRABALHANDO COM ARQUIVOS
        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            //trabalhandoComArquivos.AulaCriandoArquivo();
            //trabalhandoComArquivos.AulaLendoArquivo();
            trabalhandoComArquivos.AulaExcluindoArquivo();
        }

        //AULAS MÓDULO 14 TRABALHANDO COM LINQ (Consulta integrada a linguagem)
        private static void TrabalhandoComLinq()
        {
            var linq = new Modulo14.TrabalhandoComLinq();
            //linq.AulaWhere();
            //linq.AulaOrdenacao();
            //linq.AulaTake();
            //linq.AulaCount();
            linq.AulaFirstEFirstOrDefault();
        }
        
    }
}