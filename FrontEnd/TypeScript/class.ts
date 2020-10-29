class Employee{
    ename:String;
    city:String;

    constructor (name:String,city:String){
        this.ename= name;
            

    }
    show()
    {
        console.log(`${this.ename} and city is ${this.city}` );
        
    }    
}
let emp1 = new Employee('Bhaskar','bangalore');
let emp2 = new Employee('suneel','chittor');
emp1.show();
emp2.show();


