'use strict';

var library = (function() {
    
    var books = [];
    var categories = [];

    function addBook(title, author, ISBN, category) {
        if(!IsString(title, 3, 100)) {
            throw new Error('Invalid title');
        }            
        books[books.length + 1] = { title, author, ISBN, category };
    }

    function addCategory(name) {
        if(!IsString(name, 3, 100)) {
            throw new Error('Invalid name');
        }      
        categories[categories.length + 1] = name;
    }
 
    function getBooks() {
        return books;
    }

    function getCategories() {
        return categories;
    }

    return {
        addBook: addBook,
        addCategory: addCategory,
        getBooks: getBooks,
        getCategories: getCategories
    };
})();

function IsString(title, minStrLen, maxStrLen) {
    var isValid = true;
    if (typeof title !== 'string' || 
        title.length < minStrLen ||
        title.length > maxStrLen) {
            isValid = false;
        }
    return isValid;           
}

library.addCategory("Thriller");
library.addCategory("Action");
library.addBook('ass','b','4',"Thriller");
library.addBook('ass','b','4',"Thriller");
library.addBook('ass','b','4',"Action");

library.getBooks().forEach(function(element) {
    console.log(element);
}, this);

library.getCategories().forEach(function(element) {
    console.log(element);
}, this);
