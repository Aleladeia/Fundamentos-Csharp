using Cadastro;

namespace Modulo11
{
    public class TrabComDatas
    {
        public void AulaDateTime()
        {   
            //Declarando novo objeto do tipo date time, passando ano, mês, dia, hora minuto e segundo
            var date1 = new DateTime(2024, 03, 05, 11, 36, 20);

            //Convertendo string para o tipo DateTime, porém a string tem um formato correto para funcionar que é
            //"ano/mes/dia hora:minuto:segundo"
            var date2 = DateTime.Parse("2024/03/05 19:37:20");

            //pegando a data e hora atual com DateTime.now
            var date3 = DateTime.Now;

            //Pegando apenas data atual, as horas vem zeradas com o DateTime.Today
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            //formatando data para formato americano
            Console.WriteLine(date1.ToString("MM-dd-yyyy HH:mm:ss"));

            //Utilizando o tipo DateTimeOffset que representa data e hora porém junto com o deslocamento
            // que utilizamos para indicar o que difere do valor UTC, então ao trabalharmos com datas UTC
            //podemos usar este tipo DateTimeOffset

            // para construir ele utilizando o construtor do objeto precisamos passar uma data especifica
            // pode ser alguma variavel com a data ou o DateTimeNow
            var dateOffSet1 = new DateTimeOffset(DateTime.Now); 

            //neste outro exemplo, informamos o deslocamento que vai ser usado como indicador das coordenadas do
            //UTC para isso usamos o new TimeSpan(informamos o horário, minutos, segundos), no caso do Brasil a
            // hora é com -3
            var dateOffSet2 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));

            Console.WriteLine(dateOffSet1); // ao imprimir mostra o nosso utc junto do horário.
            Console.WriteLine(dateOffSet2.LocalDateTime); // pega a hora local
            Console.WriteLine(dateOffSet2.UtcDateTime); // pega a hora mas aplica o deslocamento ajudando a trabalhar
                                                        // com datas no formato Utc

           // Propriedades disponiveis no DateTimeOffset, Now e UtcNow
           // DateTimeOffset.Now 
           // DateTimeOffset.UtcNow ja nos devolvem o horário no formato utc
        }

        public void AulaSubtraindoDatas()
        {
            var data1 = DateTime.Now;
            var data2 = DateTime.Parse("2024-01-06");

            var diff = data1 - data2; //fazendo subtração das datas

            //com o metodo TotalDays pegamos a diferença do nosso calculo em quantidade de dias, retorna um valor
            //double
            Console.WriteLine("total de dias: " + diff.TotalDays);
            //funciona como o TotalDays porém a diferença é retornada em horas
            Console.WriteLine("total de horas: " + diff.TotalHours);
            //Para não pegar a parte decimal do resultado podemos usar o casting int e pegar apenas o valor inteiro
            Console.WriteLine("total de dias com uso do casting int: " + (int)diff.TotalDays);

            var dif = data1.Subtract(data2); // outra forma de fazer a subtração de datas
            Console.WriteLine("Subtraindo com subtract: " + dif);
        }

        public void AulaAdicionandoDiasMesAno()
        {
            var date1 = DateTime.Now;

            //caso a data esteja em formato americano e quisermos formatar podemos usar o ToString após o metodos
            //date1.AddDays().ToString("dd-MM-yyyy HH:mm:ss") no meu caso o formato ja vem correto pois meu OS
            //está em português. 
            Console.WriteLine(date1.AddDays(3)); //adiciona dias
            Console.WriteLine(date1.AddMonths(1)); // adiciona meses
            Console.WriteLine(date1.AddYears(2)); // adiciona anos
            //além das opções usadas acima, temos como adicionar horas, minutos, segundos, milesimos e etc.
        }

        public void AulaAdicionandoHoraMinutosSegundos()
        {
            var date1 = DateTime.Now;

            //caso a hota esteja em formato americano e quisermos formatar podemos usar o ToString após o metodos
            //date1.AddDays().ToString("HH:mm:ss") no meu caso o formato ja vem correto pois meu OS
            //está em português. 
            Console.WriteLine(date1);
            Console.WriteLine(date1.AddHours(1)); //adiciona horas
            Console.WriteLine(date1.AddMinutes(10)); // adiciona minutos
            Console.WriteLine(date1.AddSeconds(10)); // adiciona segundos
        }

        public void AulaDiaDaSemana()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.DayOfWeek); //Exibe o dia da semana.
        }

        public void AulaDateOnly()
        {   //O tipo DateOnly nos permite trabalhar apenas com datas, não incluindo as horas, além disso podemos
            //usar os metodos de extensão, AddDays, AddMonth e etc, podemos também formatar com o Método ToString.

            //var date1 = new DateOnly(2022, 12,2); utilizando construtor de DateOnly
            var dateOnly1 = DateOnly.Parse("2024-03-06");

            Console.WriteLine(dateOnly1);
            //Console.WriteLine(dateOnly1.ToString("dd-MM-yyyy")); formatando retorno da data, se incluirmos a 
            //formatação das horas, retornará uma exception.
        }

        public void AulaTimeOnly()
        {   //Assim como o DateOnly, permite trabalhar apenas com data, este trabalha apenas com horas

            //var date1 = new TimeOnly(12,23,25,0); utilizando construtor de TimeOnly
            var timeOnly1 = TimeOnly.Parse("23:01:23");

            Console.WriteLine(timeOnly1);
            //Console.WriteLine(timeOnly1.ToString("HH-mm-ss")); formatando retorno da data, se incluirmos a
            //formatação da data, retornará uma exception.
        }
    }
}

