
'use strict'

//                                      OBJECTS                                          //
//========================================================================================= 

// {} - object
// obj = {};
// obj = new Obj();
// integrated JS obj - Math
// accesing 
// console.log(a['fname']);
// console.log(a.fname);


// obj = {
//     name: 'Amir',
//     age: 15,
//     grades: 4,
//     becomeOlder: function () {
//         this.age += 1;
//     }
// };

// obj.becomeOlder();
// obj.becomeOlder();
// console.log(obj);


// str = '$'

// for (let x = 0; x < 27; x += 1) {
//     str += str;
// }
// console.log('gen');

// const startTime = new Date();

// let strlen = str.length;

// for (let x = 0; x < strlen; x += 1) {

// }

// const endTime = new Date();

// console.log(endTime - startTime);
// console.log('int');

// let n = 2,
//     len = 20 - 1;


// for (let x = 0; x < len; x += 1) {
//     n *= n;
// }

// console.log(n);

// function makePerson(fname, lname, age) {

//     var people = [
//         { fname: 'Gosho', lname: 'Petrov', age: 32 },
//         { fname: 'Bay', lname: 'Ivan', age: 81 },
//         { fname: 'John', lname: 'Doe', age: 42 }
//     ];

//     let len = people.length,
//         x;

//     for (x = 0; x < len; x += 1) {

//     }
// }

// console.log(makePerson());

//========================================================================================= 
// Homework Using Objects
// https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/Topics/09.%20Using%20Objects

// Remove elements
// http://stackoverflow.com/questions/13521833/javascript-add-method-to-object
// sled sledvashtiq urok moje da se probvam da go podobrq

// function removeElements(maikati) {

//     this.result = maikati;

//     let len = maikati.length,
//         x,
//         val = 1;


//     for (x = 0; x < len; x += 1) {
//         if (val == maikati[x]) {
//             maikati.splice(x, 1);
//             x -= 1
//         }
//     }
// }

// removeElements.prototype.remove = function () {

//     let x,
//         len = this.result.length;

//     for (x = 0; x < len; x += 1) {
//         console.log(this.result[x]);
//     }
// }

// var maikati = [1, 1, 1, 2, 1, 1, 4, 1, 3, 4, 1, 111, 3, 5, '1', 5, 1, 1, 1, 6, 1, 1];

// let arr = new removeElements(maikati);

// arr.remove();


//========================================================================================= 
// Deep copy 35 min

// slice kopira stoinostite na masiva ako e bez parametri vutre / no tova ne e reshenie
// rabotata e tam che nqma opredelen metod za kopirane na obekti i trqbva da se izpolzvat 
// vsqkvi hitrinki za kopirane

// let x = [1, 5, { value: 5 }, 'asda'];
// let y = x.slice();

// x[1] = 10;
// x[2] = 115;

// console.log(x);
// console.log(y);
//========================================================================================= 
// Youngest Person

// function youngest(arr) {

//     let people = [],
//         count = 0,
//         i,
//         x;

//     for (let x = 0; x < arr.length; x += 1) {
//         people.push({ firstname: arr[x], lastname: arr[x + 1], age: arr[x + 2] });
//         count += 1;
//         x += 2;
//     }

//     let youngest = parseInt(people[0]['age']),
//         youngestPerson = people[0],
//         personAge;

//     for (i in people) {
//         personAge = parseInt(people[i]['age']);

//         if (youngest > personAge) {
//             youngest = personAge;
//             youngestPerson = people[i];
//         }
//     }

//     return youngestPerson['firstname'] + ' ' + youngestPerson['lastname'];

// }

// console.log(youngest(
//     [
//         'Penka', 'Hristova', '19',
//         'System', 'Failiure', '88',
//         'Bat', 'Man', '16',
//         'Malko', 'Kote', '72',
//         'Kote', 'Kote', '12',
//         'System', 'aaaaa', '1',
//     ]
// ));

//========================================================================================= 
// Group people

// function group(arr) {

//     let len = arr.length,
//         x,
//         y,
//         groupBy = {},
//         o;

//     for (x = 0; x < len; x += 1) {

//         let sort = [];

//         for (y = 0; y < len; y += 1) {
//             if (arr[x]['age'] == arr[y]['age']) {
//                 sort.push({ name: arr[y]['firstname'], lastname: arr[y]['lastname'], age: arr[y]['age'] })
//             }
//         }
//         groupBy[arr[x]['age']] = sort
//         sort = [];
//     }
//     return groupBy;
// }

// var people = [
//     { firstname: 'Bay', lastname: 'Ivan', age: 11 },
//     { firstname: 'John', lastname: 'Doe', age: 15 },
//     { firstname: 'Pesho', lastname: 'Pesho', age: 11 },
//     { firstname: 'Asdf', lastname: 'Xyz', age: 11 },
//     { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
//     { firstname: 'Gosho', lastname: 'Gosho', age: 32 }
// ];

// var groupedByAge = group(people);

// console.log(groupedByAge);

//========================================================================================= 
// Has property / moje i po dobre sig

// obj = {
//     name: 'A',
//     last: 'B',
//     age: '15',
//     length: 'wtf'
// }

// function hasProperty(obj, prop) {

//     let x;

//     for (i in obj) {
//         if (obj[prop]) {
//             return true;
//         } else {
//             return false;
//         }
//     }
// }

// var hasProp = hasProperty(obj, 'length');

// console.log(hasProp);


//=======================================================================================//
//                            Methods on Arrays and Objects                              //
//=======================================================================================//


//========================================================================================= 
//                                      EVERY                                            //

// EVERY
// SOME

//========================================================================================= 
// Prototype

// let array = [1, 1];

// function every(array, cond) {
//     for (let i in array) {
//         if (!cond(array[i])) {
//             return false;
//         }
//     }
//     return true;
// }

// console.log(every(array, n => n % 2));

//================================================== 

// EVERY - dali vsi4ki spazvat tova uslovie
// callback se izpolzva mn chesto

// const array = [1, 3, 5, 7, 3, 234, 45, 0, -15];

// function isOdd(num) {
//     return num % 2 !== 1;
// }

// const result = array.every(isOdd);
// console.log(result);

//================================================== 
// Callback 
// direktno vpisvane na funkciqta

// const array = [1, 3, 5, 7, 3, 234, 45, 0, -15];

// // let a = array.every(function (n) {
// //     return n % 2 !== 1;
// // });

// console.log(a);

// Callback moje da priema i drugi parametri

// function isOk(key, value, array) {
//     console.log(value,key,array);
// }


// console.log(array.some(isOk));

//================================================== 
// Lambda / ECMA6 syntax

// const array = [1, 3, 5, 7, 3, 234, 45, 0, -15];
// const result = array.every(num => num < 200);
// console.log(result);

//================================================== 
// OVERRIDE sega pri deklarirane na every() shte se izpulnqva gornata funkciq

// Array.prototype.every = every

// console.log(array.every());

//================================================== 
// THIS i pravilno izpisvane na gornite funkcii

// const array = [3, 5, 7];

// function every(cond) {
//     for (let i in this) {
//         if (!cond(this[i])) {
//             return false;
//         }
//     }
//     return true;
// }

// console.log(array.every(n => n % 2));

//========================================================================================= 
//                                      SOME                                             //

// Prototype

// let array = [5,6,7]

// function some(condition) {

//     for (let i in this) {
//         if (condition(this[i])) {
//             return true;
//         }
//     }
//     return false;
// }

// Array.prototype.some = some;

// console.log(array.some(n => n % 2));

//===========================================
// Examples

// const array = [1, 3, 5, 7, 3, 234, 45, 0, -15];

// const result = array.some(num => num == 234);
// console.log(result);

//===========================================

// const array = [1, 3, 5, 7, 4];

// let c = array.some(function (val) {
//     if (val > 15) {
//         return true;
//     }
//     return false;
// })

// console.log(c);

//===========================================

// const array = [3, 5, 7];

// function checkMatch(array, val) {

//     return array.some(function (valu) {
//         if (valu > val) {
//             return true;
//         }
//         return false;
//     });
// }

// console.log(checkMatch(array, 5));

//===========================================

// const array = [3, 5, 7];

// function every(cond) {
//     if (!cond(this[i])) {
//         return false;
//     }
//     return true;
// }

// console.log(array.every(n => n % 2));

//========================================================================================= 
//                          ARRAY METHODS FOR TRANSFORMATION                             //

// FILTER
// MAP
// REDUCE


//========================================================================================= 
//                                       FILTER                                          //

//===========================================
// Prototype

// const array = [3, 5, 7, 4, 6, 7, 8, 9];

// function isOdd(val) {
//     return val % 2
// }

// Array.prototype.filter = function (condition) {
//     let filteredArray = [];

//     for (let i in this) {
//         if (condition(this[i], i, this)) {
//             filteredArray.push(this[i]);
//         }
//     }
//     return filteredArray;
// }

// let c = array.filter(isOdd)
// console.log(c);

//===========================================

// const array = [3, 5, 7, 4, 6, 7, 8, 9];

// function isOdd(val) {
//     return val % 2
// }

// let c = array.filter(isOdd);

// console.log(c);
// console.log(array); // ne go overrideva

//[ 3, 5, 7, 7, 9 ]


//========================================================================================= 
//                                       MAP                                             //


//===========================================
// Prototype

// Array.prototype.map = function (f) {
//     let mappedArray = [];
//     for (let i in this) {
//         mappedArray[i] = f(this[i], i, this)
//     }
//     return mappedArray;
// }

//===========================================
// basic

// const array = [3, 5, 7, 4, 6, 7, 8, 9];

// function mul(val) {
//     return val * 2
// }

// console.log(array.map(mul));

//===========================================
// same but Lambda

// console.log(array.map(n => n+'a'));

//===========================================
// some chaining 

// const array = [3, 5, 7, 4, 6, 7, 8, 9];

// function solve(args) {
//     var numbers = args.map(x => x + 5)
//         .map(x => x + 2)
//         .filter(x => x < 15)
//     console.log(numbers);
// }

// solve(array)

//===========================================
// KEY,VALUE i tn

// const array = [3, 5, 7, 4, 6, 7, 8, 9];

// console.log(array.map(function (x, y) {
//     return x * y;
// }));

//===========================================
// same but Lambda

// const array = [3, 5, 7, 4, 6, 7, 8, 9];
// console.log(array.map((x, y) => x * y));

//========================================================================================= 
//                                       REDUCE                                          //

// Array.prototype.foldl = function (combine, initial) {
//     let value = initial;

//     for (let i of this) {
//         value = combine(value, i)
//     }
//     return value;
// }

// let arr = [4, 5, 6, 3, 4]

// console.log(arr.foldl(((a, b) => a + b), 0));

//========================================================================================= 
//                                       REDUCERIGHT                                     //

// Array.prototype.foldl = function (combine, initial) {
//     let value = initial;

//     for (let i = this.length - 1; i >= 0; i -= 1) {
//         value = combine(value, this[i])
//     }
//     return value;
// }

// let arr = [4, 5, 6, 3, 4]

// console.log(arr.foldl(((a, b) => a + b), 0));

//========================================================================================= 
//                                       FOREACH                                         //

// function forEach(callback) {
//     for (let i in this) {
//         callback(this[i], i, this)
//     }
// }

// Array.prototype.forEach = forEach;

// let arr = [4, 5, 6, 3, 2];

// arr.forEach(x => console.log('my age is ' + x))

//========================================================================================= 
//                                       FIND                                            //

// function find(cond) {
//     for (let i in this) {
//         if (cond(this[i], i, this)) {
//             return this[i]
//         }
//     }
// }

// Array.prototype.find = find;

// let arr = [4, 5, 6, 3, 2];

// console.log(arr.find(x => x === 5));

//========================================================================================= 
//                                       FINDINDEX                                        //

// function find(cond) {
//     for (let i in this) {
//         if (cond(this[i], i, this)) {
//             return i
//         }
//     }
//     return -1;
// }

// Array.prototype.find = find;

// let arr = [4, 5, 6, 3, 2];

// console.log(arr.find(x => x === 62));

//========================================================================================= 
//                                       SORT                                            //
// TODO

// let arr = [4, 10, 5, 6, 3, 2];

// function sort(compare) {

//     if (compare === undefined) {
//         compare = function (a, b) {
//             return a.toString() < b.toString();
//         }
//     }

//     for (let i = 0; i < this.length; i += 1) {
//         for (let j = 0; j < this.length; j += 1) {
//             if (!compare(this[i], this[j]) > 0) {
//                 let x = this[i];
//                 this[i] = this[j];
//                 this[j] = x;
//             }
//         }
//     }
//     return this;
// }

// Array.prototype.sort = sort;

// console.log(arr.sort((a, b) => a + b));


//========================================================================================= 
//                                       FILL                                            //

// function fill(value, start, end) {

//     if (start === undefined) {
//         start = 0;
//     }

//     if (end === undefined) {
//         end = this.length;
//     }

//     for (let i = start; i < end; i += 1) {
//         this[i] = value;
//     }
//     return this;
// }
// Array.prototype.fill = fill;

// let arr = [4, 10, 5, 6, 3, 2];

// console.log(arr.fill(1, undefined, 4)); 

//========================================================================================= 
//                                       isArray                                         //

// Array.prototype.isArray = function (arg) {
//     return Object.prototype.toString.call(arg) === '[object Array]';
// };

// let a = Object.prototype.toString.call('asd') === '[object String]';

// console.log(a);

// let c = Object.prototype.toString.call({}) === '[object Object]';

// console.log(c);

//========================================================================================= 
//                                       copyWithin                                      //

// Array.prototype.copyWithin = function (target, start = 0, end = this.length) {

//     let arr = []

//     for (let i = start; i < end; i += 1) {
//         this[target] = this[start]
//         target += 1;
//         start +=1;
//     }

//     return this
// }

// let x = a.copyWithin(0,6,7);

// console.log(x);


//========================================================================================= 
//                                       includes                                        //

// let a = ['1', 'two', 'three', 'four', 'five', 'six', 'seven', 6, NaN]

// Array.prototype.includes = function (searchElement, fromIndex) {
//     'use strict';
//     let O = Object(this),
//         len = O.length || 0,
//         n = parseInt(arguments[1]) || 0,
//         k;

//     if (len === 0) {
//         return false;
//     }

//     if (n >= 0) {
//         k = n
//     } else {
//         k = len + n;
//         if (k < 0) {
//             k = 0
//         }
//     }

//     while (k < len) {
//         let currentElement = O[k];

//         if (searchElement === currentElement) {
//             return true;
//         }
//         k++
//     }
//     return false;
// };

// console.log(a.includes('two', 3));

//========================================================================================= 
//                                       indexOf                                         //

// let arr = ['one', 'two']

// Array.prototype.indexOf = function (searchElement, fromIndex) {
//     var k,
//         O = Object(this),
//         len = O.length,
//         n = parseInt(arguments[1] || 0);

//     if (n >= 0) {
//         k = n;
//     } else {
//         k = len + n
//         if (k < 0) {
//             k = 0;
//         }
//     }

//     while (k < len) {
//         let currentElement = O[k]
//         if (currentElement === searchElement) {
//             return k
//         }
//         k++
//     }
//      return -1
// }

// console.log(arr.indexOf('one'));

//========================================================================================= 
//                                       JOINt                                           //

// let arr = ['one', 'two', 'two', 1, 2, 3, 4]

// Array.prototype.join = function (separator) {
//     let str = '',
//         O = Object(this),
//         len = O.length,
//         i = 0;

//     separator += '';

//     if (separator === 'undefined') {
//         separator = ','
//     }

//     while (i < len) {
//         if (separator) {
//             if (i !== len - 1) {
//                 str += this[i] + separator;
//             } else {
//                 str += this[i];
//             }
//         } else {
//             str += this[i]
//         }
//         i++;
//     }
//     return str;
// }

// let c = arr.join('+');

//========================================================================================= 
//                                       Reverse                                         //

// var num = [1, 2, 'tst', {name:'a'}, 5, 6, 7, 8];

// Array.prototype.reverse = function () {

//     let len = this.length,
//         tmp,
//         lenn;

//     if (len % 2 !== 0) {
//         lenn = (len - 1) / 2;
//     } else {
//         lenn = len / 2;
//     }

//     for (let i = 0, y = len - 1; i < lenn; i += 1, y -= 1) {
//         tmp = this[i];
//         this[i] = this[y]
//         this[y] = tmp;
//     }
//     return this;
// }

// console.log(num.reverse());

//========================================================================================= 
//                                       Slice                                           //

// var a = ['Banana', 'Orange', 'Lemon', 'Apple', 'Mango'];

// Array.prototype.slice = function (start, end) {
//     let ref = [],
//         n = parseInt(arguments[0] || 0),
//         e = parseInt(arguments[1] || 0),
//         O = Object(this),
//         len = O.length,
//         k,
//         arr = [];

//     if (n >= 0) {
//         k = n;
//     } else {
//         k = 0;
//     }

//     if (e) {
//         len = e;
//     }

//     while (k < len) {
//         arr.push(this[k])
//         k += 1;
//     }
//     return arr;
// }

// var sliced = a.slice(1, 3);

//========================================================================================= 
//                                       P.S                                             //

// Array.from()
// Array.isArray()
// Array.observe()
// Array.of()
// Array.prototype.concat() - subira array values
// Array.prototype.copyWithin() - kopira v arraya
// Array.prototype.entries() 
// Array.prototype.every() - proverqva v masiva dali vsi4ki sa true
// Array.prototype.fill() - fillva s opredelen value vs elemti
// Array.prototype.filter() - filtrira / printva vs x < 5
// Array.prototype.find() - printva value
// Array.prototype.findIndex() - printva index
// Array.prototype.forEach() - za vsqko fns
// Array.prototype.includes() - chekva dali ima zadadeno value v array
// Array.prototype.indexOf() - dava indexa na turseniq value
// Array.prototype.join() - subira array value
// Array.prototype.keys()
// Array.prototype.lastIndexOf() otzad napred
// Array.prototype.map() - prilaga na vsqko fns
// Array.prototype.pop() removes last
// Array.prototype.push() - vkarva v masiv
// Array.prototype.reduce() - subira
// Array.prototype.reduceRight() - ot dqsno
// Array.prototype.reverse() - obrushta masiva
// Array.prototype.shift() - removes first
// Array.prototype.slice() - izrqzva
// Array.prototype.some() - dali pone edno e true
// Array.prototype.sort() - sortira
// Array.prototype.splice() - deletva i zamestva
// Array.prototype.toLocaleString()
// Array.prototype.toSource()
// Array.prototype.toString() - na string
// Array.prototype.unshift() adds to front
// Array.prototype.values()
// Array.prototype[@@iterator]()