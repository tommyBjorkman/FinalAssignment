using Microsoft.EntityFrameworkCore;

namespace finalassignment.Contexts;

internal class DataContext : DbContext
{
    public DataContext()
    {
    }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tommy\source\repos\FinalAssignment\finalassignment\Contexts\local-sql-db.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
