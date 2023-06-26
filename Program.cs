using System;
using Proj_pagamento;

Boleto blt = new Boleto()
{
    Id = 10,
    Nome = "Caio",
    CPF = "234.546.908-14"

};


CartaoCredito cc = new CartaoCredito()
{
    Id = 11,
    Nome = "Clayton",
    CPF = "244.546.908-35"

};


Pix pix = new Pix()
{
    Id = 12,
    Nome = "Roseli",
    CPF = "225.546.908-28"

};

Console.WriteLine($"Id: {blt.Id}, Nome: {blt.Nome}, CPF: {blt.CPF}  Forma de Pagamento:"); blt.TipoPag();
Console.WriteLine("");
Console.WriteLine($"Id: {cc.Id}, Nome: {cc.Nome}, CPF: {cc.CPF}  Forma de Pagamento:"); cc.TipoPag();
Console.WriteLine("");
Console.WriteLine($"Id: {pix.Id}, Nome: {pix.Nome}, CPF: {pix.CPF} Forma de Pagamento:"); pix.TipoPag();
