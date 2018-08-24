module.exports = (storage) => {
    function idGenerator() {
        var lastId = 0;
        return {
            next: function () {
                return lastId += 1;
            }
        }
    }

    var threadsIdGen = idGenerator();

    function threadsFind(query) {
        var promise = new Promise(function (resolve, reject) {
            if (!query) {
                resolve(storage.threads);
                return;
            }
            var foundThreads = storage.threads.filter(function (thread) {
                return Object.keys(query)
                    .every(function (key) {
                        return query[key] === thread[key];
                    });
            });
            resolve(foundThreads);
        });
        return promise;
    }

    function threadsCreate(thread) {
        var promise = new Promise(function (resolve, reject) {
            if (typeof thread !== 'object' ||
                typeof thread.title !== 'string') {
                reject({
                    err: 'Thead is missing title'
                });
                return;
            }
            thread.id = threadsIdGen.next();
            thread.postDate = new Date();

            var content = thread.content;
            delete thread.content;

            storage.threads.push(thread);

            var body = {
                title: content,
                user: {
                    username: thread.username,
                }
            }

            threadsAddMessage(thread.id, body);

            resolve(thread);
        });
        return promise;
    }

    function threadsAddMessage(id, msg) {
        return threadsFind({
            id: id
        })
            .then(function (threads) {
                var thread = threads[0];

                if (!thread) {
                    throw new Error('invalid thread id');
                }

                if (!thread.messages) {
                    thread.messages = [];
                }

                msg.postDate = new Date();
                thread.messages.push(msg);
                return thread;
            });
    }

    // Bad practice
    function getRecentThreads() {
        return Promise.resolve()
            .then(() => {
                const threads = storage.threads;
                var sortedThreadsByDateAsc = threads.sort((a, b) => {
                    var dateA = new Date(a.postDate).getTime();
                    var dateB = new Date(b.postDate).getTime();
                    return dateA > dateB ? -1 : 1;
                });

                return sortedThreadsByDateAsc.slice(0, 3);
            });
    }

    // Bad practice
    function getRecentMessages() {
        return Promise.resolve()
            .then(() => {
                const threads = storage.threads;

                var sortedMessagesByDateAsc = [];
                threads.forEach((thread) => {
                    if (thread.messages !== undefined) {
                        let threadId = thread.id;
                        thread.messages.forEach((singleMessage) => {
                            singleMessage.id = threadId;
                            sortedMessagesByDateAsc.push(singleMessage);
                        })
                    }
                });

                sortedMessagesByDateAsc.sort((a, b) => {
                    var dateA = new Date(a.postDate).getTime();
                    var dateB = new Date(b.postDate).getTime();
                    return dateA > dateB ? -1 : 1;
                });

                return sortedMessagesByDateAsc.slice(0, 3);
            });
    }

    return {
        idGenerator: idGenerator,
        find: threadsFind,
        create: threadsCreate,
        addMessage: threadsAddMessage,
        getRecentThreads: getRecentThreads,
        getRecentMessages: getRecentMessages,
    }
};
