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

//Busca todos
IEnumerable<Computer> computers = context.Computers;

foreach (var item in computers)
{
    Console.WriteLine($"{item.Id}, {item.Ram}, {item.Processor}");
}

//Busca por Id
Computer encontrado = context.Computers.Find(1);

//Editar
encontrado.Ram = "6GB";
context.Computers.Update(encontrado);
context.SaveChanges();

//Deletar
context.Computers.Remove(encontrado);
context.SaveChanges();

IEnumerable<Lab> labs = context.Labs;

