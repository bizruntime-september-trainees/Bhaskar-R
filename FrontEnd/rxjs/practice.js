"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function (subscriber) {
    var id = setInterval(function () {
        subscriber.next('hi');
        subscriber.complete();
    }, 2000);
});
observable.subscribe({
    next: function (x) { console.log('got value' + x); }
});
