using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new("8348488", "Tijolo", "14M7", 64);
nokia.SobreSmartphone();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Iphone iphone = new("456893", "15 Pro", "4566L6", 256);
iphone.SobreSmartphone();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");