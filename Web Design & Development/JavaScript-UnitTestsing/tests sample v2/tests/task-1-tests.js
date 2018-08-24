const assert = require('chai').assert;
const task = require('../tasks/task-1');

it('app should return hello', function () {

    //arrange 

    //act 

    //assert 
    assert.equal(task.task(), 'hello');
});

it('app should return hello', function () {
        assert.equal(task.task2(), 'hello2');
    });