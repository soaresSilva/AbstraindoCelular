using DesafioPOO;
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "11960256988", modelo: "no-6589s", imei: "1547888889658", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Messeger");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "11965874125", modelo: "ip-1543", imei: "1547999685987", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Messeger");