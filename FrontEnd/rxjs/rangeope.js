"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
//emit 1-10 in sequence
var source = rxjs_1.range(50, 10);
var example = source.subscribe(function (val) { return console.log(val); });
