using Microsoft.EntityFrameworkCore;    
// EF Core veritabanı işlemleri için ORM temsil eder. 

namespace efcoreApp.Data{
    public class DataContext:DbContext{

        // Veritabanı bağlantısı ve veritabanıyla yapılan işemleri yönetir.
        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        // DBSet veritabanındaki tabloyu temsil eder. EF Core bu tabloyu C# nesneleriyle ilişkilendirir.
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<CourseRegister> CourseRegistrations => Set<CourseRegister>();
    }
}