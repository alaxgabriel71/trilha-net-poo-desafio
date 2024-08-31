using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("1234", "Lumia 710", "abcd", 16);
Iphone iphone = new Iphone("5678", "X", "efgh", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");