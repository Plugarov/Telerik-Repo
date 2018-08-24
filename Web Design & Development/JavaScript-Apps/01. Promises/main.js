// var container = document.getElementById('container');
// var button = document.getElementById('button');


// Promisies

// Reject


// Solve

// function waitASecond() {
//     return new Promise((res, rej) => {
//         setTimeout(res, 1000);
//     });
// }

// const createP = (function () {
//     var count = 0;

//     return function () {
//         const p = document.createElement('p');
//         p.innerText = count += 1;
//         container.appendChild(p);
//     }
// })();

// let promise = new Promise((resolve, reject) => {
//     setTimeout(() => resolve(), 1000);
// }); 

// promise
//     .then(value => {
//         createP()
//         return new Promise((resolve, reject) => {
//             setTimeout(() => resolve(), 1000);
//         });
//     })
//     .then(value => {
//         createP()
//         return new Promise((resolve, reject) => {
//             setTimeout(() => resolve(), 1000);
//         });
//     });

// waitASecond()
//     .then(() => {
//         createP();
//         return waitASecond();
//     })
//     .then(() => {
//         createP();
//         return waitASecond();
//     });



// The problem
// callbacks funcs in a row
// setTimeout(function () {
//     const p = document.createElement('p');
//     p.innerText = '1';
//     container.appendChild(p);

//     setTimeout(function () {
//         const p = document.createElement('p');
//         p.innerText = '2';
//         container.appendChild(p);

//         setTimeout(function () {
//             const p = document.createElement('p');
//             p.innerText = '3';
//             container.appendChild(p);
//         }, 1000);
//     }, 1000);
// }, 1000);

//Callback to get geolocation

// Should also watch about exceptions ~15-30min
// button.addEventListener('click', () => {
//     setTimeout(() => {
//         var button = document.createElement('button');
//         button.innerText = `Click counter: ${count += 1}`;
//         container.appendChild(button);
//     }, 1000);
// });



