module.exports = (storage) => {
    function idGenerator() {
        var lastId = 0;
        return {
            next: function () {
                return lastId += 1;
            }
        }
    }

    var generateAuthKey = (function () {
        var chars = '1234567890)(*&^%$#@!)',
            length = 60;
        return function (username) {
            var authKey = username,
                index;
            while (authKey.length < length) {
                index = (Math.random() * chars.length) | 0;
                authKey += chars[index];
            }
            return authKey;
        }
    }());

    var usersIdGen = idGenerator();

    function usersFind(query) {
        var promise = new Promise(function (resolve, reject) {
            if (!query) {
                resolve(storage.users);
                return;
            }

            var foundUsers = storage.users.filter(function (user) {
                return Object.keys(query)
                    .every(function (key) {
                        return query[key] === user[key];
                    });
            });
            resolve(foundUsers);
        });
        return promise;
    }

    function usersCreate(user) {
        var promise = new Promise(function (resolve, reject) {
            if (typeof user !== 'object' ||
                typeof user.username !== 'string' ||
                typeof user.passHash !== 'string') {
                reject({
                    err: user
                });
                return;
            }

            usersFind({
                usernameLower: user.username.toLowerCase()
            })
                .then(function (users) {
                    if (users.length > 0) {
                        reject({
                            err: 'Username already exists'
                        });
                        return;
                    }

                    var dbUser = {
                        id: usersIdGen.next(),
                        username: user.username,
                        usernameLower: user.username.toLowerCase(),
                        passHash: user.passHash,
                        authKey: generateAuthKey(user.username)
                    };

                    if (storage.users.length === 0) {
                        dbUser.role = 'admin';
                    } else {
                        dbUser.role = 'user';
                    }

                    storage.users.push(dbUser);
                    resolve(dbUser)
                });
        });
        return promise;
    }

    return {
        find: usersFind,
        create: usersCreate,
    }
};
