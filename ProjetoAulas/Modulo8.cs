//namespace Cadastro; <= forma moderna de definir namespace

using System.Data.Common;

namespace Cadastro //forma classica, definindo namespace
{

    // =========== O QUE É UMA CLASSE  =============================================================================

    //Criando uma nova classe estática, a diferença da classe estatica para a normal é que ná estatica, não 
    //precisamos fazer a instanciação dela para usala, podemos chamalá diretamente.
    public static class Calculos
    {
        //O metódo ou função também precisa ser estatico para ser usado sem a instancia da classe que é statica
        public static int CalculaValor(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto // criando nova classe
    {
        // propriedade privada Id, impede que modifiquemos ela diretamente, só podemos trabalhar com ela 
        // atravé de métodos como os criados abaixo, SetId e GetId.
        private int Id;
        public string? Descricao { get; set; } //criando uma propriedade da classe Produto

        // =========== PROPRIEDADE SOMENTE LEITURA (READONLY)  =======================================================
        public int Estoque { get; } //propriedade de somente leitura (readonly)
        //public readonly int Estoque; outra forma de declarar propriedade de somente leitura

        /*
        Para acessar uma propriedade Readonly só é possivel através do construtor da classe.
        Contrutor de uma classe é uma ação executada no momento que uma classe está sendo instanciada
        através deste construtor temos acesso a atributos e memebros da minha classe ou de outras classes
        criando construtor => public nomeDaClasse(pode ter parametros ou não){bloco de código a ser executado}
         */
        public Produto() //isso é um construtor da classe
        {
            Estoque = 1;
        }

        //Metodo do tipo void da classe produto, o tipo void não retorna nada, apenas executa o bloco de código
        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id) //Metodo que permite atribuir valor a prop privada Id
        {
            Id = id;
        }

        public int GetId() //Metodo que permite recuperar o valor da prop privada Id
        {
            return Id;
        }
    }

    // =========== HERANÇA ========================================================================================

    public class Pessoa //Criando nova classe Pessoa para aula de Herança, seria a super classe ou classe pai
    {
        public int Id { get; set; } // propriedades de uma pessoa abaixo
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }

        public void ImprimirDados() // Método para impressão dos dados da pessoa
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa //Criando classe PessoaFisica que herda de Pessoa, simbolo de herança é o :
    {                                  //Subclasse da classe pai Pessoa
        public string? CPF { get; set; } //Propriedade exclusiva de pessoa fisica é o cpf, enquanto não for 
                                         //herdado por nenhuma outra classe, pessoa juridica seria CNPJ
        public void ImprimirCPF() //Metodo para imprimir o CPF
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica //Subclasse funcionário herdando da Subclasse PessoaFisica que também
    {                                       //herda caracteristicas Pessoa
        public string? Matricula { get; set; } //prop exclusiva de funcionário
    }

    // =========== CLASSE SELADA  ========================================================================================

    //Abaixo exemplo de classe selada, usamos a keyword sealed como está abaixo, a diferença da classe selada
    //para uma classe normal é que a selada, não pode ser herdada por outra classe por exemplo se em Funcionario
    //fosse Funcionario : Configuracao não funcionaria, porém a classe selada pode ser instanciada em qualquer
    //lugar do projeto e utilizar as implementações presentes nela;
    public sealed class Configuracao
    {
        public string? Host { get; set; }
    }

    // =========== CLASSE ABSTRATA / ABSTRAÇÃO  ==================================================================

    //Abaixo exemplo de classe abstrata, a classe abstrata não pode ser instanciada, no caso não podemos utilizar
    //O modificador new para instanciar uma classe abstrata, elas tem o unico proposito de servirem como 
    //superclasses para outras classes no c#, uma espécie de contrato forçando que as subclasses implementem de 
    //forma concreta o que é definido na classe abstrata. Vantagem: aumentar capacidade de reutilização de código

    //A abstração pode ser atingida de 2 formas, através das classes abstratas ou através de interfaces.
    //Interfaces não foi visto ainda

    public abstract class Animal //com esse modificador abstract a classe se torna uma classe incompleta
    {                            //forçando as subclasses a implementar de forma concreta o que é definido nela
        public string? Nome { get; set; }

        public abstract string GetInformacoes(); //no metodo criado usamos a palavra abstract que vai obrigar a
                                                 //sub classe que herdar de animal a implementar o metodo que está
                                                 //incompleto
        public virtual void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }

    public class Cachorro : Animal //nova classe herdando da classe abstrata animal
    {
        public override string GetInformacoes() // como herdamos a classe animal a mesma nos obriga a implementar
        {                                       // o método abstrato GetInformacoes da mesma, que está incompleto 
            return "O Cachorro é um bom amigo"; // porém temos de sobreescrevelo com o modificador override
                                                // senão erro será acusado
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Metodo chamado dentro da classe cachorro");
        }
    }

    // =========== RECORD  ======================================================================================== //
    // Abaixo exemplo do tipo de classe Record, ela é bem semelhante a classe normal porém resolve alguns           //
    // problemas                                                                                                    //
    // =================================== PROBLEMA 1 E RESOLUÇÃO ================================================= //
    public class Curso //Exemplo sem RECORD
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }

        public override bool Equals(object? obj) //sobrescrevendo metodo equals
        {
            // verificando se a variavel obj do tipo object está vindo nulo, se sim retorna false
            if (obj == null) return false;

            //aqui verificamos se o que está vindo no metodo equals é do mesmo tipo de Curso, caso for ja criou 
            //uma instancia/var curso para usarmos para verificar se o valor do obj passado como parametro no caso
            //curso2, onde verificamos se o Id e Descricao disponivel dentro da nossa classe é igual ao que está 
            //disponivel dentro da variavel curso criada abaixo "Curso curso"
            if (obj is Curso curso)
            {
                //verificando se o Id e Descricao disponivel dentro da nossa classe é igual ao que está 
                //disponivel dentro da instancia/var acima
                return Id == curso.Id && Descricao == curso.Descricao;

                //aqui ja temos um problema, pois se forem varias propriedades temos que fazer isso prop por prop
                //onde vai ser utilizado mais recurso e tempo, mas neste pequeno exemplo ele verifica de fato se
                //os valores contidos nas instancias são iguais.
            }

            return base.Equals(obj);
        }

        public static bool operator ==(Curso a, Curso b) //Alterando comportamento do operador == para usar o 
        {                                                // metodo equals que sobrescrevemos
            return a.Equals(b);
        }

        public static bool operator !=(Curso a, Curso b) //Alterando comportamento do operador !=
        {
            return !(a.Equals(b));
        }
    }

    //Exemplo com objeto do tipo RECORD
    //Ao invés do uso da class padrão, apenas com o código abaixo e executando nosso código com 
    //a comparação Console.WriteLine(cursoRecord1 == cursoRecord2); em nossa Program.cs ja retorna true e não
    //precisamos usar todo o código anterior que sobrescreve o metódo equals e operadores == e !=

    //Isso acontece pois no momento que executamos a aplicação e passamos pela compilação o compilador verifica
    //o tipo do objeto e implementa alguns métodos automaticamente para o tipo Record.
    /* 
    public record CursoRecord 
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }
    */

    //Exemplo usando dados imutaveis, conseguimos fazer tudo isso em 1 unica linha como está feito com a 
    //semantica abaixo onde passamos parametros que ao compilar são vistos como propriedades.
    //Ao instanciarmos, com o Record desta forma abaixo, não é possivel alterar os valores, eles são somente 
    //leitura, são instanciados no momento da criação do objeto.
    public record CursoRecord(int Id, string Descricao);
    

    // =================================== PROBLEMA 2 ============================================================= //
    // Exemplo para o problema de caso queira copiar os valores de todas propriedades de uma instancia já existente //
    // para outra de mesma classe                                                                                   //
    // ============================================================================================================ //

    public class CursoTeste //Exemplo sem RECORD
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }

    public record CursoTesteRecord(int Id, string Descricao); //Exemplo com RECORD


    // =========== INTERFACE  ======================================================================================== //
    // Abaixo temos um novo tipo, agora trabalharemos a interface que diferente do tipo class, a interface implementa
    // uma espécie de contrato, onde as classes que herdam de uma interface são obrigadas a implementar suas props e
    // metódos que estão definidos dentro da interface, como no exemplo abaixo

    //por padrão na criação de uma nova interface colocase o I junto do nome "INome" por exemplo
    public interface INotificacao
    {
        //Aqui dentro percebesse que não escrevemos nenhum código para execução dentro do método, isso porque
        // na interface apenas definimos a assinatura da interface.
        public string Descricao { get; set; }

        void Notificar();
    }

    //Aqui na criação da nova classe, esta herdando a nossa interface, com isso somos obrigado a implementar as 
    //operações que temos dentro da nossa interface, no caso a prop Descricao e o método Notificar que aqui na   
    //classe precisa ser concreto
    public class NotificarCliente : INotificacao
    {
        public string? Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }

    public class NotificarFuncionario : INotificacao
    {
        public string? Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionario");
        }

        //Criando mais um método que não existe dentro da interface para mostrar que na instancia da class 
        //NotificarFuncionario é possivel utilizar os 2 métodos, porém da outra forma onde atribuimos uma instancia
        //para nossa interface não pois o método não existe na interface
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }
}