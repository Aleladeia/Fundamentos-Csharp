using System.Runtime.CompilerServices;

namespace Modulo10
{
    public class TrabComStrings
    {

        public void ConverterParaLetrasMinusculas()
        {
            Console.Write("Por favor digite algo: ");
            var linha = Console.ReadLine(); //metodo ReadLine para entradada de dados, pela ação do usuário.
            Console.WriteLine(linha?.ToLower()); // Metodo ToLower converte toda letra maiuscula para minuscula.
        }

        public void ConverterParaLetrasMaiusculas()
        {
            Console.Write("Por favor digite algo: ");
            var linha = Console.ReadLine(); 
            Console.WriteLine(linha?.ToUpper()); // Metodo ToUpper converte toda letra minuscula para maiuscula.
        }

        public void UsandoSubstring()
        {
            Console.Write("Por favor digite algo: ");
            var linha = Console.ReadLine(); 
            Console.WriteLine(linha?.Substring(0,6)); //pega a string a partir da posição 0 até a posição 6
            Console.WriteLine(linha?.Substring(6,5)); //pega da posição 6 os próximos 5 caracteres
            Console.WriteLine(linha?.Substring(6)); //pega o restante da string de acordo com posição informada
        }

        public void UsandoRange()
        {
            //para usar o range basta atribuir à variavel o operador [..N], [^N..], [N..^N] ou [..^N]
            var nomeArquivo = "2024_02_27_backup.bak";
            string ano = nomeArquivo[..4]; //pegando os primeiros 4 caracteres [..N]
            Console.WriteLine(ano);

            var extensao = nomeArquivo[^3..]; //pegando os ultimos 3 caracteres [^N..]
            Console.WriteLine(extensao);

            string nome = nomeArquivo[11..^4];//pega os caracteres a partir da posição 11 e ignora os ultimos 4 [N..^N]
            Console.WriteLine(nome);

            string apenasNome = nomeArquivo[..^4]; // pega toda string e ignora os ultimos 4 caracteres [..^N]
            Console.WriteLine(apenasNome);
        }

        public void UsandoContains()
        {
            //metodo Contains retorna true ou false, então ele procura a palavra especificada no metodo em nossa
            //var nomeArquivo, se encontrada retorna true se não false com isso podemos usalá em uma estrutura 
            //condicional (if, else) 
            string nomeArquivo = "2024_02_27_backup.bak";
            //Console.WriteLine("Contem nome:" + nomeArquivo.Contains("backup"));

            if(nomeArquivo.Contains("backup_teste"))
            {
                Console.WriteLine("Palavra Encontrada");
            }
            else
            {
                Console.WriteLine("Palavra não Encontrada");
            }
        }

        public void UsandoTrim()
        {   //Metodo trim remove caracteres, trechos de strings, sendo eles os metodos, Trim, TrimStart e TrimEnd
            string teste = "**ALEXANDRE JOSE**";
            string teste2 = "        ALEXANDRE JOSE            ";

            Console.WriteLine("Em branco: " + teste2.Trim()); //remove espaços em branco
            Console.WriteLine("Total: " + teste.Trim('*')); //remove todos os * presentes na string
            Console.WriteLine("Inicio: " + teste.TrimStart('*')); //remove apenas os * do inicio da string
            Console.WriteLine("Fim: " + teste.TrimEnd('*')); //remove apenas os * do fim da string
        }

        public void UsandoStartsAndEndsWith()
        {   //Metodos StartsWith e EndsWith, verifica se a nossa variavel começa ou termina com palavra X de acordo
            //com a nossa string disponibilizada, devolve valores true ou false.

            string teste = "Curso Csharp";

            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            Console.WriteLine("FIM: " + teste.EndsWith("Csharp02"));

        }

        public void UsandoReplace()
        {   //Metodo Replace substitiu uma palavra ou frase de uma string por outra informada no metodo
            string teste = "Curso Csharp";
            Console.WriteLine(teste);
            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }

        public void UsandoLenght()
        {   //Metodo Lenght usado para saber quantidade de caracteres de uma string.
            string? teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine(teste?.Length);
        }

    }
}