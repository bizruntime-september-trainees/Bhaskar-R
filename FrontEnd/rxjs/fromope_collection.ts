import { from } from 'rxjs';

//works on js collections
const map = new Map();
map.set(1, 'Hi');
map.set(2, 'Bye');
map.set(3,'bizruntime');

const mapSource = from(map);

const subscribe = mapSource.subscribe(val => console.log(val));