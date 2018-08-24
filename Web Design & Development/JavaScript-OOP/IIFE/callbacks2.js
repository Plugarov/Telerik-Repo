https://github.com/TelerikAcademy/JavaScript-Applications/tree/master/Topics/01.%20Promises%20and%20asynchronous%20programming
https://github.com/TelerikAcademy/JavaScript-Applications/tree/master/Topics/01.%20Promises%20and%20asynchronous%20programming/demos/1.%20callbacks


//
// Same as next
// document.getElementById('drop-bomb').onclick = () => { console.log(1) };

//
// On click reurns 1
// var sayHello = function () {
//     console.log(1);
// };
// document.getElementById('drop-bomb').onclick = sayHello;

//
//  Reurns 1 whitout clicking
// var sayHello = function () {
//     console.log(1);
// };
// document.getElementById('drop-bomb').onclick = sayHello(); // see here

//
// On click reurns 1
// function sayHello() {
//     console.log(1);
// };
// document.getElementById('drop-bomb').onclick = sayHello(); // see here

//
//  Reurns 1 whitout clicking
// function sayHello() {
//     console.log(1);
// };
// document.getElementById('drop-bomb').onclick = sayHello(); // see here


//
// Prints boom and bomb drop time
// function dropBomb(success) {
//     setTimeout(function () {
//         document.getElementById("bomb").innerHTML = "BOOOM";
//         var bombDropDateTime = new Date();
//         success(bombDropDateTime);
//     }, 2000);
// }
// function reportBombDrop(time) {
//     document.getElementById("bomb-report").innerHTML = "Bomb dropped at " +
//         time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds();
// }
// document.getElementById("drop-bomb").onclick = function () {
//     dropBomb(function (time) {
//         document.getElementById("bomb-report").
//             innerHTML = "Bomb dropped at " +
//             time.getHours() + ":" +
//             time.getMinutes() + ":" +
//             time.getSeconds();
//     });
// }
