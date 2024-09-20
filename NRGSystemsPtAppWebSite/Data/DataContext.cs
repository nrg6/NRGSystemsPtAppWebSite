using Microsoft.EntityFrameworkCore;
using NRGSystemsPtAppWebSite.Models;

namespace NRGSystemsPtAppWebSite.Context;
public class DataContext(DbContextOptions<DataContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Clients> Clients { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Muscle> Muscles { get; set; }
    public DbSet<ClientsProgram> Programs { get; set; }
    public DbSet<HeartRate> HeartRate { get; set; }
    public DbSet<ProgramReports> Reports { get; set; }
    public DbSet<MessageModel> Messages { get; set; }
    public DbSet<CalendarEvents> Calendars { get; set; }
    
}
