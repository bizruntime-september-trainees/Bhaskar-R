
import { from } from 'rxjs';
import { take } from 'rxjs/operators';
 
function* generateDoubles(value) {
   var i = value;
   while (true) {  
       yield i;   
     i = 2 * i; // double it
   }
} 
const iterator = generateDoubles(3);
const result = from(iterator).pipe(take(10));
 
result.subscribe(x => console.log(x));