"use strict";
exports.__esModule = true;
var ajax_1 = require("rxjs/ajax");
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
var obs$ = ajax_1.ajax("https://api.github.com/users?per_page=5").pipe(operators_1.map(function (userResponse) { return console.log('users: ', userResponse); }), operators_1.catchError(function (error) {
    console.log('error: ', error);
    return rxjs_1.of(error);
}));
