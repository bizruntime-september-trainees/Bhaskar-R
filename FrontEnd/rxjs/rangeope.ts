import { range } from 'rxjs';

//emit 1-10 in sequence
const source = range(50, 10);
const example = source.subscribe(val => console.log(val));