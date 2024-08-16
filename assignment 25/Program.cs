using assignment_25.Contexts;
using Microsoft.EntityFrameworkCore;

namespace assignment_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iTIDbContext iTIDbContext = new iTIDbContext();

            //iTIDbContext.Database.Migrate(); //this way to apply migration in DB or by console byt type update-DataBase

        }
    }
}
