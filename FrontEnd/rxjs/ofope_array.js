"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
//emits values of any type
var source = rxjs_1.of({ name: 'Brian' }, [1, 2, 3], function hello() {
    return 'Hello';
});
var subscribe = source.subscribe(function (val) { return console.log(val); });
