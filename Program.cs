using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("123456", "Modelo 1", "8888-000", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("123456", "Modelo 2", "9999-000", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telagram");