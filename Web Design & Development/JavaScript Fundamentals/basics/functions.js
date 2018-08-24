//========================================================================================= 
// Suzdava i q vika vednaga 

// let printLogo;

// let result = function () {
//     console.log('it call it immediatelly');
// } ();

//========================================================================================= 
// predizvikva security issue / neudobno e

// let func = new Function('msg', `
//     console.log('it works: ' + msg);
// `);
// func('hello');

//========================================================================================= 
// JS is loosley type obj / also parameters are optional

// function checkStr(str) {
//     if (typeof(str) == "string"){
//         console.log('is string');
//     }
// }

// checkStr('asd');

//========================================================================================= 
// arguments ne e masiv a obekt
// ixspleciten 

// x 6te bude zapisana kato 1; i arguments shte e puslen sus vs arguments

// function min(x) {
//     for (item of arguments) {
//         console.log(item);
//     }
// }
// min(1, 2, 3, 4);

//========================================================================================= 
// ver1

// function min(x) {
//     let args = [].slice.apply(arguments);
//     console.log(args);
//     console.log(arguments);
// }

// min(1,2,3,4);
//========================================================================================= 
// ver2 SPREAD OPERATOR // razbiva masiva na parametri // izpolzva se v kraini slu4ai

// function min(...args) {
//     let args = [].slice.apply(arguments);
//     console.log(args);
//     console.log(arguments);
// }

// min(1,2,3,4);

//========================================================================================= 
// PRINT TRIANGLE

// function printLine(count) {

//     let str = "";

//     for (let x = 1; x <= count; x += 1) {
//         str += x + '  ';
//     }
//     return str;
// }

// function printTriangle(val) {

//     for (let x = 1; x <= val; x += 1) {
//         console.log(printLine(x));
//     }
//     for (let x = val - 1; x > 0; x -= 1) {
//         console.log(printLine(x));
//     }
// }
// printTriangle(15);

//========================================================================================= 
// check 44 min





//========================================================================================= 
// MIN n MAX

// function minMax(...numbers) {
//     let min = numbers[0],
//         max = numbers[1],
//         number;

//     for (number of numbers) {
//         if (number < min) {
//             min = number;
//         }
//         if (number > max) {
//             max = number;
//         }
//     }
//     return {
//         min,
//         max
//     }
// }
// console.log( minMax (1,2,4,5));

//========================================================================================= 
// OPTIONS 

// function getRandomValue(options) {
//     options = options || {};
//     let min = options.min || 0,
//         max = options.max || 1000;

//     return Math.random() * (max - min - 1) + min | 0;
// }

// console.log(getRandomValue());
// console.log(getRandomValue({ min: 1, max: 15 }));


//========================================================================================= 
// // Larger than neighbours

// function larger(arr) {

//     let len = arr.length,
//         x,
//         count = 0;

//     for (x = 0; x < len; x += 1) {
//         if ((parseInt(arr[x]) > parseInt(arr[x + 1]) && parseInt(arr[x]) > parseInt(arr[x - 1])) === true) {
//             count += 1;
//         }

//     }
//     console.log(count);

// }

// larger(['5', '4', '7', '4', '5'])

//========================================================================================= 
// First larger than neighbours

// function larger(arr) {

//     let len = arr.length,
//         x,
//         count = 0;

//     for (x = 0; x < len; x += 1) {
//         if ((parseInt(arr[x]) > parseInt(arr[x + 1]) && parseInt(arr[x]) > parseInt(arr[x - 1])) === true) {
//             console.log(x);
//             return false;
//         }

//     }
// }

// larger(['5', '4', '7', '4', '5'])

//========================================================================================= 
// Sort array

// function sort(arr, type = 'asc') {

//     let x,
//         y,
//         min,
//         len = arr.length;

//     for (x = 0; x < len; x += 1) {

//         min = arr[x];
//         let yo,
//             tmp;

//         for (y = x + 1; y < len; y += 1) {
//             if (min > arr[y] && type === 'asc') {
//                 min = arr[y];
//                 yo = y;
//             } else if (min < arr[y] && type === 'desc') {
//                 min = arr[y];
//                 yo = y;
//             }
//         }

//         if (yo != null) {
//             tmp = arr[x];
//             arr[x] = min;
//             arr[yo] = tmp;
//         }
//     }
//     console.log(arr);
// }

// sort([5, 3, 7, 8, 33, 33, 12],'desc')

