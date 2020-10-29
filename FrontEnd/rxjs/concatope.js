"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var timer = rxjs_1.interval(1000).pipe(operators_1.take(7));
var sequence = rxjs_1.range(1, 10);
var result = rxjs_1.concat(timer, sequence);
result.subscribe(function (x) { return console.log(x); });
