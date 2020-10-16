using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using B2003C4.Shared;
using Microsoft.JSInterop;

// ！！！！indexedDBかどこかは分からないけど要素名の頭が小文字になるので注意！！！！


namespace B2003C4.Client.Data
{
    public class LocalNewsPaperContext
    {
        // private readonly HttpClient httpClient;
        private readonly HttpClient httpClient;
        private readonly IJSRuntime js;
        
        public LocalNewsPaperContext(HttpClient httpClient, IJSRuntime js)
        {
            this.httpClient = httpClient;
            this.js = js;
        }

        public async Task<Dokusya[]> GetAllDokusya()
            => await GetAllAsync<Dokusya[]>("Local_K95010");

        public async Task<Dokusya> GetDokusya()
            => await GetAsync<Dokusya>("Local_K95010", 133);

        ValueTask<T> GetAllAsync<T>(string storeName)
            => js.InvokeAsync<T>("LocalNewsPaperContext.getAll", storeName);

        ValueTask<T> GetAsync<T>(string storeName, object key)
            => js.InvokeAsync<T>("LocalNewsPaperContext.getAll", storeName, key);

        ValueTask DeleteAsync(string storeName, object key)
            => js.InvokeVoidAsync("LocalNewsPaperContext.delete", storeName, key);

        ValueTask DeleteAllAsync(string storeName)
            => js.InvokeVoidAsync("LocalNewsPaperContext.deleteAll", storeName);


        public Task<Tenpo[]> GetTenpoServerData(String name)
        {
            return httpClient.GetFromJsonAsync<Tenpo[]>($"api/DataReceive/GetTenpoData?DBName={name}");
        }

        public async Task SynchronizeAsync()
        {

            // テーブルの新規作成
            // データ受信でチェックが入れられた個所でファイル名を作成
            // (店舗番号)_(区域)_K95010.db
            // K95010        = 入止表
            // K95020        = 過去台帳
            // K95070H Y T S = 配達読者台帳
            // K95080        = 監査

            // K950*0で判別を行って、作成するテーブルを可変させる（jsファイル内で処理を分けてこっちでif分け）

            // DB名       ：ファイル名
            // テーブル名 ：元々のテーブル名

            // データ受信ページ遷移時に店舗情報を読み込んで、テーブルを作成
            // 店舗情報でファイルを取得して区域を分けて表示

            //-- 店舗の取得 ----------------------------------------------------------------------------------
            //-- SQLite FileName    : TenpoInfo.db
            //-- IndexedDB DBName   : TenpoInfo
            //--           StoreName: Tenpo
            var dbName = "TenpoInfo";
            // DB名を飛ばして、判別して、テーブル情報を入れたDataTableを返す
            DataTable table = CreateTable(dbName);

            await js.InvokeVoidAsync("DBOpen.createDB", dbName);

            int dbVer = 2;
            foreach (DataRow item in table.Rows)
            {
                await js.InvokeVoidAsync("DBOpen.updateDB", dbName, dbVer, item["TableName"], item["Key"]);
                var TenpoJson = await httpClient.GetStringAsync($"api/DataReceive/Get{item["TableName"]}Data?DBName={dbName}");
                await js.InvokeVoidAsync("LocalNewsPaperContext.putAllFromJson", dbName, item["TableName"], TenpoJson);
                dbVer += 1;
            }

            //------------------------------------------------------------------------------------------------


            //データ受信
            /*
            await DeleteAllAsync("Local_K95010");

            var json = await httpClient.GetStringAsync("api/DataReceive/GetData");
            await js.InvokeVoidAsync("LocalNewsPaperContext.putAllFromJson", "Local_K95010", json);
            */
        }

        public DataTable CreateTable(string dbName)
        {
            DataTable t = new DataTable("TableInfo");
            t.Columns.Add("TableName");
            t.Columns.Add("Key");

            if (dbName == "TenpoInfo")
            {
                t.Rows.Add("Tenpo", "no");
                t.Rows.Add("Setting", "keyMobileNo");
            }

            return t;

        }


    }
}
