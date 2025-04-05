using System;
using Exercicio1;


    //Definir o tipo de transação
    public enum TipoTransacao
    {
        Deposito,
        Saque,
        Transferencia
    }

    //Classe que contem os atributos da transação
    public class Transacao
    {
        //
        public DateTime Data { get; set; }
        public TipoTransacao Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

    //Construtor da classe
    public Transacao(TipoTransacao tipo, decimal valor, string descricao)
        {
            Data = DateTime.Now;
            Tipo = tipo;
            Valor = valor;
            Descricao = descricao;
        }

    }


