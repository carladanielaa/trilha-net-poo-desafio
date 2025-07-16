using DesafioPOO.Models;

Console.WriteLine("Testando iPhone:");
Iphone iphone = new Iphone("12345", "iPhone 14", "111222333", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nTestando Nokia:");
Nokia nokia = new Nokia("67890", "Nokia 3310", "444555666", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");