'use strict'

//=======================================================================================//
//                                      Strings                                          //
//=======================================================================================//

//========================================================================================= 
//                                      BASIC                                            //

// type of strings 'string' "string" `string`
// primitive as everything but objects
// imutable - in order to edit have to rewrite it
// `` = interpulaciya

// // make an obj // 
// let str = new String('Yo nigga');

// console.log(str);
// console.log(str.length);


// convert to number //

// function convertToNumber(str) {
//     return +str;
// }

// parseInt(str)
// number(str)

//========================================================================================= 
//                                      ChartAt                                          //

// let str = 'asdad'

// console.log(str.charAt(1));
// console.log(str[1]);

// let startTime = new Date();

// for (let x = 0; x < 10000000; x += 1) {
//     str.charAt(1)
// }

// let endTIme = new Date();

// console.log('time ' + `${endTIme - startTime}`);

//========================================================================================= 
//                                      Concat                                          //

// let First = 'First'
// let Last = 'Last'

// console.log(First.concat(Last, 'spam'));

// -- //

// let all = [
//     'str1',
//     'str2',
//     'str3',
// ]

// let str = ''.concat(...all);
// console.log(str);


//========================================================================================= 
//                                      replace                                          //

// let str = 'Meet John'.replace('John','Bob');
// console.log(str);

//========================================================================================= 
//                                       search                                          //
// can work with regex   

// let str = 'Meet John'.search('John');
// console.log(str);

//========================================================================================= 
//                                       indexOf                                         //

// TODO 36 new ex


// can't work with regex   
// moje da zadavash nachalna poziciq
// vrushta -1

// let str = 'Meet John'.indexOf('John');
// console.log(str);

//===========================================
// find all

// let str = 'aasdfaasfdsaasdfasdf',
//     arr = str.split(''),

//     i = 0;

// while (true) {
//     let index = str.indexOf('a', i)
//     if (index < 0) {
//         break;
//     }
//     i = index + 1;
//     console.log(index);
// }

//========================================================================================= 
//                                       split                                         /

// let str = '4 3 6 7 8';
// let arr = str.split(' ');
// console.log(arr);

// function solve(arhs) {
//     let arr = str.split(' ').map(Number), // n=> +n // n=> parseInt(n) //
//         sum = arr.reduce((x, y) => x + y)
//     console.log(sum);
// }

// solve('1 2 3')

//===========================================
// weird spaces

// let str = '3 4  3  4 4 6 7  3 3 2  2'
// console.log(str.split(' ').filter(n => n !== ''));



//========================================================================================= 
//                                       trim                                            //
// trimleft // trimright


// let str = '     @   4 5 6    ';
// console.log(str);
// console.log(str.trim());
// console.log(str);


//========================================================================================= 
//                                       substr                                          //
// otrqzvate v na4aloto , otrqzvate ot kraq
// substr (start, length)




//========================================================================================= 
//                                       substring                                       //
// substring(start,end)

// let myName = 'Hello, my name is Aahmed.'
// console.log(myName.substring(myName.indexOf('A'), myName.indexOf('.')));


//========================================================================================= 
//                                        valueOf                                        //
// za absolutno nsh ne trq

// let str = 'https://www.youtube.com/watch?v=YySyxPWv7QQ';
// console.log(str.valueOf());

//========================================================================================= 
//                                        concat                                         //
// valueto se kopira a ne se editva 
// za stari brouseri join()

// function replicate(str, count) {
//     let result = ''
//     while (count > 0) {
//         result += str;
//         count -= 1;
//     }
//     return result
// }
// console.log(replicate('1', 4));

// // po dolnoto e po burzo 

// function replicate2(str, count) {
//     let arr = new Array(count);
//     arr.fill(str);
//     return ''.concat(...arr);
// }
// console.log(replicate2('1', 4));

//========================================================================================= 
//                                        String escaping                                //

// let str = 'Hello whats up "nigga" ';
// let str1 = "Hello what's up nigga";
// let str2 = `Hello what's up "nigga" `;
// let str3 = 'Hello what\'s up "nigga" ';

// console.log(str)
// console.log(str1)
// console.log(str2)
// console.log(str3)

//========================================================================================= 
//                                        HTML escaping                                  //

//&#52 - shte eskapne 52 element to ASCII tablicata

//<p> <pesho> </p> shte ekzekutne pesho kato nqkuv tag 
// no ako se eskapne shte printne prosto kakto e <pesho>
//<p> &lt;pesho&gt; </p>

//===========================================
// escape example
// purvo ampersanta se replaceva za da mogat da rabotqt drugite

// String.prototype.htmlEscape = function () {
//     let escapeStr = String(this)
//         .replace(/&/g, 'amp;')
//         .replace(/</g, '&lt;')
//         .replace(/>/g, '&rt;');
//      return escapeStr;
// }

// let str = '<hello> & <bye>';
// console.log(str);
// console.log(str.htmlEscape());


//===========================================
// escape example TRIM

// let str = ' ,.,...  Hi,George ., ...,;';

// String.prototype.escapeChars = function (chars) {

//     let disabledChars = {};

//     for (let char of chars) {
//         disabledChars[char] = true;
//     }

//     let startIndex = 0;

//     while (startIndex < this.length) {
//         if (!disabledChars[this[startIndex]]) {
//             break;
//         }
//         startIndex += 1;
//     }

//     let endIndex = this.length - 1;

//     while (startIndex < endIndex) {
//         if (chars.indexOf(this[endIndex]) < 0) {
//             break;
//         }
//         endIndex -= 1;
//     }

//     return this.substring(startIndex, endIndex + 1);

// }

// console.log(str.escapeChars(' ,.;'));

//========================================================================================= 
//                                        PadLeft                                        //

// let str = 123;

// String.prototype.padLeft = function (count, char) {

//     char = char || ' ';

//     const len = this.length;
//     const toAddCount = count - len;
//     if (toAddCount <= 0) {
//         return this;
//     }
//     return ''.concat(...(new Array(toAddCount)).fill(char), this);
// }

// console.log('500'.padLeft(10, '@'));

//========================================================================================= 
//                                          chaining

// let arr = [1,2,3]
// console.log(''.concat(...arr.fill(1)));
// 111

//========================================================================================= 
//                                       search                                          //


//========================================================================================= 
//                                       EXCERCISES                                      //

//===========================================
// Reverse string
// many variants
// choose the slowest one
// http://stackoverflow.com/questions/958908/how-do-you-reverse-a-string-in-place-in-javascript

// console.log('123456'.split('').reverse().join(''));

//===========================================
//  Sub-string in text

// let str = 'in We are living in an yellow submarine. We don\'t have anything else in. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 daysin'

// function searchStr(str, find) {
//     let len = str.length,
//         count = 0,
//         result = 0;

//     for (let x = 0; x < len; x += 1) {
//         if (str.indexOf(find, x) !== -1) {
//             let c = str.indexOf(find, x);
//             x = c;
//             result += 1;
//         }
//     }
//     console.log(result);
// }

// searchStr(str, 'submarine.');

//===========================================
//  nbsp

// let str = 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.'

// let a = function() {
//     return '&nbsp';
// }

// String.prototype.htmlEscape = function () {
//     let escapeStr = String(this)
//         .replace(/ /g, a);
//     return escapeStr;
// }

// console.log(str.htmlEscape());

//===========================================
//  Parse URL


// let url = 'http://telerikacademy.com/Courses/Courses/Details/239';

// function parseUrl(url) {

//     let len = url.length,
//         protocol = '',
//         server = '',
//         resource = '';

//     protocol = url.substring(0, url.indexOf('://'));
//     server = url.substring(protocol.length + 3, url.indexOf('/', protocol.length + 3));
//     let val = server.length + protocol.length;
//     resource = url.substr(val + 3, val + 6);

//     console.log(protocol);
//     console.log(server);
//     console.log(resource);

// }
// parseUrl(url);

//===========================================
//  Parse URL // weird but works

// let str = [
//     '<html>',
//     '  <head>',
//     '    <title>Sample site</title>',
//     '  </head>',
//     '  <body>',
//     '    <div>text',
//     '      <div>more text</div>',
//     '      and more...',
//     '    </div>',
//     '    in body',
//     '  </body>',
//     '</html>'
// ];

// console.log('Start');

// function extractText(str) {

//     let result = str.join('')
//         .replace(/  /g, '')
//         .replace(/<html>/g, '')
//         .replace(/<head>/g, '')
//         .replace(/<title>/g, '')
//         .replace(/<div>/g, '')
//         .replace(/<body>/g, '')
//         .replace(/<\/html>/g, '')
//         .replace(/<\/head>/g, '')
//         .replace(/<\/title>/g, '')
//         .replace(/<\/div>/g, '')
//         .replace(/<\/body>/g, '')

//     console.log(result);
// }

// extractText(str);

//===========================================
//  replace tags

// let str = ['<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>']
// let test = '<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>'

// function replaceTags(arr) {

//     let str = arr[0],

// }
// replaceTags(str);

//========================================================================================= 
//                                       Regular expressions                             //
//========================================================================================= 

// wroks with replace(),split() and search();


//===========================================
//  All 'l'-s

// console.log('hello'.replace(/l/g, '@')); // global search /g

//===========================================
//  Build

// let regex = new RegExp('l', "g"); // buld regex
// console.log('Hello nigga'.replace(regex, 'y'));

//===========================================
//  Escape

// let regex2 = new RegExp('\\[', "g"); // exit with two \\
// console.log('Hello [nigga'.replace(regex2, ''));

//===========================================
//  purvi / posleden simvol $/^

// let regex3 = new RegExp('y$', "g");
// let regex4 = new RegExp('^y', "g");
// console.log('yelloy'.replace(regex3, ''));
// console.log('yelloy'.replace(regex4, ''));


//======================================================================================
//                                           FLAGS

//g global search
//m multiline search
//i case sensitive
//y sticky ???

//======================================================================================
//                                    Special characters                              //

// ^ $ - nachalo i krai na red. za po strogo tursene . primer chislata

//===========================================
// * //  0 ili poveche puti 

// let str = 'asdasd111 gosho11  ';

// console.log(str.match(/1*/g)); // nula ili poveche puti
// console.log((str.match(/[a-z]1*/g))); // vs bukvi v bukva i mn edinici
// console.log((str.match(/[a-z]*1/g))); // bukvi az words i edinica edinstvena

//===========================================
// + // 1 ili poveche puti / toest zaduljitelno da go ima

// let str = 'asdasd111 gosho11  ';

// console.log(str.match(/[a-z]1+/g)); // nula ili poveche puti

//===========================================
// ? // 0 ili 1 puti / toest zaduljitelno da go ima

// let str2 = 'asdasd111 gosho11  ';

// console.log(str2.match(/[a-z]1?/g)); 

//===========================================
// . // machva to4ka i vsi4ko samo ne nov red

// let str2 = 'aaaa 11aa aa111';

// console.log(str2.match(/[a-z].+1/g)); 

//===========================================
// |  // pesho ili gosho

// let str = 'pesho e gosho';

// console.log(str.match(/pesho|gosho/g));

// console.log(str.match(/(p|P)esho|gosho/g)); 

//===========================================
// match tireto

// let str = '2 43 3 45 45 -  -242- 23-4 234- 4-';

// console.log(str.match(/[0-9-]+/g));


//===========================================
// ^ // da ne e cifra in case

// let str = '2 43 3 45 45 a -  -242- 23-4 234- 4-';

// console.log(str.match(/[^0-9]+/g));


//===========================================
// {5} - da se povtarq 5 puti
// {5,10}

// let str = '231312';

// console.log(str.match(/^[0-9]{6}$/g)); // tochno shtest cifri
// console.log(str.match(/^[0-9]{5,7}$/g)); // mejdu 5 i 7


//===========================================
// nov red i multiline search // printva purvoto ot vseki red

// let str = '3423\n234';
// console.log(str.match(/^./gm)); 

//===========================================
// prazen red

// let str = '3423\n\n234';
// console.log(str.match(/^$/gm).length); 


//======================================================================================
//                                    Special characters additional                   //

// \s ->[ \t \n \r]
// \S - [ ^\t \n \r] inverta na s

// d - cifra
// \D - da ne e cifra
// \w - alfa numeric underscore
// \W da ne e w

//===========================================
// vsqka purva duma kudeto ima edna cifra

// let str = 'zero asdfasdf asdf7\n aasdfsdfsdf \none asdfsdf9';

// console.log(str.match(/^.*[\d].*$/gm)
//     .map(n => n.replace(/\s.*$/gm, '')));

//===========================================
// MATCH GROUPS

// let str = 'Some long text <img src="smiley.gif" alt="Smiley face" height="42" width="42"> very long';

// console.log(str.match(/<img src="[^>]*"[^>]*>/g));




//======================================================================================
//                                        Reg Methods                                 //

//===========================================
// test

// let telephone = /^[0-9]{10}$/; // to4no 10 simvola 

// console.log(telephone.test('4234234234'));

// //===========================================
// // exec

// let regexx = /[0-9]/;

// console.log(regexx.exec(' sadfasdf asdf 4234234234')); // kazva kude namira suvpadenie

// //===========================================
// // exec mogat da se izrqdiqt vsi4kite matchove i da pokajat indexite

// let regexxx = /[0-9]/g;

// console.log(regexxx.exec(' sadfasdf asdf 4234234234'));
// console.log(regexxx.exec(' sadfasdf asdf 4234234234'));
// console.log(regexxx.exec(' sadfasdf asdf 4234234234'));

// //===========================================
// //  Split with regex
// // + poveche ot edin simvol
// // \s space

// let str = '4   5, 6,,   7 ';

// str.split(/[\s,]+/g)
//     .map(Number)
//     .forEach(n => console.log(n))


