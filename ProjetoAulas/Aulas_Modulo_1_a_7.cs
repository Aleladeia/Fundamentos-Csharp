/* Console.WriteLine("First Program"); <= Top-Level-Statement*/

// #############################################################################################################
/*
--- TRABALHANDO COM VARIAVEIS ---

int idade = 25;
Console.WriteLine(idade);
string nomePessoa = "Alexandre José";
Console.WriteLine(nomePessoa);
decimal valor = 200.99m;
double valorDouble = 200.99;
float valorFloat = 200.99f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);

var idadeNova = 26;
Console.WriteLine(idadeNova);
char flag = 'Y';
Console.WriteLine(flag);
bool ativo = true;
ativo = false;
Console.WriteLine(ativo);
*/

// #############################################################################################################

/* 
--- O QUE É UMA CONSTANTE --- 

// Isso é uma constante
const string descricao = "Curso CSHARP";
//descricao = "Curso"; não é possivel alterar o valor de uma constante.
Console.WriteLine(descricao);
*/

// #############################################################################################################

/* 
--- COMENTARIOS ---

Comentário simples

/* 
    este é um 
    exemplo de
    Comentário
    Multiline

*/

// #############################################################################################################

/* 
--- OPERADORES ARITMETICOS ---

var soma = 1 + 2;
Console.WriteLine(soma);

int numero1 = 2;
var numero2 = 3;

int somando = numero1 + numero2;
Console.WriteLine(somando);

int subtraindo = numero2 - numero1;
Console.WriteLine(subtraindo);

int multiplicando = (numero2 * numero1) * 10;
Console.WriteLine(multiplicando);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);
*/

// #############################################################################################################

/* 
--- OPERADORES RELACIONAIS ---

bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);
*/

// #############################################################################################################

/* 
--- OPERADORES LÓGICOS ---

int numero1 = 2;
var numero2 = 3;

//para o && (e, AND) ambas comparações precisam ser verdadeiras para retornar true
bool valido = numero2 > numero1 && 8 > 7;
Console.WriteLine(valido);

//para o || (ou, OR) apenas 1 das comparações precisam ser verdadeiras para retornar true
bool valido2 = numero2 > numero1 || 6 > 7;
Console.WriteLine(valido2);

//para o ! (não, NOT) ele nega o resultado da comparação, se for true retorna false e se for false retorna true
bool valido3 = !(numero2 > 10);
Console.WriteLine(valido3);
*/

// #############################################################################################################

/* 
--- OPERADOR TERNÁRIO ---

bool ativo = true;

string status = ativo == true ? "Cadastro Ativo" : "Cadastro Inativo";
System.Console.WriteLine(status);
*/

// #############################################################################################################

/*
// --- CRIANDO AS PRIMEIRAS FUNÇÕES ---

Console.WriteLine("Você não está em nenhuma função ainda L115\n");

EscreverNome(); // chamada de função

// Funções do tipo void não precisam do return, elas são como o nome diz vazias, não retornam nada.
void EscreverNome()
{   
    Console.WriteLine("Você entrou na função EscreverNome L122\n");

    var nome = NomeCompleto(); // chamada de função

    Console.WriteLine("Você voltou para a função EscreverNome L126\n");

    var soma = SomaValores(); // chamada de função

    Console.WriteLine("Você voltou para a função EscreverNome L130\n");

    Console.WriteLine(nome);
    Console.WriteLine(soma);
}

// Para criar uma função primeiro passamos o tipo desta função e seu retorno, neste caso foi string
// depois o nome da função e o parenteses seguido de chave, string nomeFuncao(){}, dentro do escopo da função
// que são as chaves, escrevemos o que queremos que a função faça e o que ela vai retornar após sua execução.
string NomeCompleto()
{
    string primeiroNome = "Alexandre";
    string segundoNome = "José";

    Console.WriteLine("Agora você entrou na função NomeCompleto L144\n");

    return primeiroNome + " " + segundoNome;
}

// Neste outro exemplo a função é do tipo int pois queremos retornar uma soma de numeros inteiros
// As funções são executadas apenas quando são chamadas
int SomaValores()
{
    Console.WriteLine("Agora você entrou na função SomaValores L153\n");

    return 8 + 10;
} 
*/

// #############################################################################################################

/*
// --- Funções com Parâmetros ---

// no momento em que chamamos as funções que criamos passamos a elas dentro dos parenteses os valores de
// cada parametro de acordo com o que a função espera receber.
var soma = SomaValor(3, 5);
Console.WriteLine(soma);

string nome = NomeEIdade("Alexandre José", 25);
 Console.WriteLine(nome);

// na criação de funções com parametros o que muda é que dentro dos parenteses adicionamos o tipo
// do parâmetro, é como a criação de uma variavel, como temos abaixo (int a, int b)
int SomaValor(int a, int b)
{
    return a + b;
}

//O mesmo acontece neste outro exemplo, porém tivemos uma variação nos tipos de parâmetro, foi passado
//um do tipo string e outro do tipo int
string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}
*/

// #############################################################################################################

/*
// --- ESTRUTURA DE DADOS (COLEÇÕES) ---

// ==== ARRAYLIST ====

using System.Collections; //using(import) necessário para o uso do array list pois vem das collections

//instanciando novo arraylist
var arrayList = new ArrayList();

arrayList.Add(1); // adicionando itens ao arraylist
arrayList.Add("Xandy");
arrayList.Add(true);

Console.WriteLine(arrayList[0]); // escrevendo o valor do que está armazenado no indice 0 do array list

arrayList.RemoveAt(0); //removendo item do array list

//como zerar o arrayList? Tem duas formas.
//arrayList = new ArrayList(); // instanciando um novo ArrayList.
arrayList.Clear(); // usando a função clear para remover todos os itens do arraylist

foreach(var item in arrayList) // percorrendo arraylist com foreach
{
    Console.WriteLine(item);
}
*/

// #############################################################################################################

/*
// ==== ARRAY TIPADO ====

//instanciando array tipado do tipo int, definindo seu tamanho e instanciando os valores de cada indice.
//var arrayTipadoNumero = new int[3] {1, 2, 3}; 

//instanciando array tipado do tipo int e definindo seu tamanho.
var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] = 3; //atribuindo valor a cada indice
arrayTipadoNumero[1] = 6;
arrayTipadoNumero[2] = 9;

//arrayTipadoNumero[10] = 12; //tentativa de adicionar valor a indice inexistente. 
//Retorna erro como esperado

//para modificar o tamanho do nosso array utilizamos o código abaixo
Array.Resize(ref arrayTipadoNumero, 8);
arrayTipadoNumero[7] = 12;

foreach(var item in arrayTipadoNumero) 
{
    Console.WriteLine(item);
}

//Outro Exemplo do tipo string agora
var arrayTipadoString = new string[2];

arrayTipadoString[0] = "Alexandre";
arrayTipadoString[1] = "José";

foreach(var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
*/

// #############################################################################################################

/*
// ==== LISTA GENÉRICA ==== 
// parecida com array list, porém a lista é bem mais performatica, recomendada pela microsoft, 
// e nela vc é obrigado a informar o tipo de dado que queremos alocar na lista.

//Instanciando uma lista genérica do tipo string, com tamanho 10, tudo que for genérico no 
//dotnet colocamos entre <> como no exemplo abaixo
var lista = new List<string>(10)
{
    //adicionando itens a lista
    "Zagueiro",
    "Goleiro",
    "Atacante"
};
    // esta estrutura é muito usada por desenvolvedores .net

lista.Add("Alexandre"); //outra forma de adicionar itens a lista 
lista.Add("José");
lista.Add("Ladeia");
lista.Add("Cadamuro");

var nome = lista[6];
Console.WriteLine(nome);

lista.RemoveAt(0); // removendo item da lista.

foreach(var item in lista)
{
    Console.WriteLine(item);
}
*/

// #############################################################################################################

/*
// ==== DICIONÁRIO ====
//estrutura que recebe 2 parametros, chave e valor, não permite também duplicidade de chave.

// No dicionario passamos os parametros entre as <> o primeiro representa o TIPO DA CHAVE e o segundo
// o TIPO DO VALOR que será armazenado, então a chave pode ser do tipo string, int, float, como os valores
// que também podem ser, int, double, float, string, bool e etc... exemplo Dictionary<string, double>();
var dicionario = new Dictionary<int, string>()
{
   {5, "Macaco Manso"}, //Adicionando itens ao dicionario
   {7, "Ganso Manco"},
};

dicionario.Add(2, "Hortifruit"); // outra forma de adicionar itens
dicionario.Add(4, "Bangaladesh");

dicionario[1] = "Sonserina"; // outra forma de adicionar itens
dicionario[3] = "Gota de limão";
dicionario[6] = "Beligool";

var animal = dicionario[7];
Console.WriteLine(animal);

dicionario.Remove(7); // removendo item do dicionário

foreach(var item in dicionario)
{
   //Console.WriteLine(item.Key); com o Key escrevemos as chaves, no caso vão vir de 1 a 7 na ordem adicionada
   Console.WriteLine(item.Value);// com o Value escrevemos os valores armazenados nas chaves, na ordem adicionada
}
*/

// #############################################################################################################

/*
// ==== QUEUE (FILA) USA LOGICA DE ARMAZENAMENTO FIFO ====

// A Queue é uma estrutura que utiliza o conceito de FIFO (First in and first out), ela funciona diferente das
// estruturas anteriores, não adicionasmos com .Add, mas sim o Enqueue, e para remover não é com .Remove, mas sim
// com o Dequeue, empilhar e desempilhar(pode ser enfileirar também). para acessarmos o valor da queue utilizamos
// o .Peek() porém seguindo o conceito de FIFO ele pega apenas o primeiro a sair.
// Para instanciala é parecido com as outras estruturas, 
// exemplo => var fila = new Queue() que permite inserir qualquer tipo de dado na fila, ou com a
// classe generica new Queue<>() especificando o tipo de dado que vai ser armazenado;

var queue = new Queue<string>();

queue.Enqueue("Brigadeiro"); //adicionando item a fila
queue.Enqueue("Asalamaleico");

var palavra = queue.Peek(); //pegando item da fila porém sempre o primeiro a sair seguindo conceito de FIFO
var palavra1 = queue.Peek(); // aqui como não fizemos dequeue a palavra brigadeiro foi para as 2 variaveis
Console.WriteLine(palavra); // Neste caso por exemplo no console será exibido a palavra Brigadeiro 2x.
Console.WriteLine(palavra1);

// com o dequeue significa que estamos acessando o dado e removendo ele de minha coleção
palavra = queue.Dequeue(); // Aqui estamos atribuindo o valor da queue a variavel e removendo 1 item da   
                           // fila seguindo o conceito do FIFO, a palavra removida é Brigadeiro.
palavra1 = queue.Dequeue();// agora a palavra removida foi Asalamaleico e atribuida a variavel palavra1
Console.WriteLine(palavra1);

foreach (var item in queue)
{
    Console.WriteLine(item);
}
*/

// #############################################################################################################

/* 
// ==== STACK (PILHA) USA LOGICA DE ARMAZENAMENTO LIFO ====
// A Stack é uma estrutura que utiliza o conceito de LIFO (Last in and first out), segue também o mesmo
// conceito de lista genêrica e arrayList, podemos declara-la das duas formas, 
// Exemplo => var pilha = new Stack() ou new Stack<>() utilizando classe generica.
// no lugar de Enqueue usamos o Push e no lugar do Dequeue usamos o Pop, o Peek é o mesmo pra ambos queue e stack

var stack = new Stack<string>();
stack.Push("Formigo"); //adicionando item a pilha
stack.Push("Pandolo");

var peek = stack.Peek(); //pegando item da Pilha porém sempre o ultimo a entrar e primeiro a sair
                         // seguindo conceito de LIFO

foreach(var item in stack)
{
    Console.WriteLine(item);
}

// com o pop significa que estamos acessando o dado e removendo ele de minha coleção, isso não acontece 
// na lista/arraylist
var nome = stack.Pop(); // Atribuindo valor do item da pilha a variavel nome e removendo na sequência.
var nome1 = stack.Pop();

Console.WriteLine(nome);
Console.WriteLine(nome1);
*/

// #############################################################################################################

// --- Estrutura de controle ---

/* 
// ==== IF/ELSE IF/ ELSE ====

var diaDaSemana = 1; 
var diaDeTrabalho = true;

//Sem anotações pois ja conhecemos bem a estrutura.
if(diaDaSemana == 0 && diaDeTrabalho)
{
    Console.WriteLine("Hoje é Domingoooo");
}
else if (diaDaSemana == 0 && diaDeTrabalho == false)
{
    Console.WriteLine("Hoje é Domingo, mas não é dia de trabalho");
}
else
{
    Console.WriteLine("Hoje não é domingo");
}
*/

// #############################################################################################################

/* 
// ==== SWITCH ====

var diaDaSemana = 2;
switch(diaDaSemana) // switch(variavel observada)
{
    case 0: // condição, caso variavel observada seja 0
    {   // podemos declarar o case com ou sem {}
        //execução da condição
        Console.WriteLine("Hoje é domingo"); 
        break;
    } 
    case 1: // condição, caso variavel observada seja 1 e assim por diante
        Console.WriteLine("Hoje é segunda");
        break;
    case 2: 
        Console.WriteLine("Hoje é terça");
        break;
    case 3: 
        Console.WriteLine("Hoje é quarta");
        break;
    case 4: 
        Console.WriteLine("Hoje é quinta");
        break;
    case 5: 
        Console.WriteLine("Hoje é sexta");
        break;
    case 6: 
        Console.WriteLine("Hoje é sabado");
        break;
    default: // Valor definido como padrão caso nenhuma condição seja atendida/verdadeira
        Console.WriteLine("Dia invalido");
        break;
}

var diaDeSemana = 0;
switch(diaDaSemana < 1) // switch com condição boleana (true ou false) porem neste caso seria melhor usar
                        // a estrutura do if / else para deixar o código mais simples, pois não avaliamos mais 
                        // nada além de true ou false
{
    case true:
        Console.WriteLine("Hoje é dia de doido meu");
        break;
    case false:
        Console.WriteLine("Hoje é dia de mentira meu");
        break;
}
*/

// #############################################################################################################

/* 
// ==== FOR (laço de repetição / loop) ====

var lista = new List<string>(){"Lexeba", "Miguelito", "Porpetone"};

// Estrutura do for, exemplo 
// for(Inicio; condição; incremento) {código a ser executado até a condição ser falsa}
for(int i = 0; i < lista.Count(); i++)
{
    Console.WriteLine(lista[i]);
}
*/

// #############################################################################################################

/* 

// ==== FOREACH ====

// O foreach pode ser utilizado para fazer iteração sobre qualquer tipo de coleção inclusive cadeia de caracteres
var lista = new List<string>(){"Lexeba", "Miguelito", "Porpetone"};

// estrutura do foreach => foreach(Variavel para itereção in coleção) pode ser informado
// tanto o var como já o tipo que queremos receber como definido na lista com List<string>
// exemplo foreach(var item in lista) ou foreach(string item in lista)

foreach(string item in lista)
{
    Console.WriteLine(item);
}

// a diferença entre o For e o Foreach é que o foreach não tem a necessidade de passar o indice da lista
// que queremos acessar, pois ao fazer a iteração com a lista ja recebo o valor corrente daquela iteração

foreach(var letra in "Rapidamente") //foreach é capaz de percorrer uma cadeia de caracteres
{
    Console.WriteLine(letra);
}
*/

// #############################################################################################################

/* 
// ==== WHILE / DO WHILE (laço de repetição/ loop) ====

// Diferente do while o do while
// Executa primeiro seu bloco de código para depois verificar a condição se é verdadeira ou não, então
// o uso de um ou outro depende da situação, se necessário validar uma condição antes, usar o while.
// Senão você pode usar o do while, exemplo abaixo

//Estrutura While => while(condição){ enquanto verdadeiro executa o bloco de código}

var i = 4;
while(i < 3)
{
    Console.WriteLine("var i = " + i);
    i++;
}

// Estrutura Do While => do { executa bloco de código} while(condição)

var j = 4;
do
{
    Console.WriteLine("var j = " + j);
    j++;

} while(j < 3);

*/

// #############################################################################################################

/* 
// ==== BREAK/CONTINUE ====

var i = 0;
while(i < 5)
{

    if(i < 2)
    {
        Console.WriteLine("Continuando........");
        //i++;
        continue;
        //A palavra reservada continue, ignora o restante do código fora do If e faz com que volte para o inicio
        // do while, neste caso entrariamos em loop infinito pois o valor de i sempre seria 0, porém se adicionar
        // o incremento da variavel i como está na linha 572, no momento que i valesse 2 ele daria continuidade
        // na execução do while seguindo pra linha 580 em diante porem sem entrar no if(i == 2) pois ele é
        // incrementado novamente na linha 582, passando a valer 3, então não entraria no outro if resultando no 
        // console => continuando.... Continuando.... var i = 2 var i = 3 var i = 4
    }

    Console.WriteLine("var i = " + i);
    i++;

    if(i == 2)
    {
        Console.WriteLine("Valor de i é igual a 2 (dois)");
        break; 
        // A palavra reservada break finaliza a execução do loop mesmo que este não tenha chegado a condição
        // em que i é 5 ou maior que 5
    }
}
*/