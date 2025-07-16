using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com a classe Nokia
        Nokia nokia = new Nokia("179998898", "Nokia C210", "IMEI111111", 32);

        System.Console.WriteLine("===Teste Nokia===\n");

        nokia.Ligar();
        nokia.InstalarAplicativo("Figma");

        // Teste com a classe Iphone
        Iphone iphone = new Iphone("11993445", "Iphone 14", "IMEI22222", 256);

        System.Console.WriteLine("===Teste iPhone===\n");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Linkedin");
    }
}