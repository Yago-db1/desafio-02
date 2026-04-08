using desafio02.Classes;
using desafio02.ContaBancaria;

var numeroConta = new NumeroConta("001");
var titularConta = new TitularConta("João Silva");
var saldoInicial = new Saldo(1000);
var contaBancaria = new ContaBancaria(numeroConta, titularConta, saldoInicial);


Console.WriteLine(contaBancaria.GerarExtrato());