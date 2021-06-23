using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DebugProject
{
    public partial class NpcDatasDBContext : DbContext
    {
        public NpcDatasDBContext()
        {
        }

        public NpcDatasDBContext(DbContextOptions<NpcDatasDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NpcData> NpcDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;AttachDbFilename = C:\\Users\\ABondarenko\\sourceMy\\DebugProject\\DebugProject\\NpcNames.mdf;Trusted_Connection=True;");
            }
        }
    }
}
