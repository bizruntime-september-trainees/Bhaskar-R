function details1(person) {
    console.log("fullname=" + person.firstName + " " + person.lastName);
    console.log("age=" + person.age);
    console.log("emialaddress=" + person.email);
    console.log("address of " + person.firstName + " is " + person.address);
}
var p = {
    firstName: 'suneel',
    lastName: 'D',
    age: 22,
    email: 'suneel.d@bizruntime.com',
    address: 'chittor'
};
details1(p);
