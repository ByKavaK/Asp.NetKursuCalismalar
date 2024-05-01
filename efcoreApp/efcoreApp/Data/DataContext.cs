using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Kurs> Kurslar { get; set; } 
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<KursKayit> kursKayitlari { get; set; }
    }
}
