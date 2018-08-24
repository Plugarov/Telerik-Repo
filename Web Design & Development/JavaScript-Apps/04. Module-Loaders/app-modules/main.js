'use strict';

import 'jquery';

const startButton =
    $('<button>', { id: 'btn-start' })
        .html('Start the app')
        .prependTo($('body'));

startButton.on('click', function () {

    //lazy loading
    System.import('data').then(function (db) {
        // db.add({
        //     name: 'Pesho',
        //     age: 20
        // });
        // console.log(db.findById(0));

        Promise.all([
            System.import('data'),
            System.import('data-provider'),
            System.import('person-component')
        ]).then(function (modules) {
            const [data, dataPovider, personComponent] = modules;
            dataPovider.seed();
            personComponent.attachEvents();
        });
    });
});