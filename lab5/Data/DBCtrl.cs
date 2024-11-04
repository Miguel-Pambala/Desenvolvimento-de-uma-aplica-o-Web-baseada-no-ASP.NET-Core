using Microsoft.EntityFrameworkCore;
using lab5.Models; // Verifique se o namespace corresponde ao do modelo

namespace lab5.Data
{
    public class DBCtrl : DbContext
    {
        public DBCtrl(DbContextOptions<DBCtrl> options) : base(options) { }

        public DbSet<GComp> tComps { get; set; } // Mapeia a classe GComp para a tabela tComps
    }
}
