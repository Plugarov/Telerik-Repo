const fs = require('fs');
const path = require('path');

const low = require('lowdb');
const FileSync = require('../../node_modules/lowdb/adapters/FileSync');

const adapter = new FileSync('./db/db.json')
var db = low(adapter)

db._.mixin(require('lodash-id'));

// TODO use lowdb functionality in data
db = db.value();

const data = {};

fs.readdirSync(__dirname)
    .filter((file) => file.includes('.data'))
    .forEach((file) => {
        const name = file.substr(0, file.indexOf('.'));
        data[name] = require(path.join(__dirname, file))(db);
    });

module.exports = data;
