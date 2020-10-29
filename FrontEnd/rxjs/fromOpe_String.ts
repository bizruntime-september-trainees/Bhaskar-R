import { from } from 'rxjs';

//emit string as a sequence
const source = from('BizRuntime');
const subscribe = source.subscribe(val => console.log(val));