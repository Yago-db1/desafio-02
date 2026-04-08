namespace desafio02.Metodos;

public static class Metodos
{
    public static void ValidarNumeroMaiorQueZero(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor deve ser maior que zero.");
    }
    
    public static void ValidarSaldoSuficiente(decimal saldo, decimal valorSaque)
    {
        if (valorSaque > saldo)
            throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
    }
}