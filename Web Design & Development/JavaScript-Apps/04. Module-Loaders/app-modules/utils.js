'use strict'

export function clone(obj) {
    return JSON.parse(JSON.stringify(obj));
}

// Read about generators
export function* idGenerator() {
    let currentId = 0;

    while (true) {
        yield currentId;
        currentId += 1;
    }
}

function sayHello() {
    console.log('Hello');
}

// export { clone }