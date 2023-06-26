using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_pagamento
{
    public class Pagamento
    {
        public int Id {get; set;}
        public string Nome  {get; set;}
        public string CPF {get; set;}

        public virtual void TipoPag(){
            Console.WriteLine("Pagamento Físico");
        }
    }
}