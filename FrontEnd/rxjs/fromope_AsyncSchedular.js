"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
console.log('start');
var array = [10, 20, 30];
var result = rxjs_1.from(array, rxjs_1.asyncScheduler);
result.subscribe(function (x) { return console.log(x); });
console.log('end');
