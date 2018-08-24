
// prototype 50:00

const Validator = {
    validateAge: function (age) {
        if (age < 1) {
            throw new Error();
        }
    }
}

class Cat {

    //javasctipt does not have overloading
    constructor(name) {
        this._name = name;
        this._age = 0;
    }

    static whatDoesTheCatSay() {
        return 'meow';
    }

    // static getters and setters
    static get whatDoesTheCatSay() {
        return 'meow';
    }

    meow() {
        console.log(this._name + ': meow!');
    }

    //getters setters
    get age() {
        return this._age;
    }

    set age(newAge) {
        Validator.validateAge(age);
        this._age = newAge;
    }
}

var penka = new Cat('Penka');
penka._age = 5;
penka.meow();

Cat.prototype.jump = function () {
    console.log(this._name + ' : jumped!');
}

// old way to add protoype or set getter or setter

Object.defineProperty(Cat.prototype, 'name', {
    get: function () {
        return this._name;
    },
    set: function (value) {
        this._name = value;
    }
});

penka.jump();
console.log(penka.age);
console.log(penka.name);

// original way
// function Dog(name) {
//     this._name = name;

//     this.maikati = function(){
//         console.log(this._name + ': meow!');
//     };

//     object.defineProperty
// }

// const d = Dog('Sharo');
// d.maikati();