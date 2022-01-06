using DIOExemploPOO.models;

//valores validos:
Retangulo r = new Retangulo();
r.DefineMeasures(30, 20);
System.Console.WriteLine($"Altura:{r.obtainWidth()}\nLargura:{r.odtainLenght()} \nÁrea: {r.ObtainArea()}\n ----------");

//valores invalidos:
Retangulo r01 = new Retangulo();
r01.DefineMeasures(0, 0);
System.Console.WriteLine($"Altura:{r01.obtainWidth()}\nLargura:{r01.odtainLenght()} \nÁrea: {r01.ObtainArea()}\n ----------");


//Pessoa p1 = new Pessoa();
//p1.Name = "bob";
//p1.Age = 20;

//p1.introduce();