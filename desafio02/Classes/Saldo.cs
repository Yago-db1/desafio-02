namespace desafio02.Classes;

public class Saldo
{
    public decimal Valor { get; set; }

    public Saldo(decimal valor)
    {
        ValidarSaldo(valor);
        Valor = valor;
    }

    private static void ValidarSaldo(decimal saldo)
    {
        if (saldo < 0)
            throw new ArgumentException("Saldo inicial não pode ser negativo.");
    }
}