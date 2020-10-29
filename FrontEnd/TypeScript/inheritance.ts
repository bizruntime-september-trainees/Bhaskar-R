class Persons{
    name:string
 
    speak():void{
        console.log(this.name+" can speak.")
    }
}
 
class Employees extends Persons{
    
    id:number; 
    constructor(id:number, name1:string){
        super(); // calling Parent's constructor
        this.id = id
        this.name = name1
    }
 
    // functions
    displayInformation():void{
        console.log("Name : "+this.name+", ID : "+this.id)
    }
}
 
var e1 = new Employees(2, "Rohit")
var e2 = new Employees(4, "Kohli")
 
console.log("\n---Student 1---")

e1.displayInformation()
// calling funciton of parent class
e1.speak()
 
console.log("\n---Student 2---")
e2.displayInformation()
e2.speak()