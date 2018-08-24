"use strict";

//========================================================================================= 
//  Numbers from 1 to N
//  1. Implement a javascript function that accepts an array with a single element - positive integer 
//  N as string and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

// let n = 1,
//     str,
//     x;

// for (x = 1; x <= n; x += 1) {
//     str += x + ' ';
// }

// console.log(str);

//========================================================================================= 
//  MMSA (Min, Max, Sum, Average) of N Numbers

// let arr = [5, 5, 6],
//     i,
//     max = arr[0],
//     min = arr[0],
//     sum = arr[0],
//     avg = arr[0],
//     len = arr.length;

// for (i = 1; i < len; i += 1) {
//     if (min > arr[i]) {
//         min = arr[i];
//     }
//     if (min < arr[i]) {
//         max = arr[i];
//     }
//     sum += arr[i];
//     avg = Number(sum) / Number(len);
// }

// console.log('min=' + min);
// console.log('max=' + max);
// console.log('sum=' + sum);
// console.log('avg=' + avg);

//========================================================================================= 
//  Matrix of Numbers

// let n = 3,
//     i,
//     x,
//     str = "";

// for (i = 0; i < n; i += 1) {
//     let line = '';
//     for (x = 0; x < n; x += 1) {
//         line += x + i + ' ';
//     }
//     console.log(line);
// }

//  Consider the following short solution using ES6 Array.fill, Array.map and Array.join functions:

// function printMatrix(size){
//      if (size <= 1) console.log(size); // if 0/1 was passed in - outputs it as is
//      var len = size, count = Array(size).fill(null), matrix = "";

//      while (len--) matrix = count.map((v, k) => len + 1 + k).join(" ") +"\n" + matrix;
//      console.log(matrix);
//  }

//  console.log("3 dimensional matrix:");
//  printMatrix(3);

//  console.log("5 dimensional matrix:");
//  printMatrix(5);

//========================================================================================= 
// FOR IN 

// FOR IN - cikul koito iz4ezva ot rabota // sushtiq kato for() // olesneniq na for

// let arr = [2, 4, 6];

// for (i in arr) {
//     console.log(`arr[${i}] = ${arr[i]}`);
// }

///

// let arr = [2, 4, 6];

// for (item of arr) {
//     console.log(item * item);
// }

