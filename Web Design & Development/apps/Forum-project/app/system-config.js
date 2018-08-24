System.config({
  transpiler: 'plugin-babel',
  map: {
    // System.js files
    'plugin-babel': 'libs/systemjs-plugin-babel/plugin-babel.js',
    'systemjs-babel-build': 'libs/systemjs-plugin-babel/systemjs-babel-browser.js',
    'text': 'libs/systemjs-plugin-text/text.js',

    // App files
    'user.data': 'app/data/user.data.js',
    'threads.data': 'app/data/threads.data.js',
    'app': 'app/app.js',
    'requester': 'app/utils/requester.js',
    'threadsController': 'app/controllers/threads.js',
    'commonController': 'app/controllers/common.js',
    'userController': 'app/controllers/user.js',
    'homeController': 'app/controllers/home.js',
    'templates': 'app/utils/templates.js',

    // Library files
    'jquery': 'libs/jquery/dist/jquery.min.js',
    'handlebars': 'libs/handlebars/dist/handlebars.amd.js',
    'cryptojs': 'libs/cryptojs/lib/Crypto.js',
  }
});

System.import('app');
