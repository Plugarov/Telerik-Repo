'use strict';

// Imports, methods can be renamed
import { clone, idGenerator as createIdGenerator } from 'utils';

const records = [],
    idGen = createIdGenerator();

function add(person) {
    const clonnedPerson = clone(person);
    clonnedPerson.id = idGen.next().value;
    records.push(clonnedPerson);
}

function findById(id) {
    const result = records.find(r => r.id === id);
    return result;
}

function all() {
    return clone(records);
}

export { add, all, findById }