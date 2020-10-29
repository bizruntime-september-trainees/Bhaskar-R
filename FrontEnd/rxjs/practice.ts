import { Observable } from 'rxjs';

const observable = new Observable(subscriber => {
  const id = setInterval(() => {
    subscriber.next('hi')
    subscriber.complete()
  }, 2000);
});
observable.subscribe({
    next(x){console.log('got value'+ x)}, 
    //()   
});
