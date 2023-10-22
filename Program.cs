using System.Globalization;
//using System.Xml.Xsl.Runtime;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9999-9999", modelo: "STG-02", imei: "2222222", memoria: 123);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "9999-8888", modelo: "IPH-01", imei: "33333333", memoria: 999);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");