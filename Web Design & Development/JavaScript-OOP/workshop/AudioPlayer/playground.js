// var parent = {
//     init: function (title, author) {
//         this.title = title;
//         this.author = author;
//         return this;
//     },
//     get: function fn1() {
//         return this.value;
//     },
//     value: 5,
// }

// duplicate code
// var child = Object.create(parent);
// child.get = function fn2() {
//     return this.value + '!';
// // }

// var child = Object.create(parent);
// child.get = function fn2() {
//     return parent.get.call(this) + '!';
// }

// child.value = 10;


// child.init('yoo', 'nigga');
// parent.init('white', 'nigga');
// console.log(child.title);
// console.log(parent.title);
// console.log(parent.get());
// console.log(child.get());\

// the NEW keyword
var book = (function () {
    function book(name) {
        this.name = name;
    }
    return book;
}());

var b = new book('namm');
console.log(b.name);