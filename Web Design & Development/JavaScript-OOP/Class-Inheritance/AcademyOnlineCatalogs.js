
const getid = (function () {
    var id = 0;

    return function () {
        id += 1;
        return id;
    };
}());

const Validator = {
    validatenameLength: function (name) {
        if (name.length < 2 || name.length > 40) {
            throw 'name length ex';
        }
    },

    validatedescriptionNotEmptyStr: function (description) {
        if (description.length === 0) {
            throw 'description should be non-empty string';
        }
    },

    validateDurationGraterThanZero: function (duration) {
        if (duration < 1) {
            throw 'Number should be greater than.';
        }
    },

    validateisbnLength(isbn) {
        var isnum = /^\d+$/.test(isbn);
        if (isbn.length !== 13 && isbn.length !== 10) {
            throw 'A isbn with length exactly 10 or 13.'
        }
        if (!isnum) {
            throw 'isbn should contain only numbers.'
        }
    },

    validategenreLength(genre) {
        if (genre.length < 2 || genre.length > 20) {
            throw 'A string with length between 2 and 20 characters, inclusive.';
        }
    },

    validateRaiting: function (rating) {
        if (rating < 1 || rating > 5) {
            throw 'Rating should be between 1 and 5, inclusive.';
        }
    }
}

class Item {
    constructor(description, name) {
        this.id = getid();
        this.description = description;
        this.name = name;
    }

    get id() {
        return this._id;
    }
    set id(id) {
        this._id = id;
    }

    get description() {
        return this._description;
    }
    set description(description) {
        Validator.validatedescriptionNotEmptyStr(description)
        this._description = description;
    }

    get name() {
        return this._name;
    }
    set name(name) {
        Validator.validatenameLength(name);
        this._name = name;
    }
}

class Book extends Item {
    constructor(isbn, genre, description, name) {
        super(description, name);
        this.isbn = isbn;
        this.genre = genre;
    };

    get isbn() {
        return this._isbn;
    }
    set isbn(isbn) {
        Validator.validateisbnLength(isbn);
        this._isbn = isbn;
    }

    get genre() {
        return this._genre;
    }
    set genre(genre) {
        Validator.validategenreLength(genre);
        this._genre = genre;
    }
}

class Media extends Item {
    constructor(duration, rating, description, name) {
        super(description, name);
        this.Duration = duration;
        this.Rating = rating;
    }

    get Duration() {
        return this._duration;
    }
    set Duration(duration) {
        Validator.validateDurationGraterThanZero(duration);
        this._duration = duration;
    }

    get Rating() {
        return this._rating;
    }
    set Rating(rating) {
        Validator.validateRaiting(rating);
        this._rating = rating;
    }
}

class Catalog {
    constructor(name) {
        this.id = getid();
        this.name = name;
        this.items = [];
    }

    get id() {
        return this._id;
    }
    set id(id) {
        this._id = id;
    }

    get name() {
        return this._name;
    }
    set name(name) {
        Validator.validatenameLength(name);
        this._name = name;
    }

    get items() {
        return this._items;
    }
    set items(item) {
        this._items = item;
    }

    add(...items) {
        if (Array.isArray(items[0])) {
            items = items[0];
        }

        if (items.length === 0) {
            throw 'Empty value/s passed.';
        }

        this.items.push(...items);

        return this;
    }

    find(x) {
        if (typeof x === 'number') {
            for (let item of this.items) {
                if (item.id === x) {
                    return item;
                }
            }

            return null;
        }

        if (typeof x === 'object') {
            if (x !== null && typeof x === 'object') {
                return this.items.filter(function (item) {
                    return Object.keys(x).every(function (prop) {
                        return x[prop] === item[prop];
                    });
                });
            }

            throw 'Invalid type or options.'
        }
    }

    findOptions(options) {

    }

    search(pattern) {
        var result = [];
        this.items.forEach(function (element) {
            if (element.description.indexOf(pattern) !== -1 ||
                element.name.indexOf(pattern) !== -1) {
                result.push(element);
            }
        }, this);
        return result;
    }
}

class BookCatalog extends Catalog {

    constructor(name) {
        super(name);
    }

    add(...books) {
        if (Array.isArray(books[0])) {
            books = books[0];
        }

        books.forEach(function (x) {
            if (!(x instanceof Book)) {
                throw 'Must add only books';
            }
        });

        return super.addItem(...books);
    }

    getgenres() {
        let uniq = {};
        this.items.forEach(x => uniq[x.genre] = true);
        return Object.keys(uniq);
    }

    find(x) {
        return super.find(x);
    }

}

class MediaCatalog extends Catalog {
    //TODO
}

var book1 = new Book('1234567890', 'horror', 'desc1', 'Matrix');
var book2 = new Book('1234567890123', 'horror', 'desc2', 'Matrix');
var catalog = new Catalog('Movies');
catalog.add([book1, book2]);
console.log(catalog.find({ name: 'Matrix', id: 1 }));