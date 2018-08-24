// //https: //developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array

'use strict';

// ~ take bits

// 	let fruits = [];

// fruits.unshift('bean', 'strawberries', 'oranges'); // to the front
// fruits.push('cherry', 'rossberry', 'carrots'); // ad to the back
// fruits.shift(); // remove from the front
// fruits.pop() // remove from the end
// fruits.splice(0, 1); // remove everything from 0 to 2


// fruits.forEach(function(item, index, fruits) {
// 	console.log(item, index);
// });

// console.log(fruits[1]); // access to array value

// fruits[15] = 'mango';
// console.log(fruits.length); // empty value is count as item anyway

// fruits.length = 3; // decreases the lenght and delete 
// console.log(fruits);

// console.log('- - - - - same - - - -');
// console.log(fruits.length);
// console.log(fruits.shift());
// console.log(fruits.push('carrot')); 
// console.log(fruits.fill('ants', 0, 2)); // replaces the values of array / value / from /to

// Operators

// && and ||

// let hoursAtended = 51;
// let exam = 11

// let result =  hoursAtended > 40 || exam > 8 ;
// let excellent = hoursAtended > 50 && exam > 10;

// console.log(`Passed:  ${result}`);
// console.log(`Excellent:  ${excellent}`);

// ^

// let one = true,
// 	two = true;

// let three = one ^ two;

// console.log(three);

// Objects

let person = { name: 'Tom'};

person.age = 15;

console.log(person);

delete person.age;

console.log();