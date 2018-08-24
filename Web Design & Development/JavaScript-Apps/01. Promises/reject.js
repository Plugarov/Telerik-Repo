const passField = document.querySelector('#pass-field');
const button = document.querySelector('#enter');
const messageField = document.querySelector('#message-field')



// The use of reject
// const promise = new Promise((resolve, reject) => {
//     setTimeout(() => {
//         let number = Math.random() * 6 + 1 | 0;
//         if (number >= 5) {
//             resolve(number);
//         } else {
//             reject(number);
//         }
//     }, 1000)
// });

// promise.then(
//     number => console.log('Success ' + number),
//     number => console.log('Error ' + number)
// );