using System;

namespace Exercicio2
{
    internal class Produto
    {
        //propriedades com autoimplementação
        public string? Nome { get; set; }
        public string? Codigo { get; set; }

        //propriedades com validação
        private double _preco;
        public double Preco
        {
            get => _preco;

            set
            {
                if (value < 0)
                {
                    throw new Exception("O preço informado não pode ser negativo!");
                }
                else
                {

                    _preco = value;

                }

            }

        }

        private int _estoque;
        public int Estoque
        {
            get => _estoque;

            set
            {
                if (value < 0)
                {
                    throw new Exception("O estoque informado não pode ser negativo!");
                }
                _estoque = value;
            }

        }


        //propriedade somente leitura
        private DateTime _dataCadastro;
        public DateTime DataCadastro
        {
            get => _dataCadastro;
        }

        //propriedades calculadas

        public double ValorEmEstoque
        {
            get => _preco * _estoque;
        }

        public string Status 

        {
            get 
            {
                if (Estoque > 0)
                {
                    return "Em estoque";
                }
                else
                {
                    return "Sem estoque";
                }
            }
        }

        // Construtor completo
        public Produto(string nome, string codigo, double preco, int estoque)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome não pode ser vazio!");
            }

            Nome = nome;
            Codigo = codigo;
            Preco = preco;
            Estoque = estoque;
            _dataCadastro = DateTime.Now;
        }

        // Construtor com atributos essenciais
        public Produto(string nome, double preco)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome não pode ser vazio!");
            }

            Nome = nome;
            Preco = preco;
            Estoque = 0;
            _dataCadastro = DateTime.Now;
        }

        // Construtor padrão
        public Produto()
        {
            _dataCadastro = DateTime.Now;
        }




    }
}
