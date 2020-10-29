"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var subject = new rxjs_1.BehaviorSubject(); // 0 is the initial value
subject.subscribe({
    next: function (v) { return console.log("observerA: " + v); }
});
subject.next(1);
subject.next(2);
subject.subscribe({
    next: function (v) { return console.log("observerB: " + v); }
});
subject.next(3);
