"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
//emits any number of provided values in sequence
var source = rxjs_1.of(1, 2, 3, 4, 5);
var subscribe = source.subscribe(function (val) { return console.log(val); });
