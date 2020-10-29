"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
//emit string as a sequence
var source = rxjs_1.from('ZBizRuntime');
var subscribe = source.subscribe(function (val) { return console.log(val); });
