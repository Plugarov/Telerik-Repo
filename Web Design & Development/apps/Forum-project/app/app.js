import 'jquery';

import * as userController from 'userController';
import * as threadsController from 'threadsController';
import * as homeController from 'homeController';

var root = null;
var useHash = false; // Defaults to: false
var hash = '#!'; // Defaults to: '#'
var router = new Navigo(root, useHash, hash);

router
    .notFound(homeController.notFound)
    .on('home', homeController.loadHome)
    .on('threads', threadsController.getThreads)
    .on('create-thread', threadsController.createThread)
    .on('threads/:id', params => threadsController.getMessagesByThreadId(params))
    .on('login', userController.loadLogin)
    .on('register', userController.loadRegister)
    .on('logout', userController.loadLogout)
    .resolve();
