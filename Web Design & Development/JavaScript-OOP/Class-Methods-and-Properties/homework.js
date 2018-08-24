class LinkedList {
    constructor(list) {
        this._list = [];
    }

    get first() {
        return this._list[0];
    }

    get last() {
        return this._list[this._list.length - 1];
    }

    get length() {
        return this._list.length;
    }

    append() {
        for (var i = 0; i < arguments.length; i++) {
            this._list.push(arguments[i]);
        }
        return this;
    }

    prepend() {
        for (var i = arguments.length - 1; i >= 0; i--) {
            this._list.unshift(arguments[i]);
        }
        return this;
    }

    insert() {

    }

    at() {
        if (arguments.length == 1) {
            return this._list[arguments[0]];
        }
        if (arguments.length == 2) {
            return this._list[arguments[0]] = arguments[1];
        }
    }

    removeAt(index) {
        return this._list.splice(index, 1);
    }

    toString() {
        return this._list.join(', ');
    }

}


const list = new LinkedList().append(6, 7, 8).prepend(1, 2, 3, 4, 5);

list.removeAt(0);
console.log(list.first);
console.log(list.last);
console.log(list.length);
console.log(list.toString());