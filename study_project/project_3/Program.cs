using project_3.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "212313", modelo: "Modelo 1", imei: "212313414", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "313414", modelo: "Modelo 2", imei: "313414515", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");