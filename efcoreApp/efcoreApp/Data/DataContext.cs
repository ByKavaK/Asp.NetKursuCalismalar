using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<Kurs> Kurslar { get; set; } 
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<KursKayit> kursKayitlari { get; set; }
    }
}
