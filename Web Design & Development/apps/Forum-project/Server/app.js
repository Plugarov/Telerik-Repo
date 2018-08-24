var express = require('express'),
    bodyParser = require('body-parser');

var app = express();
const data = require('./data');

app.use(bodyParser.json());
require('./utils/user-authentication')(app);

app.use(express.static('public'));
app.use('/libs', express.static('node_modules'));
app.use('/app', express.static('app'));

function _getMsgDate(msg) {
    return msg.postDate;
}

//User routes
var usersController = require('./controllers/users-controller')(data);
app.post('/api/users', usersController.registerUser);
app.get('/api/users', usersController.getUsers);
app.put('/api/auth', usersController.loginUser);

//Threads routes
var threadsController = require('./controllers/threads-controller')(data);
app.get('/api/threads', threadsController.getThreads);
app.get('/api/threads/:id', threadsController.getById);
app.post('/api/threads', threadsController.postThread);
app.post('/api/threads/:id/messages', threadsController.postMessage);
app.get('/api/auth/recentThreads', threadsController.getRecentThreads);
app.get('/api/auth/recentMessages', threadsController.getRecentMessages);

var port = 1509;
app.listen(port, function () {
    console.log(`Server is running at http://localhost:${port}`);
});
