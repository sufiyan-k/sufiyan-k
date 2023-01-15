// using Microsoft.EntityFrameworkCore;
// using BOL;

// namespace DAL;

// public class CollectionContext:DbContext{
//     public DbSet<Employee> Empset{get;set;}

//       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         string conString=@"server=localhost;port=3306;user=root; password=123456;database=empinfo";       
//         optionsBuilder.UseMySQL(conString);

//     }
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);
//             modelBuilder.Entity<Employee>(entity => 
//             {
//             entity.HasKey(e => e.Empid);
//             entity.Property(e => e.Ename).IsRequired();
//             entity.Property(e => e.Sal).IsRequired();
//             });
//             modelBuilder.Entity<Employee>().ToTable("employees");

//         }

// }