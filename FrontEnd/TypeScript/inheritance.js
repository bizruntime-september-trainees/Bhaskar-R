var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Persons = /** @class */ (function () {
    function Persons() {
    }
    Persons.prototype.speak = function () {
        console.log(this.name + " can speak.");
    };
    return Persons;
}());
var Employees = /** @class */ (function (_super) {
    __extends(Employees, _super);
    function Employees(id, name1) {
        var _this = _super.call(this) || this;
        _this.id = id;
        _this.name = name1;
        return _this;
    }
    // functions
    Employees.prototype.displayInformation = function () {
        console.log("Name : " + this.name + ", ID : " + this.id);
    };
    return Employees;
}(Persons));
var e1 = new Employees(2, "Rohit");
var e2 = new Employees(4, "Kohli");
console.log("\n---Student 1---");
e1.displayInformation();
// calling funciton of parent class
e1.speak();
console.log("\n---Student 2---");
e2.displayInformation();
e2.speak();
