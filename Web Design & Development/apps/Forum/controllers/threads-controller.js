module.exports = function (db) {
    function postMessage(req, res) {
        var message = req.body;
        message.user = {
            username: req.body.username
        };

        db.threads.addMessage(+req.params.id, message)
            .then(function (message) {
                res.status(201)
                    .json(message);
            });
    }

    function getById(req, res) {
        // console.log(typeof req.params.id);
        db.threads.find({ id: +req.params.id })
            .then(function (threads) {
                if (!threads || !threads.length) {
                    res.status(404)
                        .json({
                            err: 'Thread not found'
                        });
                    return;
                }
                res.json({
                    result: threads[0]
                });
                return;
            });
    }

    function postThread(req, res) {
        var thread = req.body;

        // console.log(req.body);
        thread.user = { username: req.body.username };

        db.threads.create(thread)
            .then(function (thread) {
                res.json({ result: thread });
            }, function (err) {
                res.status(400).json(err);
            });
    };

    function getThreads(req, res) {
        var page = +req.query.page || 0,
            size = +req.query.size || 10;

        db.threads.find()
            .then(function (threads) {
                threads.sort(function (thr1, thr2) {
                    var thr1SoonestDate,
                        thr2SoonestDate;
                    var thrs = [thr1, thr2];
                    var dates = thrs.map(function (thr) {
                        if (thr.messages && thr.messages.length > 0) {
<<<<<<< HEAD
                            // var messageDates = thr.messages.map(_getMsgDate);
                            // return Math.max(messageDates);
                            return thr.messages;
=======
                            var messageDates = thr.messages.map(_getMsgDate);
                            return Math.max(messageDates);
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
                        } else {
                            return (thr.postDate - 0);
                        }
                    });
                    return dates[0] - dates[1];
                });

                res.json({
                    result: threads.slice(page * size, (page + 1) * size)
                });
            });
    }
<<<<<<< HEAD

=======
    
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
    return {
        getThreads: getThreads,
        postThread: postThread,
        getById: getById,
        postMessage: postMessage,
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
