using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using B2003C4.Server.Data;
using B2003C4.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace B2003C4.Server.Controllers
{
    // WebAPIとして使うための設定

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DataReceiveController : ControllerBase
    {

        // ConnectionString : "Data Source=C:\\temp\\NewsPaperDB\\01_001_K95010.db"
        NewsPaperContext db;

        public DataReceiveController(NewsPaperContext db)
        {
            // db.Database.GetDbConnection().ConnectionString = "";
            this.db = db;
        }

        public IEnumerable<Dokusya> GetData()
        {
            return db.Dokusya.ToArray();
        }

        public IEnumerable<Tenpo> GetTenpoData([FromQuery] string DBName)
        {
            db.Database.GetDbConnection().ConnectionString = new SqliteConnectionStringBuilder { DataSource = @$"C:\temp\NewsPaperDB\{DBName}.db" }.ToString();
            return db.Tenpo.ToArray();
        }

        public IEnumerable<Setting> GetSettingData([FromQuery] string DBName)
        {
            db.Database.GetDbConnection().ConnectionString = new SqliteConnectionStringBuilder { DataSource = @$"C:\temp\NewsPaperDB\{DBName}.db" }.ToString();
            return db.Setting.ToArray();
        }

        /*
        public IActionResult GetDokusya()
        {

            using (var context = new NewsPaperContext(options))
            {
                var dokusya = context.Dokusya.ToList();
            }

            return OK();
        }
        */
    }
}
