using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
        //Criação da classe ContaBancaria
    public class ContaBancaria
    {
        private decimal _saldo;
        private string _numeroConta;
        private string _titular;
        private List<Transacao> _transacoes;

        //Construtor da classe ContaBancaria

        public ContaBancaria(string numeroConta, string titular, decimal saldoInicial = 0)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _transacoes = new List<Transacao>();
            _saldo = saldoInicial;
        }
        //Propriedades da classe ContaBancaria

        public decimal Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }

        public string NumeroConta
        {
            get { return _numeroConta; }
        }

        public string Titular
        {
            get { return _titular; }
        }

        public IReadOnlyList<Transacao> Transacoes
        {
            get { return _transacoes.AsReadOnly(); }
        }

        //Validação do valor do depósito
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O valor do depósito deve ser maior que zero.");
            }
            //Atualiza o valor do saldo da conta
            _saldo += valor;
            var transacao = new Transacao (TipoTransacao.Deposito, valor, $"Depósito de {valor} efetuado com sucesso.");
    _transacoes.Add(transacao);
        }
        //Validação de valor do saque e saldo suficiente
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O valor do saque deve ser maior que zero.");
            }
            if (valor > _saldo)
            {
                throw new Exception("Saldo insuficiente.");
            }
            //Atualiza o valor do saldo da conta
            _saldo -= valor;
            var transacao = new Transacao(TipoTransacao.Saque, valor, $"Saque de {valor} efetuado com sucesso.");
            _transacoes.Add(transacao);
        }
        
        public void VerExtrato()
        {
            Console.WriteLine($"Extrato da conta: {NumeroConta} - Titular: {Titular}\n----------------------------------------------------------------------------------");
            Console.WriteLine($"Saldo atual: {Saldo}\n----------------------------------------------------------------------------------");
            Console.WriteLine("Transações:\n----------------------------------------------------------------------------------");

            //Exibe as transações realizadas
            foreach (var transacao in Transacoes)
            {
                Console.WriteLine($"{transacao.Data} - {transacao.Tipo} : {transacao.Descricao}");
            }
        }

    }
}