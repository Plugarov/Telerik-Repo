import 'jquery';

import * as userController from 'userController';
import * as threadsController from 'threadsController';
<<<<<<< HEAD
import * as homeController from 'homeController';

var root = null;
var useHash = false; // Defaults to: false
=======


var root = null;
var useHash = true; // Defaults to: false
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
var hash = '#!'; // Defaults to: '#'
var router = new Navigo(root, useHash, hash);

router
<<<<<<< HEAD
    .on('/', homeController.loadHome)
    .on('home', homeController.loadHome)
    .on('threads', threadsController.getThreads)
    .on('threads/:id', params => threadsController.getMessagesByThreadId(params))
    .on('login', userController.loadLogin)
    .on('register', userController.loadRegister)
    .on('logout', userController.loadLogout)
    .resolve();
=======
    .on('home/:id', (params) => {
        console.log(params);
    })
    .on('threads/', threadsController.getThreads)
    .on('gallery/', threadsController.getGallery)
    .on('threads/:id', params => threadsController.getThreadById(params))
    .resolve();
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
