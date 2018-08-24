var express = require('express'),
    bodyParser = require('body-parser');

var app = express(),
    db = require('./db/db');

app.use(bodyParser.json());

require('./utils/user-authentication')(app);

app.use(express.static('public'));
app.use('/libs', express.static('node_modules'));

function _getMsgDate(msg) {
    return msg.postDate;
}

//User routes
var usersController = require('./controllers/users-controller')(db);
app.post('/api/users', usersController.post);
app.get('/api/users', usersController.get);
app.put('/api/auth', usersController.put);

//Threads routes
var threadsController = require('./controllers/threads-controller')(db);
app.get('/api/threads', threadsController.getThreads);
app.get('/api/threads/:id', threadsController.getById);
app.post('/api/threads', threadsController.postThread);
app.post('/api/threads/:id/messages', threadsController.postMessage);

var port = 1509;
app.listen(port, function () {
    console.log(`Server is running at http://localhost:${port}`);
});
