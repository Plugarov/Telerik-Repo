
'use strict'

//                                      ARRAYS                                          //
//========================================================================================= 


// FOR OF / IN
// PUSH & UNSHIFT 
// REVERSE 
// CONCAT 
// SLICE 
// SPLICE
// INDEXOF

//========================================================================================= 
// SPREAD OPERATOR

// let numbers = [1,2,3,4];
// let numbers2 = [...numbers];
// console.log(numbers2);

//========================================================================================= 






//========================================================================================= 
// INDEXIES 
// 1.otricatelni ne e jelatelno da ne se izpolzvat
// 2.associativni ne e jalatelno da se izpolzvat
// 3.da se suzdavat masivi inline - ne e jelatelno / prepuru4itelno e PUSH
//  key - number,string i otricatelno suzdava razli44ni tipove key-> value

// let arr = [];
// arr['one'] = 'One'; // 2
// arr[0] = 'One';
// arr[-1] = 'Minus one'; // 1
// console.log(arr);

// let arr = [], // 3
//     n = 10,
//     i;
// for (i = 0; i < 10; i += 1) {
//     arr[i] = i * 10;
// }
// console.log(arr);

//========================================================================================= 
// EX - Reversed array

// let arr = [-120,1,4, 2, 3, 4],
//     i,
//     j,
//     reversedAdd = [];

// for (i = 0; i < arr.length; i += 1) {
//     j = arr.length - i;
//     reversedAdd[j-1] = arr[i]
// }
// console.log(arr);
// console.log(reversedAdd);

//========================================================================================= 
// OFFTOPIC - DECLARATIONS

// always should declare variables in top because
// predi da zapo4ne skripta , js go obhojda subira vs var-ove koito sa deklarirani
// v koda i gi prashta nai gore kato gi pravi global. I vsu6tnost razkarva 'var' ot koda kudeto i da se namira
// LET moje da deklarirame tam kudeto gi izpolzvame , ne vaji gorenapisanoto

// if(false){
//     var b = 5; // let shte dade greshka
// }
// console.log(b); // vrushta undefined a ne greshka 4e b ne e deklarirano. JS v samoto nachalo e vzel b igo e pratil nai gore

// console.log(c);
// var c = 5 // vrushta undifined po sushtata pri4ina

//========================================================================================= 
// Obhojdane na masiv
// displeivane v vid arr[0] = 4

// let arr = [16, 17, 18],
//     i;
// for (i = 0; i < arr.length; i += 1) {
//     console.log(`arr[${i}] = ${arr[i]}` );
// }

//==========================
// koren kvadraten

// let arr = [2, 4, 6],
//     i,
//     squares = [];
// for (i = 0; i < arr.length; i += 1) {
//     console.log(squares[i] = arr[i] * arr[i]);
// }

//==========================
// FOR OF PUSH & UNSHIFT REVERSE CONCAT SLICE, SPLICE- nqma dostup do index; izpozva se ako ne trqbva index-a
// FOR OF - obhojda po stoinostta im
// nqma key
// koren kvadraten 

// let arr = [2, 4, 6];

// for (item of arr) {
//     console.log(item * item);
// }

//==========================
// FOR IN - cikul koito iz4ezva ot rabota // sushtiq kato for() // olesneniq na for
// ima key

// let arr = [2, 4, 6];

// for (i in arr) {
//     console.log(`arr[${i}] = ${arr[i]}`);
// }

// arr.name = "john"
// arr["name"] = "John"
// sa ekvavalentni
// i lo6oto e 4e pri izpulneniq na toz for cikul shte budat izkaran i arr.name vupreki 4e klu4a ne e 4islo.
// toest for in izkarva vsi4ko ot masiva/ obekta 

//========================================================================================= 
// PUSH & UNSHIFT  ||  POP/ maha otzad i vrushta obekt s elementa / & SHIFT - sushtoto samo 4e e baven tui kato 6te promenq vs elementi
// unshifta ne e jelatenlo da se izpolzva ako ne se nalaga izrichno -
// zashoto ako iskame da vkarame neshto v nachaloto zna4i 4e trqbva da promenim vsi4ki elementa v masiva // mn bavno
// 

// let arr = [];
// arr.push('1');
// arr.unshift('2');
// console.log(arr);


//==========================
// REVERSE  - obrushta i vrushta originalniq masiv

// let arr = [1,2,3];
// console.log(arr2 = arr.reverse());
// console.log(arr === arr2);

// ===
// na4ina po koito se pishe js kod.
// foreach obhojda masiva i printva v slu4aq

// let arr = [1,2,3];
// arr.reverse().forEach((item) => console.log(item))

// ===
// JOIN

// vkarva valueto na joina mejdu stoinostite na masiva i vrushta string 
// join() podava zapetaika join("") prazen string 

// let arr = [1,2,3];
// console.log(arr.join('!.!.!.!'));


// ===
// CONCAT - konketnikaciq
// raboti s nqkolko masiva 
// jelatelno e da se pravi taka [].concat(x,y,u); - kum prazen masiv da se dobavqd drugite
// ako iskame 


// let x = [1, 2, 3],
//     y = ['one', 'two', 'three'],
//     result = [],
//     item;

// for (item of x) {
//     result.push(item);
// }
// for (item of y) {
//     result.push(item);
// }
// console.log(result);

// // or CONCAT

// console.log(x.concat(y));

// ===
// call i appply produljenie na CONCAT
// ako iskame kum x da dobavim x,y,u - pravim go po na4ina [].concat(x,y,u)

// let arr = [1, 2, 3],
//     y = ['one', 'two'];

//arr.push(y);
//console.log(arr); // pushva no y vliza kato masiv tui kat e masiv

// arr.push.apply(y); // tuka shte razbie masiva i shte vkara stoinostite no ne kato masiv
// console.log(arr); // ( samo informativno , nqma da go polzvame za sega)

// ili 

// arr.push(...y,...y); // <--  pushva // y stava na string
// console.log(arr); //

// ili 

// ekvivalent result = [].concat(x,y);
// let reuslt = [...arr,...y]
// console.log(reuslt); // pushva no y vliza kato masiv tui kat e masiv

//========================================================================================= 
// SLICE 
// reje masiva

// let x = [1, 2, 3, 4, 5, 6, 7, 8, 9],
//     y;

// y = x.slice(1); // vsi4ki elementi ot dqsno
// y = x.slice(3,5) // ot 3 do 5 index

// console.log(y);

// // shao copy !!!
// // y = arr -> ako se promenya y shte se promeni i x
// // za da se izbegne tova se izpolzva y = x.slice() / kato shte vurne celiq x;

// y = x; 
// y[1] = 'two';
// console.log(x);

//========================================================================================= 
// SPLICE
// ednovremeno iztriva i dobavq
// edinstveniq metod s koito mojem da dobavim ili iztriem element ot sredata na masiva

// let x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
//     index = 6,
//     deleteCount = 2,
//     one = 'Nigga',
//     two = 'White';

// x.splice(index, deleteCount, one, two); // Se 4ete ot tozi index iztrii tolkova elementa i dobavi slednite elementi
// let result = x.splice(0,1); // shte iztrie purvi element
// x.splice(1,0,'yoo'); // da dobavq bez da triq
// x.splice(-3,0,'yoo'); // otzad napred

// console.log(x);
// console.log(result); // <- vrushta elementite koito e iztrilo

//========================================================================================= 
// SEARCHING IN ARRAYS
// INDEXOF / LASTINDEX OF - namirat ni nai 
// izpolzva se zamo za 4isla ili stringove // ne raboti za obekti


// let x = [1, 2, 3],
//     index;

// x = [...x, ...x];

// console.log(x.indexOf(1)); // namira purviq rezultat ot nai lqvo // ako nqma takuv index vrushta minus edno
// console.log(x.indexOf(1, 2)) // purvo sreshtane ot opredelen index;

//namirane na vsi4ki sreshtaniq 

// index = x.indexOf(1);

// while (index >= 0) {
//     console.log(index);
//     index = x.indexOf(1, index + 1);
// }

//========================================================================================= 
// Proverka dali e array

// let arr = [];

// console.log(!!arr.length); // <- proverqva dali e array like;

//========================================================================================= 
// EXCERCISES

//  Allocate array

// let n = 5,
//     i,
//     arr = new Array(5);

// for (let i = 0; i < arr.length; i += 1) {
//     arr[i] = i * n;
// }
// console.log(arr);

//========================================================================================= 
// Lexicographically compare

// let i = 4,
//     arr = ['hello', 'halo'];

// if (arr[0] > arr[1]) {
//     console.log('>');
// } else if (arr[0] < arr[1]) {
//     console.log('<');
// } else {
//     console.log('=');
// }


//========================================================================================= 
// Count equal values

// let arr = ['10', '10', '10', '10', '3', '10', '3', '2', '2', '2', '1'],
//     x,
//     y,
//     def = 0;

// for (x = 0; x <= arr.length; x += 1) {
//     let count = 0;

//     for (y = 0; y < arr.length; y += 1) {
//         if (arr[x] === arr[y] ) {
//             count += 1;
//         }
//     }

//     if (count > def) {
//         def = count
//     }
// }
// console.log(def);

//========================================================================================= 
// Maximal sequence


// let arr = ['10', '5', '5', '10', '3', '2', '2', '2', '1', '4', '4', '4', '3', '4', '4', '4', '4'],
//     x,
//     y,
//     largest = 0;


// for (x = 0; x < arr.length; x += 1) {

//     let counter = 1,
//         def = arr[x];

//     for (y = 1; y < arr.length; y += 1) {

//         if (def == arr[x + y]) {
//             counter += 1;
//         } else {
//             if (largest < counter) {
//                 largest = counter;
//             }
//             counter = 0;
//             break;
//         }
//     }
// }
// console.log(largest);


//========================================================================================= 
// Maximal increasing sequence

// let arr = ['2', '3', '4', '5', '6', '2', '1', '4', '5', '6', '7', '8', '4', '4', '4'],
//     x,
//     y,
//     largest = 0;


// for (x = 0; x < arr.length; x += 1) {

//     let def = parseInt(arr[x]),
//         count = 0;

//     for (y = 1; y < arr.length; y += 1) {

//         if (def + y == arr[y + x]) {
//             count += 1;
//         } else {
//             if (largest < count) {
//                 largest = count;
//             }
//             count = 0;
//             break;
//         }
//     }
// }
// console.log(largest);

//========================================================================================= 
// Maximal increasing sequence - one loop

// let arr = ['1', '2', '4', '5', '6'],
//     x,
//     y,
//     largest = 0,
//     count = 0;


// for (x = 0, y = 1; x < arr.length; x += 1, y += 1) {

//     if (parseInt(arr[x]) + 1 == parseInt(arr[y])) {
//         count += 1;
//     } else {
//         if (largest <= count) {
//             largest = count + 1;
//         }
//         count = 0;
//     }
// }
// console.log(largest);

//========================================================================================= 
// Selection sort
// Selection sort methood

// let arr = ['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20'],
//     len = arr.length,
//     x,
//     y,
//     min,
//     tpl,
//     yo;

// for (x = 0; x < len; x += 1) {

//     min = arr[x];

//     for (y = x + 1; y < len; y += 1) {

//         if (min > arr[y]) {
//             min = arr[y];
//             yo = y;
//         }

//     }

//     tpl = arr[x];
//     arr[x] = arr[yo];
//     arr[yo] = tpl;

//     console.log(min);
// }

//========================================================================================= 
// Frequent number

// let arr = ['1', '1', '1', '1', '4', '2', '13', '4', '9', '9', '9', '9', '9', '9'],
//     x,
//     y,
//     len = arr.length,
//     rep_num,
//     num,
//     max_count = 0;
// max_rep_num = 0;

// for (x = 0; x < len; x += 1) {

//     rep_num = arr[x];
//     count = 1;

//     for (y = x + 1; y < len; y += 1) {
//         if (rep_num == arr[y]) {
//             count += 1;
//             num = arr[x]
//         }
//     }
//     if (max_count < count) {
//         max_rep_num = num;
//         max_count = count;
//     }
// }
// console.log(max_rep_num, `${max_count} times`);


//========================================================================================= 
// Prime numbers 

// Sieve of Eratosthenes

// function isPrime(max) {

//     let len = max,
//         y,
//         x,
//         largest = 0;

//     for (x = 2; x <= len; x += 1) {

//         let isPrime = true;

//         for (y = 2; y < x; y += 1) {

//             if (x % y == 0) {
//                 isPrime = false;
//                 console.log(`${x} is not prime`);
//                 break;
//             }
//         }
//         if (isPrime == true) {
//             console.log(`${x} is prime`);
//             if ( largest < x) {
//                 largest = x;
//             }
//         }
//     }
//     return largest;
// }

// console.log(isPrime(44));

