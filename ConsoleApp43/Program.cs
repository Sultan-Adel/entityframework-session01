using ConsoleApp43.Context;

using Microsoft.EntityFrameworkCore;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext dbcontext = new AppDbContext();

            dbcontext.Database.Migrate();

            Console.WriteLine("Database created successfully!");
        }
    }
}
