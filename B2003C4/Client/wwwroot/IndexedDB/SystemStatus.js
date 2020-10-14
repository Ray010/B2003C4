﻿var dbName = 'SystemStatusDB';
var dbVarsion = "0.1";
var storeName = "Status";

var openReq = indexedDB.open(dbName, dbVarsion);

openReq.onerror = function (event) {
    console.log("失敗:001");
}

openReq.onupgradeneeded = function (event) {
    var db = event.target.result;
    const objectStore = db.createObjectStore(storeName, { keyPath: "id" })
    objectStore.createIndex("id", "id", { unique: true });
    objectStore.createIndex("cnt", "cnt", { unique: true });

    console.log("DB更新");

}

openReq.onsuccess = function (event) {

    var db = event.target.result;
    var trans_g = db.transaction(storeName, "readonly");
    var store_g = trans_g.objectStore(storeName);
    var getReq_g = store_g.get(1);

    getReq_g.onsuccess = function (event) {
        // 取得したデータがundefinedだったら0をセット
        // でーたがあれば++
        if (typeof event.target.result === 'undefined') {
            count = 0;
        } else {
            count = event.target.result.cnt;
            alert(count);
            count++;
        }

        var trans = db.transaction(storeName, "readwrite");
        var store = trans.objectStore(storeName);
        var putReq = store.put({
            id: 1,
            cnt: count
        });

        putReq.onsuccess = function (event) {
            console.log('更新成功');
        }
    }

}
