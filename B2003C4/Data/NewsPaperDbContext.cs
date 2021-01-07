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

        //K95010

        public virtual DbSet<Dokusya> DokusyaList { get; set; }

        public virtual DbSet<Koudoku> KoudokuList { get; set; }

        public virtual DbSet<Iri> IriList { get; set; }

        public virtual DbSet<Tome> TomeList { get; set; }


        //Etc
        public virtual DbSet<TenpoInfo> TenpoList { get; set; }

        public virtual DbSet<Kuiki_K95010> KuikiList { get; set; }

        public virtual DbSet<Nengetu_K95010> NengetuList { get; set; }

        public virtual DbSet<Kakuzai_K95010> KakuzaiList { get; set; }

    }
}
