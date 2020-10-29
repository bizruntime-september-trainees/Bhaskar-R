"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var subject = new rxjs_1.Subject();
subject.subscribe({
    next: function (val) { return console.log("observerA: " + val); }
});
subject.subscribe({
    next: function (v) { return console.log("observerB: " + v); }
});
var observable = rxjs_1.from([1, 2, 3]);
observable.subscribe(subject);
