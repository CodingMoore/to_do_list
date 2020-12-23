using Microsoft.EntityFrameworkCore;


namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}



// 2018-05-03 02:36:54.480

// 2020-12-25 20:00:00


// DateTime myDateTime = DateTime.Now;
// string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
