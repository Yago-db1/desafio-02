namespace desafio02.ContaBancaria;
using Metodos;
using Classes;


public class ContaBancaria
{
    public NumeroConta Numero { get; }
    public TitularConta Titular { get; }
    private Saldo Saldo { get; set; }
    public DateTime DataAbertura { get; }
    
    public ContaBancaria(NumeroConta numero, TitularConta titular, Saldo saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
        DataAbertura = DateTime.Now;
    }

    public void Depositar(decimal valor)
    {
        Metodos.ValidarNumeroMaiorQueZero(valor);
        Saldo.Valor += valor;
    }
    
    public void Sacar(decimal valor)
    {
        Metodos.ValidarNumeroMaiorQueZero(valor);
        Metodos.ValidarSaldoSuficiente(Saldo.Valor, valor);
        
        Saldo.Valor -= valor;
    }

    public decimal ObterSaldo()
    {
        return Saldo.Valor;
    }

    public string GerarExtrato()
    {
        return $"=== EXTRATO DA CONTA ===\n" +
               $"Numero: {Numero.Numero}\n" +
               $"Titular: {Titular.Titular}\n" +
               $"Saldo: {Saldo.Valor:C}\n" +
               $"Data de Abertura: {DataAbertura:dd/MM/yyyy}\n";
    }
}