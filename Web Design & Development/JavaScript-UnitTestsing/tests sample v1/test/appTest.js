const assert = require('chai').assert;
const app = require('../app');

var sayHelloResult = app.sayHello();
var addNumbersResult = app.addNumbers();

describe('App', function () {

    before(() => {
        console.log('------ Before all -------');
    })

    
    after(() => {
        console.log('------ after all -------');
    })

    describe('sayHello', function () {
        
        it('app should return hello', function () {

            //arrange 

            //act 

            //assert 
            assert.equal(sayHelloResult, 'hello');
        });

        it('sayHello should return type string', function () {
            assert.typeOf(sayHelloResult, 'string');
        })
    })
    describe('addNumbers', function () {
        it('addNumbers should be above 5', function () {
            assert.isAbove(addNumbersResult, 5);
        });
    });
});