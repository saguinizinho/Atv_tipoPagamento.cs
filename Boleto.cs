using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_pagamento
{
    public class Boleto : Pagamento
    {
         public override void TipoPag(){
      Console.WriteLine(" Pagamento efetuado, Boleto");
    }
}}