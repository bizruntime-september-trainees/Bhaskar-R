"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
//works on js collections
var map = new Map();
map.set(1, 'Hi');
map.set(2, 'Bye');
map.set(3, 'bizruntime');
var mapSource = rxjs_1.from(map);
var subscribe = mapSource.subscribe(function (val) { return console.log(val); });
