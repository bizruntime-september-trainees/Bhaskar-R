var Employee = /** @class */ (function () {
    function Employee(name, city) {
        this.ename = name;
        this.city = city;
    }
    Employee.prototype.show = function () {
        console.log(this.ename + " and city is " + this.city);
    };
    return Employee;
}());
var emp1 = new Employee('Bhaskar', 'bangalore');
var emp2 = new Employee('suneel', 'chittor');
emp1.show();
emp2.show();
