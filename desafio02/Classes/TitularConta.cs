namespace desafio02.Classes;

public class TitularConta
{
    public string Titular { get; set; }

    public TitularConta(string titular)
    {
        ValidarTitular(titular);
        Titular = titular;
    }

    private static void ValidarTitular(string titular)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("Nome do titular não pode ser vazio.");
        if (titular.Any(char.IsDigit))
            throw new ArgumentException("Nome do titular não pode conter números.");
    }
}