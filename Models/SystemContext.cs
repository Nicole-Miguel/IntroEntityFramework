using Microsoft.EntityFrameworkCore;

namespace IntroEntityFramework.Models;

//pode ser qualquer nome, por convenção usamos System (ocupa o lugar do Repository)
public class SystemContext : DbContext
{
    //associado aos models/tabelas, sempre no plural
    public DbSet<Computer> Computers {get; set;}
    public DbSet<Lab> Labs { get; set; }

    public  SystemContext() {}

    //configuração do BDD
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(
            "server=localhost;database=estudante;user=estudante;password=estudante");
    }
}