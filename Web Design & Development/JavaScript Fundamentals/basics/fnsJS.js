// Reverse number

'use strict';
//  hello world / split(' ') -> ['hello','world']
// ['hello','world'] / join() -> helloworld
// indexOf - page 116
// // Random letter excersise - charAt - page 226
// substring(1, 0); - gets first letter
// substring(2, 1); - gets second letter
// All words to upper case excersise - toUpperCase()- all to uppercase
// Count vowels excersise - count = vtr.match(/[AEIOUaeiou]/g); - get number of matches
// Longest word excersise word = toString.match(/\w[a-z]{0,}/gi) - finds all words
// indexOf - lettersContained.indexOf(letter) - if yes shows the position otherwise -1


// let a = 'abc'.indexOf('b'); - returns position of specified letter
// let b = 'cde'.charAt(1); - returns letter on specified position


// Random word excersise
// charAt
// Math.random()
// Math.floor()
// Math.pow(7, 2); // 49

// var num = 123 + "";
// var spl = num.split("");
// var rev = spl.reverse();
// var join = rev.join("");

// SORTING - change to y-x or 0 depends on sort
//	let res = arr.sort(function(x,y){
//		 return x-y
//	});


// num = 123+"";
// num = num.split('').reverse().join("");
// console.log(num);

// split reverse join

//========================================================================================= 
// 1. Write a JavaScript function that reverse a number.

// function strReverse(str) {
// 	let split = str.split('').reverse().join('');
// 	return split;
// }

// console.log(strReverse('abcd'));

//========================================================================================= 
//  2. Write a JavaScript function that checks whether a passed string is palindrome or not?

// function check(wordd) {
// 	let word = wordd.toLowerCase().replace(/[^a-zA-Z0-9]+/g, '');
// 	let count;

// 	if (word % 2 === 0) {
// 		count = (word.length) / 2
// 	} else {
// 		count = (word.length - 1) / 2
// 	}
// 	for (let x = 0; x < count; x += 1) {

// 		if (word[x] != word.slice(-1 - x)[0]) {
// 			return false;
// 		}
// 	}
// 	return true;
// }
// console.log(check('nurses run'));

//========================================================================================= 
//	3.


//========================================================================================= 
//	4. Write a JavaScript function that returns a passed string with letters in alphabetical order.

// function sort(word) {
// 	word = word.toLowerCase().replace(/[^a-zA-Z]+/g, '');
// 	let split = word.split('');
// 	return split.sort().join('');
// }
// console.log(sort('Everyhing'));


//========================================================================================= 
//	5. Write a JavaScript function that accepts a string as a parameter and converts the first letter of each word of the string in upper case

// function toUpper(word2) {

// 	let word2 = word2.split(' ');
// 	let count = word2.length;
// 	let b = [];

// 	for (let x = 0; x < count; x += 1) {
// 		word = word2[x];
// 		b[x] = word.replace(word[0][0], word[0][0].toUpperCase());
// 	}

// 	b = b.join(' ');

// 	return b;
// }
// console.log(toUpper('You can write whatever you want'));

//========================================================================================= 
//	6. Write a JavaScript function that accepts a string as a parameter and find the longest word within the string. 

// function longestWord(word) {

// 	let b = word.match(/\w[a-z]{0,}/gi);
// 	let res = b[0];

// 	for (let x = 1; x < b.length; x += 1) {
// 		if (res.length < b[x].length) {
// 			res = b[x];
// 		}
// 	}
// 	return res;
// }
// let fns = longestWord('Check loooong asdasd');

// console.log(fns);

//========================================================================================= 
//	7. Write a JavaScript function that accepts a string as a parameter and counts the number of vowels within the string.
// REGEX 

// function countVowels(str) {
// 	count = str.match(/[AEIOUaeiou]/g);

// 	return count.length;

// }
// res = countVowels('The quick brown fox');
// console.log(res);


//========================================================================================= 
//	7. Write a JavaScript function that accepts a string as a parameter and counts the number of vowels within the string.

// indexOf - lettersContained.indexOf(letter) - if yes shows the position otherwise -1

// function vowel_count(str1) {
// 	let vowelList = 'aeiouAEIOU';
// 	let counter = 0;
// 	for (let x = 0; x < str1.length; x++) {
// 		if (vowelList.indexOf(str1[x]) !== -1) {
// 			counter += 1;
// 		}
// 	}
// 	return counter;
// }
// console.log(vowel_count("The quickaat brown fox"));

//========================================================================================= 
//	8. Write a JavaScript function that accepts a number as a parameter and check the number is prime or not

// function test_prime(n) {
// 	if (n === 1) {
// 		return false;
// 	} else if (n === 2) {
// 		return true;
// 	} else {
// 		for (var x = 2; x < n; x++) {
// 			if (n % x === 0) {
// 				return false;
// 			}
// 		}
// 		return true;
// 	}
// }
// console.log(test_prime(23));

//========================================================================================= 
//	9.
//========================================================================================= 
//	10.
//========================================================================================= 
//	11.
//========================================================================================= 
//	12.
//========================================================================================= 
//	13.
//========================================================================================= 
//	14.
//========================================================================================= 
//	15.

//========================================================================================= 
//	16. Write a JavaScript function to extract unique characters from a string. 

// function unique_char(str1) {
// 	var str = str1;
// 	var uniql = "";
// 	for (var x = 0; x < str.length; x++) {
// 		if (uniql.indexOf(str.charAt(x)) == -1) {
// 			uniql += str[x];
// 		}
// 	}
// 	return uniql;
// }
// console.log(unique_char("thequickbrownfoxjumpsoverthelazydog"));

//========================================================================================= 
//	17.Write a JavaScript function to get the number of occurrences of each letter in specified string.

// function Char_Counts(str1) {
// 	var uchars = {};
// 	str1.replace(/\S/g,
// 		function(l) {
// 			uchars[l] = (isNaN(uchars[l]) ? 1 : uchars[l] + 1);
// 		}
// 	);
// 	return uchars;
// }
// console.log(Char_Counts("The quick brown fox jumps over the lazy dog"));

//========================================================================================= 
//	19. Write a JavaScript function that returns array elements larger than a number. 

// function BiggerElements(val) {
// 	return function(evalue, index, array) {
// 		return (evalue >= val);
// 	};
// }
// var result = [11, 45, 4, 31, 64, 10].filter(BiggerElements(10));
// console.log(result);

// return 
// arr = ['a', 'b', 'c', 4, 5, 6, 7];
// let res = arr.filter(fns);
// function fns(value, index) {
// 	return typeof value === 'string'
// }
// console.log(res);

//========================================================================================= 
//	20. Write a JavaScript function that generates a string id (specified length) of random characters.

// function random(str) {
// 	var char_list = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
// 	let word = "";

// 	for (let x = 0; x < str; x++) {
// 		word += char_list.charAt(Math.floor(Math.random() * char_list.length));
// 	}
// 	return word;
// }
// let res = random(5);
// console.log(res);

//========================================================================================= 
//22. Write a JavaScript function that accepts two arguments, a string and a letter and the function will 
//count the number of occurrences of the specified letter within the string.

// function checkOccurrences(str, y) {
// 	let count = 0;
// 	for (let x = 0; x < str.length; x += 1) {

// 		if (str[x] == y) {
// 			count += 1;
// 		}

// 	}
// 	return count;
// }

// console.log(checkOccurrences('w3school', 'w'));

//========================================================================================= 
//	23. Write a JavaScript function to find the first not repeated character. 

// function find_FirstNotRepeatedChar(str) {

// 	let arr = str.split(''),
// 		count = 0,
// 		res;

// 	for (let x = 0; x < arr.length; x += 1) {
// 		count = 0;
// 		for (let y = 0; y < arr.length; y += 1) {

// 			if (arr[x] === arr[y]) {
// 				count += 1;
// 			}
// 		}
// 		if (count < 2) {
// 			res = arr[x];
// 		}
// 	}
// 	return res;
// }
// console.log(find_FirstNotRepeatedChar('abacddbec'));

//=========================================================================================
//	25. Write a JavaScript function that accept a list of country names as input 
//and returns the longest country name as output.

// function longestCountryName(arr) {

// 	let compare = arr[0];

// 	for (let x = 1; x < arr.length; x += 1) {
// 		if (compare.length < arr[x].length) {
// 			compare = arr[x];
// 		}
// 	}

// 	return compare;
// }

// console.log(longestCountryName(["Australia", "Germany", "Bangladesh", "China"]))

//========================================================================================= 
//	25. Using REDUCE

// function Longest_Country_Name(country_name) {

// 	return country_name.reduce(function(a, b) {
// 		return a.length  > b.length  ? a : b;
// 	});
// }
// console.log(Longest_Country_Name(["Australia", "Germany", "United States of America"]));

//========================================================================================= 
// ADDITIONAL Retrieve data from oobject array and put the results in array 
// HIGHER ORDER FUNCTIONS
// MAP FILTER REJECT REDUCE

// let animals = [
// {	name: 'John',	spacies: 'dog'},
// { 	name: 'Pussy',	spacies: 'cat'},
// {	name: 'Clara',	spacies: 'turtulle'}
// ];
// let names = [];
// for ( x = 0; x < animals.length; x++ ){
// 	names.push(animals[x].name);
// }
// console.log(names);

// MAP 

// let animals = [
// {	name: 'John',	spacies: 'dog'},
// { 	name: 'Pussy',	spacies: 'cat'},
// {	name: 'Clara',	spacies: 'turtulle'}
// ];

// let names = animals.map(fns)
// function fns(value,index) {
// 	return animals[index].name+' is '+animals[index].spacies;
// }

// let alternative = animals.map((animala) => animala.name+' is a '+animala.spacies);
// console.log(alternative);

// REDUCE
