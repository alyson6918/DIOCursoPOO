using DIOExemploPOO.helper;
using DIOExemploPOO.models;
using System.IO;

var _path = "C:\\archive";
var pathCombined = Path.Combine(_path, "pastaTeste1");
FileHelper helper = new FileHelper();
helper.DeleteDirectory(pathCombined, true);

// System.Console.WriteLine($"Criando diretorio: {pathCombined}");
// helper.CreateDirectory(pathCombined);

// helper.lsAllDirectory(_path);
// System.Console.WriteLine("-----------------------");
// helper.lsTopDirectory(_path);
// System.Console.WriteLine("-----------------------");
// helper.lsTopArchiveDirectory(_path);
// System.Console.WriteLine("-----------------------");
// helper.lsAllArchiveDirectory(_path);

// Calculator calc = new Calculator();
// System.Console.WriteLine(calc.sum(10, 20));

// Computer com = new Computer();
// System.Console.WriteLine(com.ToString());
// System.Console.WriteLine(com.GetType());
// System.Console.WriteLine(com.GetHashCode());


// CheckingAccount c = new CheckingAccount();

// c.creditar(100);

// c.balance();

//System.Console.WriteLine($"_______________\nResultado da primeira soma {calc.sum(10, 10)}");
//System.Console.WriteLine($"_______________\nResultado da segunda soma {calc.sum(10, 10, 5)}");

//Student s1 = new Student();
//s1.Name = "bob";
//s1.Age = 20;
//s1.Note = 8;
//s1.Cpf = 0391700481;
//s1.introduce();

//Teatcher s2 = new Teatcher();
//s2.Name = "Paulo";
//s2.Age = 47;
//s2.Cpf = 0156177716;
//s2.Wage = 2666.0;
//s2.introduce();

// //valores validos:
// Retangulo r = new Retangulo();
// r.DefineMeasures(30, 20);
// System.Console.WriteLine($"Altura:{r.obtainWidth()}\nLargura:{r.odtainLenght()} \nÁrea: {r.ObtainArea()}\n ----------");

// //valores invalidos:
// Retangulo r01 = new Retangulo();
// r01.DefineMeasures(0, 0);
// System.Console.WriteLine($"Altura:{r01.obtainWidth()}\nLargura:{r01.odtainLenght()} \nÁrea: {r01.ObtainArea()}\n ----------");


//Pessoa p1 = new Pessoa();
//p1.Name = "bob";
//p1.Age = 20;

//p1.introduce();