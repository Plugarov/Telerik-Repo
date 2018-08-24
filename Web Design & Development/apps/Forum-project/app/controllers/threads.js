import * as data from 'threads.data';
import { load as loadTemplate } from 'templates';
import { commonController } from 'commonController';
import * as userData from 'user.data';

const $appContainer = $('#app-container');

export function createThread() {
    loadTemplate('create-thread')
        .then((template) => {
            $appContainer.html(template);
        })
        .then(() => {
            commonController.loadAll();

            $('#create-thread-form').on('submit', function (e) {
                e.preventDefault();

                var textarea = $('#thread-name').val(),
                    content = $('#thread-content').val(),
                    username = userData.userGetCurrent();

                var body = {
                    title: textarea,
                    content: content,
                    username: username
                }

                data.addThread(body)
                    .then(() => {
                        location.href = "#threads"
                    });
            });
        })
        .catch(console.log);
}

export function getThreads(params) {

    var promise = Promise.all([data.getThreads(), loadTemplate('threads')])
        .then(([data, template]) => {
            let html = template(data);
            $appContainer.html(html);
        })
        .then(() => {
            commonController.loadAll();

            if (userData.hasUser()) {
                $("#thread-add-new").removeClass('hidden');
            } else {
                $("#thread-add-new").addClass('hidden');
            }

            $('#thread-add-new').on('click', function (e) {
                e.preventDefault();

                location.href = '#create-thread'
            });
        })
        .catch((err) => {
            console.log(`0.2 controllers threads.js ${err}`)
        });

    return promise;
}

export function getMessagesByThreadId(params) {
    var promise = Promise.all([data.getThreadById(params.id), loadTemplate('messages')])
        .then(([data, template]) => {
            let html = template(data);
            $appContainer.html(html);

            return data;
        })
        .then(() => {
            commonController.loadAll();

            if (userData.hasUser()) {
                $("#create-message-form").removeClass('hidden');
            } else {
                $("#create-message-form").addClass('hidden');
            }

            $('#create-message-form').on('submit', function (e) {
                e.preventDefault();

                var input = $('#message-content').val(),
                    username = userData.userGetCurrent();

                var body = {
                    title: input,
                    username: username
                }

                data.addMessage(params.id, body)
                    .then(() => {
                        location.href = `#threads`
                    })
                    .catch((err) => {
                        console.log(`threads controller 2 ${err}`)
                    });
            });
        })
        .catch((err) => {
            console.log(`threads controller 3 ${err}`)
        });

    return promise;
}
