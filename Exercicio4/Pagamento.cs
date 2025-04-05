using System;
using System.Collections.Generic;


namespace Exercicio4
{
    //criação da classe abstrata Pagamento
    public abstract class Pagamento
    {   
        //Atributos comuns da classe 
        public double Valor {get; set;}
        public DateTime Data {get; set;}
        public string? Status {get; set;}

        //metodos abstratos 
        public abstract void Processar();
        
        public abstract void GerarRecibo();
        
    }
}