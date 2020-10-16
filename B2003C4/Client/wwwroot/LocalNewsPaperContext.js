(function () {
    // This code exists to support functionality in LocalNewsPaperStore.cs. It provides convenient access to
    // the browser's IndexedDB APIs, along with a preconfigured database structure.

    const db = idb.openDB('NewsPaper', 1, {
        upgrade(db) {
            db.createObjectStore('metadata');
            //db.createObjectStore('serverdata', { keyPath: 'licenseNumber' }).createIndex('lastUpdated', 'lastUpdated');
            db.createObjectStore('Server_K95010', { keyPath: 'dokuCode', autoIncrement: true });
            db.createObjectStore('Local_K95010', { keyPath: 'dokuCode' });
        },
    });

    // DBOpen.createDB
    window.DBOpen = {
        createDB: async (dbName) => {
            // Connect DB
            var dbRequest = indexedDB.open(dbName);

            // Creat and Update
            dbRequest.onupgradeneeded = function (event) {
                console.log('New DB Created | DBName : ' + dbName);
            }
            // Connect Success.
            dbRequest.onsuccess = function (event) {
                console.log('Connected DB | DBName : ' + dbName);
                var db = event.target.result;
                // 生成されたtransactionが全て完了したら接続が閉じられる。(ここではtransactionを作成していない) 
                db.close();
            }
            // On Error
            dbRequest.onerror = function (event) {
                console.log('Could not connect to the DB | DBName : ' + dbName);
            }
        },
        updateDB: async (dbName, dbVer, tableName, key) => {

            // DBに接続
            var dbRequest = indexedDB.open(dbName, dbVer);
            var version;

            dbRequest.onupgradeneeded = function (event) {
                var db = event.target.result;
                // 新規作成テーブルがあれば作成する
                // テーブル作成用のメソッドとするなら、このif文はいらないです。
                if (tableName) {
                    // DBにテーブルを追加します。
                    db.createObjectStore(tableName, { keyPath: key, autoIncrement: false })
                    console.log('Add a table to the DB!  TableName : ' + tableName + ' / keyPath : ' + key);
                }
            }
            dbRequest.onsuccess = function (event) {
                console.log('Connected DB | DBName : ' + dbName);
                var db = event.target.result;
                db.close();
            }
            dbRequest.onerror = function (event) {
                console.log('Could not connect to the DB | DBName : ' + dbName);
            }
        }
    },

    window.LocalNewsPaperContext = {
        get: async (storeName, key) => (await db).transaction(storeName).store.get(key),
        getAll: async (storeName) => (await db).transaction(storeName).store.getAll(),
        getFirstFromIndex: async (storeName, indexName, direction) => {
            const cursor = await (await db).transaction(storeName).store.index(indexName).openCursor(null, direction);
            return (cursor && cursor.value) || null;
        },
        //put: async (storeName, key, value) => (await db).transaction(storeName, 'readwrite').store.put(value, key === null ? undefined : key),
        /*
        putAllFromJson: async (storeName, json) => {
            const store = (await db).transaction(storeName, 'readwrite').store;
            console.log(json);
            JSON.parse(json).forEach(item => store.put(item, key = item.dokuCode));
        },
        */
        putAllFromJson: async (dbName, storeName, json) => {
            var dbRequest = indexedDB.open(dbName);
            dbRequest.onsuccess = function (event) {
                var db = event.target.result;
                var trans = db.transaction(storeName, 'readwrite');
                var store = trans.objectStore(storeName);
                //const store = db.transaction(storeName, 'readwrite').store;
                if (storeName == 'Tenpo') {
                    console.log('StoreName:' + storeName);
                    console.log('Data:' + json);
                    JSON.parse(json).forEach(item => store.put(item, item.No));
                    console.log('DataPutEnd');
                }
                else if (storeName == 'Setting') {
                    console.log('StoreName:' + storeName);
                    console.log('Data:' + json);
                    JSON.parse(json).forEach(item => store.put(item, item.KeyMobileNo));
                    console.log('DataPutEnd');
                }
                db.close();
            }
        },
        delete: async (storeName, key) => (await db).transaction(storeName, 'readwrite').store.delete(key),
        deleteAll: async (storeName) => (await db).transaction(storeName, 'readwrite').store.clear(),
        autocompleteKeys: async (storeName, text, maxResults) => {
            const results = [];
            let cursor = await (await db).transaction(storeName).store.openCursor(IDBKeyRange.bound(text, text + '\uffff'));
            while (cursor && results.length < maxResults) {
                results.push(cursor.key);
                cursor = await cursor.continue();
            }
            return results;
        }
    };
})();