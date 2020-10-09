// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
var cacheName = "B2003C4_cache_v1_2";

var fileToCache = [
    './',
    //Html and css files
    './index.html',
    './css/site.css',
    './css/app.css',
    './css/bootstrap/bootstrap.min.css',
    './css/open-iconic/font/css/open-iconic-bootstrap.min.css',
    './css/open-iconic/font/fonts/open-iconic.woff',
    //Blazor framework
    './_framework/blazor.webassembly.js',
    './_framework/blazor.boot.json',
    //Our additional files
    './manifest.json',
    './service-worker.js',
    './icon-512.png',
    //The web assembly/.net dll's
    './_framework/wasm/dotnet.timezones.dat',
    './_framework/wasm/dotnet.3.2.0.js',
    './_framework/wasm/dotnet.wasm',
    './_framework/_bin/Microsoft.AspNetCore.Authorization.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.Authorization.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.Forms.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.Web.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.WebAssembly.Authentication.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.WebAssembly.dll',
    './_framework/_bin/Microsoft.AspNetCore.Metadata.dll',
    './_framework/_bin/Microsoft.Bcl.AsyncInterfaces.dll',
    './_framework/_bin/Microsoft.Extensions.Configuration.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.Configuration.Binder.dll',
    './_framework/_bin/Microsoft.Extensions.Configuration.dll',
    './_framework/_bin/Microsoft.Extensions.Configuration.FileExtensions.dll',
    './_framework/_bin/Microsoft.Extensions.Configuration.Json.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    './_framework/_bin/Microsoft.Extensions.FileProviders.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.FileProviders.Physical.dll',
    './_framework/_bin/Microsoft.Extensions.FileSystemGlobbing.dll',
    './_framework/_bin/Microsoft.Extensions.Logging.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.Logging.dll',
    './_framework/_bin/Microsoft.Extensions.Options.dll',
    './_framework/_bin/Microsoft.Extensions.Primitives.dll',
    './_framework/_bin/Microsoft.JSInterop.dll',
    './_framework/_bin/Microsoft.JSInterop.WebAssembly.dll',
    './_framework/_bin/Mono.Security.dll',
    './_framework/_bin/mscorlib.dll',
    './_framework/_bin/netstandard.dll',
    './_framework/_bin/System.Buffers.dll',
    './_framework/_bin/System.ComponentModel.Annotations.dll',
    './_framework/_bin/System.ComponentModel.Composition.dll',
    './_framework/_bin/System.ComponentModel.DataAnnotations.dll',
    './_framework/_bin/System.Core.dll',
    './_framework/_bin/System.Data.DataSetExtensions.dll',
    './_framework/_bin/System.Data.dll',
    './_framework/_bin/System.dll',
    './_framework/_bin/System.Drawing.Common.dll',
    './_framework/_bin/System.IO.Compression.dll',
    './_framework/_bin/System.IO.Compression.FileSystem.dll',
    './_framework/_bin/System.Memory.dll',
    './_framework/_bin/System.Net.Http.dll',
    './_framework/_bin/System.Net.Http.Json.dll',
    './_framework/_bin/System.Net.Http.WebAssemblyHttpHandler.dll',
    './_framework/_bin/System.Numerics.dll',
    './_framework/_bin/System.Numerics.Vectors.dll',
    './_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll',
    './_framework/_bin/System.Runtime.Serialization.dll',
    './_framework/_bin/System.ServiceModel.Internals.dll',
    './_framework/_bin/System.Text.Encodings.Web.dll',
    './_framework/_bin/System.Text.Json.dll',
    './_framework/_bin/System.Threading.Tasks.Extensions.dll',
    './_framework/_bin/System.Transactions.dll',
    './_framework/_bin/System.Xml.dll',
    './_framework/_bin/System.Xml.Linq.dll',
    './_framework/_bin/WebAssembly.Bindings.dll',
    './_framework/_bin/WebAssembly.Net.WebSockets.dll',
    //The compiled project .dll's
    './_framework/_bin/B2003C4.Client.dll'
];


self.addEventListener('install', function (e) {
    console.log('[ServiceWorker] Install');
    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
            console.log('[ServiceWorker] Caching app shell');
            return cache.addAll(fileToCache);
        })
    );
});
self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});
self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request, { ignoreSearch: true }).then(response => {
            return response || fetch(event.request);
        })
    );
});