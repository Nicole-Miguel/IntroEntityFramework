/*com o framework não temos muito controle e performance, há situações em que é melhor usar Dapper ou fazer manual */

using IntroEntityFramework.Models;

SystemContext context = new SystemContext();

//Database está na classe DBContext
//Ensure é para garantir que exista as tabelas 
context.Database.EnsureCreated();

//Insert
Computer c1 = new Computer(1, "2GB", "i3");
context.Computers.Add(c1);
context.SaveChanges();

Computer c2 = new Computer(2, "4GB", "i5");
context.Computers.Add(c2);
context.SaveChanges();

//Get All
IEnumerable<Computer> computers = context.Computers;

foreach (var item in computers)
{
    Console.WriteLine($"{item.Id}, {item.Ram}, {item.Processor}");
}

//GetById
Computer encontrado = context.Computers.Find(1);

//Update
encontrado.Ram = "6GB";
context.Computers.Update(encontrado);
context.SaveChanges();

//Delete
context.Computers.Remove(encontrado);
context.SaveChanges();


//Insert
Lab l1 = new Lab(1, 11, "Redes", "C");
context.Labs.Add(l1);
context.SaveChanges();

Lab l2 = new Lab(2, 12, "Banco de dados", "C");
context.Labs.Add(l2);
context.SaveChanges();

//Get All
IEnumerable<Lab> labs = context.Labs;

foreach (var item in labs)
{
    Console.WriteLine($"{item.Id}, {item.Number}, {item.Name}, {item.Block}");
}

//GetById
Lab achado = context.Labs.Find(2);

//Update
achado.Name = "Programação";
context.Labs.Update(achado);
context.SaveChanges();

//Delete
context.Labs.Remove(achado);
context.SaveChanges();



