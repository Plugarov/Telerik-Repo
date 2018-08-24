module.exports = (data) => {
    function registerUser(req, res) {
        const user = req.user;

        data.users.create(req.body)
            .then(function (user) {
                user = {
                    username: user.username,
                    authKey: user.authKey
                };
                console.log(res.body);

                res.status(201)
                    .json(user);
            }, function (err) {
                res.status(400)
                    .json(err);
            });
    }

    function getUsers(req, res) {
        data.users.find()
            .then(function (users) {
                users = users.map(function (user) {
                    return {
                        id: user.id,
                        username: user.username
                    }
                })
                res.json({
                    result: users
                });
            }, function (err) {
                res.status(400)
                    .json(err);
            })
    }

    function loginUser(req, res) {
        var query = {
            usernameLower: req.body.username.toLowerCase()
        };

        data.users.find(query)
            .then(function (users) {
                var user = users[0];
                if (!user || user.passHash !== req.body.passHash) {
                    res.status(404)
                        .json({
                            err: 'Username or password is invalid'
                        });
                    return;
                }
                res.json({
                    username: user.username,
                    authKey: user.authKey
                });
            });
    }

    return {
        registerUser: registerUser,
        getUsers: getUsers,
        loginUser: loginUser,
    };
}
