"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
//emit (1,2,3)
var source = rxjs_1.of(1, 2, 3);
//start with 0
var example = source.pipe(operators_1.startWith(0));
//output: 0,1,2,3
var subscribe = example.subscribe(function (val) { return console.log(val); });
