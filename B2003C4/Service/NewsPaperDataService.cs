using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using B2003C4.Data;

namespace B2003C4.Service
{
    public class NewsPaperDataService
    {
        NewsPaperDbContext _Context { get; }

        public NewsPaperDataService(NewsPaperDbContext context) =>
            _Context = context;


        public Task<List<TenpoInfo>> GetTenpoListAsync() => _Context.TenpoList.OrderBy(x => x.Tenpo).ToListAsync();

        //K95010

        public Task<List<Dokusya_K95010>> GetDokusya_K95010_ListAsync() =>_Context.Dokusya_K95010_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Koudoku_K95010>> GetKoudoku_K95010_ListAsync() => _Context.Koudoku_K95010_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Iri_K95010>> GetIri_K95010_ListAsync() => _Context.Iri_K95010_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Tome_K95010>> GetTome_K95010_ListAsync() => _Context.Tome_K95010_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Kuiki_K95010>> GetKuiki_K95010_ListAsync() => _Context.Kuiki_K95010_List.OrderBy(x => x.Kuiki).ToListAsync();

        public Task<List<Nengetu_K95010>> GetNengetu_K95010_ListAsync() => _Context.Nengetu_K95010_List.OrderBy(x => x.No).ToListAsync();

        public Task<List<Kakuzai_K95010>> GetKakuzai_K95010_ListAsync() => _Context.Kakuzai_K95010_List.OrderBy(x => x.DokuCode).ToListAsync();


        //K95020

        public Task<List<Dokusya_K95020>> GetDokusya_K95020_ListAsync() => _Context.Dokusya_K95020_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Koudoku_K95020>> GetKoudoku_K95020_ListAsync() => _Context.Koudoku_K95020_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Tome_K95020>> GetTome_K95020_ListAsync() => _Context.Tome_K95020_List.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Kuiki_K95020>> GetKuiki_K95020_ListAsync() => _Context.Kuiki_K95020_List.OrderBy(x => x.Kuiki).ToListAsync();

        public Task<List<Nengetu_K95020>> GetNengetu_K95020_ListAsync() => _Context.Nengetu_K95020_List.OrderBy(x => x.No).ToListAsync();

        public Task<List<Kakuzai_K95020>> GetKakuzai_K95020_ListAsync() => _Context.Kakuzai_K95020_List.OrderBy(x => x.DokuCode).ToListAsync();

        //K95080

    }
}


//