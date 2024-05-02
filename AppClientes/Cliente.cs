namespace Cadastro
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateOnly DataNascimento { get; set; } //suporta apenas data
        public DateTime CadastradoEm { get; set; } // suporta data e hora
        public decimal Desconto { get; set; }

    }
}