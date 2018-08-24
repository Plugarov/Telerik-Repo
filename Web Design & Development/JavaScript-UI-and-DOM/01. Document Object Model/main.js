// Optimization
// try to append in one time

// if creating new ul
// var list = document.createElement('ul');

// for (let i = 0; i < 1000; i += 1) {
//     var el = document.createElement('li');
//     el.innerHTML = i;
//     list.appendChild(el);
// }

// if adding to existing one

var list = document.createDocumentFragment();

for (let i = 0; i < 1000; i += 1) {
    var el = document.createElement('li');
    el.innerHTML = i;
    list.appendChild(el);
}

document.getElementById('list').appendChild(list);

// document.body.appendChild(list);

// // Doc create elements
// var img = document.createElement('img');
// var el = document.getElementById('5');

// el.insertBefore(img, el.children[0]);

//

// var paragraph = document.createElement('p');
// paragraph.innerHTML = "<p>Привет!</p>";
// var ell = document.getElementById('1');

// ell.insertBefore(paragraph, ell.children[0]);

// // Removing
// el.removeChild(img);

// // Remove div
// var body = document.body;

// var elementDiv = document.getElementById('a');

// body.removeChild(elementDiv);

// // Changing

// document.getElementById('4').children[0].style = 'color:red';



// Traversing DOM

// let result = document.getElementById('par');
// result.innerHTML = "Was here";

// function traverseName(el, ident) {
//     console.log(ident + '<' + el.tagName.toLowerCase() + '>');

//     var children = [].slice.apply(el.children);

//     children.forEach(x => traverseName(x, ident + ' '));
//     console.log(ident + '</' + el.tagName.toLowerCase() + '>');

// }

// traverseName(document.body, '');


// Changing the styles

//var el = document.getElementById('par');
//el.style='font-size:42px';
//use el.style.color = 'red';

//get parent 
//el.parentNode
//el.parentElement