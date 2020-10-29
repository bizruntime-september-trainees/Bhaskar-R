
class Person{
    name:string
 
    eat():void{
        console.log(this.name+" eats when hungry.")
    }
}
 
class Student extends Person{   
    rollnumber:number;
    speak: any;
 
    constructor(rollnumber:number, name1:string){
        super(); 
        this.rollnumber = rollnumber;
        this.name = name1;
    }
 
    displayInformation():void{
        console.log("Name : "+this.name+", Roll Number : "+this.rollnumber);
    } 
    eat():void{
        console.log(this.name+" eats during break.");
    }
}
 
var std1 = new Student(1, "Rohit"); 
var std2 = new Student(2,'Bhaskar');
std1.displayInformation();
std1.eat();
std2.displayInformation();
std2.eat();