using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace B2003C4.Data
{
    
    public class NewsPaperDbContext :DbContext
    {
        public NewsPaperDbContext(DbContextOptions<NewsPaperDbContext>options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kakuzai_K95010>()
              .HasKey(kakuzai => new { kakuzai.DokuCode, kakuzai.SeqNo }); //複合PrimaryKeyの設定

            modelBuilder.Entity<Kakuzai_K95020>()
                .HasKey(kakuzai => new { kakuzai.DokuCode, kakuzai.SeqNo }); //複合PrimaryKeyの設定
        }



        //K95010

        public virtual DbSet<Dokusya_K95010> Dokusya_K95010_List { get; set; }

        public virtual DbSet<Koudoku_K95010> Koudoku_K95010_List { get; set; }

        public virtual DbSet<Iri_K95010> Iri_K95010_List { get; set; }

        public virtual DbSet<Tome_K95010> Tome_K95010_List { get; set; }

        public virtual DbSet<Kuiki_K95010> Kuiki_K95010_List { get; set; }

        public virtual DbSet<Nengetu_K95010> Nengetu_K95010_List { get; set; }

        public virtual DbSet<Kakuzai_K95010> Kakuzai_K95010_List { get; set; }

        //K95010

        public virtual DbSet<Dokusya_K95020> Dokusya_K95020_List { get; set; }

        public virtual DbSet<Koudoku_K95020> Koudoku_K95020_List { get; set; }

        public virtual DbSet<Tome_K95020> Tome_K95020_List { get; set; }

        public virtual DbSet<Kuiki_K95020> Kuiki_K95020_List { get; set; }

        public virtual DbSet<Nengetu_K95020> Nengetu_K95020_List { get; set; }

        public virtual DbSet<Kakuzai_K95020> Kakuzai_K95020_List { get; set; }
        //Etc
        public virtual DbSet<TenpoInfo> TenpoList { get; set; }

    }
}
