using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei:"111222333444", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();

nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone(numero: "7891011", modelo: "iPhone 12", imei: "555666777888", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");
