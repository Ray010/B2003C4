function OnlineTrue() {
   



    if (navigator.onLine) {
        console.log('onlineです。');
    } else {
        console.log('offlineです。');
    }
    return true;
}