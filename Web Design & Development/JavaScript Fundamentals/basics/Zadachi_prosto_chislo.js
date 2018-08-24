
//========================================================================================= 
// FOR cikli
// deli se samo na 1 i na sebesi / da se proveri dali e prosto // prosto chislo se deli samo na 1 i na sebesi


// let number1 = 49,
//     isPrime1 = true,
//     d = 2;

// maxDivisor = Math.sqrt(number1);

// while (isPrime1 && d <= maxDivisor) {
//     if (number1 % d === 0) {
//         isPrime1 = false;
//     }
//     d += 1;
// }
// console.log(`${number1} is prime? ${isPrime1}`);


//========================================================================================= 
//  FACTORIAL  
//  ver.1

// let num1 = 5;

// for (let x = num1-1; x > 1; x -= 1) {
//     num1 *= x;
// }
// console.log(num1);

//========================================================================================= 
//  ver.2

// let num1 = 5;
// let fact = 1;
// let factStr = "n! = ";

// while (num1 > 1) {
//     factStr += num1 + '*';
//     fact *= num1;
//     num1 -= 1;
// }
// factStr += '1 = ' + fact
// console.log(factStr );

//========================================================================================= 
//  nameri proizvedenieto na 4islata v diapazona 

// let from = 5,
//     to = 7,
//     product = 1;

// while (from <= to) {
//     product *= from;
//     from += 1;
// }
// console.log(product);

//========================================================================================= 
//  FOR cikli

// for (let x = 0 (INITIALIZATION PART); x < 10 (TEST STATEMENT ); x += 1(UPDATE STATEMENT)) {} <- BODY

// da namerim sbora na chislata v diapazona

// let num1 = 1,
//     num2 = 3 ,
//     sum = 0;

// for (x = num1; x <= num2; x += 1) {
//     sum += x;
// }
// console.log(sum);

//========================================================================================= 
//  IS PRIME IN LOOP ?

// for (let x = 1; x < 9; x += 1) {
//     let number1 = x,
//         isPrime1 = true,
//         d = 2;

//     maxDivisor = Math.sqrt(number1);

//     while (isPrime1 && d <= maxDivisor) {
//         if (number1 % d === 0) {
//             isPrime1 = false;
//         }
//         d += 1;
//     }

//     if (isPrime1) {
//         isPrime1 = 'is prime'
//     } else {
//         isPrime1 = 'is not prime'
//     }

//     console.log(`${x} ${isPrime1}`);
// }

//========================================================================================= 
// LARGEST PRIME.

// function checkPrime(n) {

//     let number = n,
//         isPrime = true,
//         i,
//         d = 2,
//         maxDivisor = Math.sqrt(number);

//     for (i = 2; i <= maxDivisor; i += 1) {
//         if (isPrime == false || number % d === 0) {
//             isPrime = false;
//         }
//         d += 1;
//     }
//     return console.log(isPrime);
// }
// checkPrime(11);

//========================================================================================= 
// HAPPY NUMBERS - sumata na purvite dve cifri i sumata na poslednite dve cifri tr da sa ravni

// let a, b, c, d;

// for (let a = 1; a < 9; a += 1) {
//     for (let b = 1; b < 9; b += 1) {
//         for (let c = 1; c < 9; c += 1) {
//             d = a + b - c
//             if (0 <= d && d < 9) {
//                 console.log(`${a} ${b} ${c} ${d}`);
//             }
//         }
//     }
// }

//========================================================================================= 
// FOR IN / FOR OF

// let line = "";
// let obj = {
//     "name": "John",
//     "age": "22"
// }

// for (prop in obj) {
//     line += prop + ',';
// }
// console.log(line);

//========================================================================================= 
// PRINT TRAPIZOID / MATH

// function TRAPIZOID(tr1, tr2, tr3) {
//     //return console.log(((Number(tr1) + Number(tr2)) * (Number(tr3)) / 2));
//     return console.WriteLine({0:F6},number);

// }
// TRAPIZOID(0.222, 0.333, 0.555);

//========================================================================================= 
// BIGGER

// let a = 10,
//     b = 51;
//     bigger = a;

// if (a < b) {
//     bigger = b;
// }

// console.log(bigger);

// JavaScript-Fundamentals

//========================================================================================= 
// Exchange if greater

// let a = 5.5,
//     b = 4.5,
//     c = a;

// if (c > b) {
//     a = b;
//     b = c;
// }

// console.log(a + " " + b);

//========================================================================================= 
// Multiplication Sign




//========================================================================================= 
// The biggest of Three

// let arr = [345, 52, 3333],
//     biggest = arr[0];

// if (arr[0] > arr[1]) {
//     if (arr[0] > arr[2]) {
//         biggest = arr[0];
//     } else {
//         biggest = arr[2];
//     }
// } else {
//     if (arr[2] > arr[1]) {
//         biggest = arr[2]
//     } else {
//         biggest = arr[1];
//     }
// }
// console.log(biggest);

//========================================================================================= 
//  Sort three NUMBERS

// let
//     sorted,
//     a = 4,
//     b = 4,
//     c = 6,
//     pos1,
//     pos2,
//     pos3;

// if (a > b || a > c) {
//     pos2 = a;
//     if (a > c && a > b) {
//         pos1 = a;
//         if (c > b) {
//             pos2 = c;
//             pos3 = b
//         } else {
//             pos2 = b;
//             pos3 = c;
//         }
//     } else {
//         if (c > b) {
//             pos1 = c;
//             pos3 = b;
//         } else {
//             pos1 = b;
//             pos3 = c;
//         }
//     }
// } else {
//     pos3 = a;
//     if (b > c) {
//         pos1 = b;
//         pos2 = c;
//     } else {
//         pos1 = c;
//         pos2 = b;
//     }
// }
// console.log(pos1 + ' ' + pos2 + ' ' + pos3);

//========================================================================================= 
//  Digit as word

// var a = 6;

// switch (a) {
//     case 1:
//         console.log('one');
//         break;
//     case 2:
//         console.log('two');
//         break;
//     case 3:
//         console.log('three');
//         break;
//     case 4:
//         console.log('four');
//         break;
//     case 5:
//         console.log('five');
//         break;
//     default:
//         console.log('not in range');
//         break;
// }

//========================================================================================= 
//  Quadratic equation

//========================================================================================= 
//  The biggest of five numbers

// let a = 145,
//     b = 10,
//     c = 444,
//     d = 4444,
//     e = 133;

// biggest = a;

// if (a > b && a > c && a > d && a > e) {
//     biggest = a;
// } else if (b > a && b > c && b > d && b > e) {
//     biggest = b;
// } else if (c > a && c > b && c > d && c > e) {
//     biggest = c;
// } else if (d > a && d > b && d > c && d > e) {
//     biggest = d;
// } else {
//     biggest = e;
// }

// console.log(biggest);

//========================================================================================= 
//  Number as words

// let n = 199,
//     nStr = n + "",
//     len = nStr.length,
//     res,
//     hundreds = parseInt(nStr[0]),
//     tenths = parseInt(nStr[1]),
//     units = parseInt(nStr[2]);


// if (len == 3) {
//     if (tenths == 1) {
//         tenths = 0;
//         units = parseInt(nStr[1] + nStr[2]);
//     }

// } else {
//     if (len == 2) {
//         hundreds = 0;

//         if (n < 20) {
//             tenths = 0;
//             units = parseInt(n);
//         }
//         if (n > 19) {
//             tenths = parseInt(nStr[0]);
//             units = parseInt(nStr[1]);
//         }
//     } else {
//         hundreds = 0;
//         tenths = 0;
//         units = parseInt(nStr[0]);
//     }
// }

// switch (hundreds) {
//     case 1:
//         res = 'one hundred and ';
//         break;
//     case 2:
//         res = 'two hundred and ';
//         break;
//     case 3:
//         res = 'three hundred and ';
//         break;
//     case 4:
//         res = 'four hundred and ';
//         break;
//     case 5:
//         res = 'five hundred and ';
//         break;
//     case 6:
//         res = 'six hundred and ';
//         break;
//     case 7:
//         res = 'seven hundred and ';
//         break;
//     case 8:
//         res = 'eight hundred and ';
//         break;
//     case 9:
//         res = 'nine hundred and ';
//         break;
//     default:
//         res = '';
//         break;
// }

// switch (tenths) {
//     case 2:
//         res += 'twenty ';
//         break;
//     case 3:
//         res += 'thirty ';
//         break;
//     case 4:
//         res += 'forty ';
//         break;
//     case 5:
//         res += 'fivty ';
//         break;
//     case 6:
//         res += 'sixty ';
//         break;
//     case 7:
//         res += 'seventy ';
//         break;
//     case 8:
//         res += 'eighty ';
//         break;
//     case 9:
//         res += 'ninety ';
//         break;
//     default:
//         res += '';
//         break;
// }

// switch (units) {
//     case 0:
//         res += 'zOro';
//         break;
//     case 1:
//         res += 'one';
//         break;
//     case 2:
//         res += 'two';
//         break;
//     case 3:
//         res += 'three';
//         break;
//     case 4:
//         res += 'four';
//         break;
//     case 5:
//         res += 'five';
//         break;
//     case 6:
//         res += 'six';
//         break;
//     case 7:
//         res += 'seven';
//         break;
//     case 8:
//         res += 'eight';
//         break;
//     case 9:
//         res += 'nine';
//         break;
//     case 10:
//         res += 'ten';
//         break;
//     case 11:
//         res += 'eleven';
//         break;
//     case 12:
//         res += 'twelwe';
//         break;
//     case 13:
//         res += 'threeteen';
//         break;
//     case 14:
//         res += 'fourteen';
//         break;
//     case 15:
//         res += 'fiveteen';
//         break;
//     case 16:
//         res += 'sixteen';
//         break;
//     case 17:
//         res += 'seventeen';
//         break;
//     case 18:
//         res += 'eightteen';
//         break;
//     case 19:
//         res += 'nineteen';
//     default:
//         res += '';
//         break;
// }

// console.log(res);


