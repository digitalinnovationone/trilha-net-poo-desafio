using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia1 = new Nokia("21948575-8596", "nokia-qter", "458293569326", "128g");
   
        nokia1.Ligar();
        nokia1.ReceberLigacao();
        nokia1.InstalarAplicativo("YouTube");


        Iphone iphone1 = new Iphone("21948575-4711", "Iphone14", "1352323626", "256g");

        iphone1.Ligar();
        iphone1.ReceberLigacao();
        iphone1.InstalarAplicativo("Instagram");

    }
}