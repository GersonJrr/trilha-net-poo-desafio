using System;
using System.Reflection;
using DesafioPOO.Models;


namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "11111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");
            Console.WriteLine($"Dados do seu Smartphone {nokia.Numero}, {nokia.Modelo}, {nokia.IMEI}, {nokia.Memoria}");


            Console.WriteLine("Smartphone IPhone");
            Smartphone iphone = new Iphone(numero: "4695", modelo: "Modelo2", imei: "222222222", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
            Console.WriteLine($"Dados do seu Smartphone {iphone.Numero}, {iphone.Modelo}, {iphone.IMEI}, {iphone.Memoria}");
        }
    }
}
