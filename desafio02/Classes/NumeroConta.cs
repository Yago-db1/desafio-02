namespace desafio02.Classes;

public class NumeroConta
{
    public string Numero { get; }

    public NumeroConta(string numero)
    {
        ValidarNumeroConta(numero);
        Numero = numero;
    }

    private static void ValidarNumeroConta(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("Número da conta não pode ser vazio.");
        if (!numero.All(char.IsDigit))
            throw new ArgumentException("Número da conta deve conter apenas dígitos.");
    }
}