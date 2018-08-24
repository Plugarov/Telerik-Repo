// event order capturing event chain

var el = [].slice.apply(document.getElementsByTagName('div'));
el.forEach(function (element) {
    element.addEventListener('click', function (el) {
        console.log(element);
    })
}, this);

// // adds # to every list item but it does slow

// var df = document.createDocumentFragment();

// for (var i = 0; i < 32; i += 1) {
//     var li = document.createElement('li');
//     li.innerHTML = i;

//     df.appendChild(li);
// }

// var ul = document.getElementsByTagName('ul')[0];

// ul.appendChild(df);

// ul.addEventListener('click', function (e) {
//     if (e.target.tagName !== 'LI') {
//         return;
//     }
//     e.target.innerHTML += '#';
// });



// it adds to every li this function which is not ok
// var elements = [].slice.apply(document.getElementsByTagName('li'));
// elements.forEach(function (element) {
//     element.addEventListener('click', function () {
//         element.innerHTML += '#';
//     })
// }, this);

// // chat demo app

// var el = document.getElementById('input');
// var messageContainer = document.getElementById('message-container');


// function sendMessage() {
//     var msg = el.value;
//     el.value = '';

//     var msgEl = document.createElement('p');
//     msgEl.innerHTML = msg;

//     messageContainer.appendChild(msgEl);
// }


// el.addEventListener('keydown', function (element) {
//     if (element.keyCode === 17) {
//         sendMessage();
//     }
// });

// document.getElementById('send-button').
// addEventListener('click', sendMessage);



// on click property // click, keypress, keydown, which

// el.addEventListener('click', function (element) {
//     el.value = 'as';
// });


// On click and delete

// var arr = [].slice.apply(el);
// arr.forEach(function (element) {
//     element.onclick = function () {
//         alert('Clicked');
//     }
// });

// var el = document.getElementsByTagName('img')[1];

// el.onclick = function () {
//     el.parentElement.removeChild(el);
// }

// with event listener / prepo4itan na4in za zakarane na eventi
// el.addEventListener('click', function () {
//     el.parentElement.removeChild(el);
// });


// Click hold, click release, click change box
// els[i].addEventListener('click', function () {
//     if (selectedBox) {
//         selectedBox.style.background = '';
//     }
//     if (selectedBox && selectedBox === this) {
//         selectedBox = null;
//     }
//     else {
//         this.style.background = 'regred';

//         selectedBox = this;
//     }

// });