class Hero {
    constructor(name, age) {
        // with underscore we fake it private
        this._name = name;
        this._age = age;
    }
}

let person = new Hero('joro', 5);
console.log(typeof person);

// before IS6 it was like

function Hero(name, age) {
    this._name = name;
    this._age = age;
}

// Anonymous, never used

let person = class {

}



