using Microsoft.EntityFrameworkCore;
using B2003C4.Shared;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;

namespace B2003C4.Server.Data
{
    public class NewsPaperContext : DbContext
    {
        public NewsPaperContext(DbContextOptions<NewsPaperContext> options)
            : base(options)
        {
        }

        // 読者テーブル用
        public DbSet<Dokusya> Dokusya { get; set; }
        public DbSet<Tenpo> Tenpo { get; set; }
        public DbSet<Setting> Setting { get; set; }

        /*
        // 購読テーブル用
        public DbSet<Koudoku> Koudoku { get; set; }
        // 拡材テーブル用
        public DbSet<Kakuzai> Kakuzai { get; set; }
        // 設定テーブル用
        public DbSet<Setting> Setting { get; set; }
        // 入テーブル用
        public DbSet<Iri> Iri { get; set; }
        // 止テーブル用
        public DbSet<Tome> Tome { get; set; }
        // 年月テーブル用
        public DbSet<Nengetu> Nengetu { get; set; }
        // 持ち出しテーブル用
        public DbSet<TakeOutCount> TakeOutCount { get; set; }
        // 区域テーブル用
        public DbSet<Kuiki> Kuiki { get; set; }
        */



        /*
         * SQLiteの接続処理
         * 多分だけど繰り返しか何かで全部のファイルを読むか、引数で対応するファイル名を引っ張ることになる
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqliteConnectionStringBuilder { DataSource = @"C:\temp\NewsPaperDB\01_001_K95010.db" }.ToString();

            // ConnectionString : "Data Source=C:\\temp\\NewsPaperDB\\01_001_K95010.db"
            optionsBuilder.UseSqlite(new SqliteConnection(connectionString));
        }


        // 各モデルの作成
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dokusya>().ToTable("Dokusya");              // 読者
            modelBuilder.Entity<Tenpo>().ToTable("Tenpo");                  // 店舗
            modelBuilder.Entity<Setting>().ToTable("Setting");

            /*
            modelBuilder.Entity<Koudoku>().ToTable("Koudoku")               // 購読
                .HasKey(k => new { k.DokuCode, k.OyaMgCode, k.MgNo, k.No, k.MgCode });
            modelBuilder.Entity<Kakuzai>().ToTable("Kakuzai")               // 拡材
                .HasKey(k => new { k.DokuCode, k.MgCode, k.SeqNo });
            modelBuilder.Entity<Setting>().ToTable("Setting");              // 設定
            modelBuilder.Entity<Iri>().ToTable("Iri");                      // 入
            modelBuilder.Entity<Tome>().ToTable("Tome");                    // 止
            modelBuilder.Entity<Nengetu>().ToTable("Nengetu");              // 年月
            modelBuilder.Entity<TakeOutCount>().ToTable("TakeOutCount");    // 持ち出し
            modelBuilder.Entity<Kuiki>().ToTable("Kuiki");                  // 区域
            */
        }

    }
     
}
