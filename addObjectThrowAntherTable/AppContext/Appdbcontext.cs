using addObjectThrowAntherTable.Models;
using Microsoft.EntityFrameworkCore;

namespace addObjectThrowAntherTable.AppContext
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<student> students { get; set; }
        public DbSet<session> sessions { get; set; }
    }
}
