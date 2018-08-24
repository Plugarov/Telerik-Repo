System.config({
  transpiler: 'plugin-babel',
  map: {
    // System.js files
    'plugin-babel': 'libs/systemjs-plugin-babel/plugin-babel.js',
    'systemjs-babel-build': 'libs/systemjs-plugin-babel/systemjs-babel-browser.js',
    'text': 'libs/systemjs-plugin-text/text.js',

    // App files
<<<<<<< HEAD
    'user.data': 'js/data/user.data.js',
    'threads.data': 'js/data/threads.data.js',
    'app': 'js/app.js',
    'requester': 'utils/requester.js',
    'threadsController': 'js/controllers/threads.js',
    'commonController': 'js/controllers/common.js',
    'userController': 'js/controllers/user.js',
    'homeController': 'js/controllers/home.js',
    'templates': 'utils/templates.js',
=======
    'app': 'js/app.js',
    'requester': 'js/requester.js',
    'data': 'js/data.js',
    'threadsController': 'js/controllers/threads.js',
    'userController': 'js/controllers/user.js',
    'templates': 'js/templates.js',
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280

    // templates
    // 'homeTemplate': 'templates/home.handlebars',

    // Library files
    'jquery': 'libs/jquery/dist/jquery.min.js',
    'handlebars': 'libs/handlebars/dist/handlebars.amd.js',
    'cryptojs': 'libs/cryptojs/lib/Crypto.js',
    'toastr': 'libs/toastr/build/toastr.min.js',
  }
});

System.import('app');
