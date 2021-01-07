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

        public Task<List<Dokusya>> GetDokusyaListAsync() =>_Context.DokusyaList.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Koudoku>> GetKoudokuListAsync() => _Context.KoudokuList.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Iri>> GetIriListAsync() => _Context.IriList.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<Tome>> GetTomeListAsync() => _Context.TomeList.OrderBy(x => x.DokuCode).ToListAsync();

        public Task<List<TenpoInfo>> GetTenpoListAsync() => _Context.TenpoList.OrderBy(x => x.Tenpo).ToListAsync();

        public Task<List<Kuiki_K95010>> GetKuikiListAsync() => _Context.KuikiList.OrderBy(x => x.Kuiki).ToListAsync();

        public Task<List<Nengetu_K95010>> GetNengetuListAsync() => _Context.NengetuList.OrderBy(x => x.No).ToListAsync();


    }
}
