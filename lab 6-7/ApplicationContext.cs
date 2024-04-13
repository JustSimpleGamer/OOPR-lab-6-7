using lab_4_5.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<ClientVm> Clients => Set<ClientVm>();
    public DbSet<RequestVm> Requests => Set<RequestVm>();
    public DbSet<ApartmentVm> Apartments => Set<ApartmentVm>();

    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ClientsDataBase.db");
    }
}
