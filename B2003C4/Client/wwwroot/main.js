"use strict";

registSW();
//getPost();

function registSW() {

    if ("serviceWorker" in navigator) {
        window.addEventListener("load", function () {
            navigator.serviceWorker.register("./service-worker.js", { scope: "/" }).then(function (registration) {
                console.log('serviceWorker registration successful with scope: ', registration.scope);
            }, function (err) {
                console.log('serviceWorker registration failed: ', err);
            });
        });
    }
}

/*
function getPost() {

    fetch('https://qiita.com/api/v2/items')
        .then(response => {
            return response.json();

        }).then(res => {

            const title = res[0].title;
            const url = res[0].url;
            const data = `<a href="${url}">${title}</a>`;
            document.getElementById("newitem").innerHTML = data;

        }).catch(function (error) {
            console.log(error);
        });
}


}
*/