mocha ttest/test.js

..............
npm init name description and file to be tested
npm install mocha chai --save-dev
npm run test -s(removes error message)

---------------

const assert = require('chai').assert;
const app = require('../app');

var sayHelloResult = app.sayHello();


module.exports = {
    sayHello: function () {
        return 'hello';
    },
    addNumbers: function () {
        return 1 + 5;
    }
};

--------------------

to run without mocka
first remove mocha remove
then
from bin folder run mocha
cd bin/mocha run test

or

in packages
"scripts": {
	"test""./node_modules/.bin/mocha/sample.test.js
}
then npm test