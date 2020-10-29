import { concat, interval, range } from 'rxjs';
import { take } from 'rxjs/operators';

const timer = interval(1000).pipe(take(7));
const sequence = range(1, 10);
const result = concat(timer, sequence);
result.subscribe(x => console.log(x));