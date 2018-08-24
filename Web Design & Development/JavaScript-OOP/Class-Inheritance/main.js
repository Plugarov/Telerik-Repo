class Mammal {
    constructor(age) {
        this._age = age;
    }

    walk() {
        console.log('mammal walks');
    }
}

class Person extends Mammal {
    constructor(name, age) {
        super(age);
        this._name = name;
    }

    walk() {
        console.log('person walks');
    }
}

var p = new Person('joro', 15);
console.log(p);
p.walk();

//50 min