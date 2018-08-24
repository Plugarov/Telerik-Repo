<<<<<<< HEAD
import * as data from 'threads.data';
import { load as loadTemplate } from 'templates';
import { userGetCurrent } from 'user.data';
=======
import * as data from 'data';
import { load as loadTemplate } from 'templates';
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280

const $appContainer = $('#app-container');

export function getThreads(params) {
    return Promise.all([data.getThreads(), loadTemplate('threads')])
        .then(([data, template]) => {
            let html = template(data);
            $appContainer.html(html);
        })
<<<<<<< HEAD
        .then(() => {
            $('#thread-new-template').on('submit', function(e) {
                e.preventDefault();

                var input = $('#thread-new-template input').val(),
                    username = userGetCurrent();

                var body = {
                  title: input,
                  username: username
                }

                data.addThread(body)
                  .catch((err) => {
                    console.log(`0.1 controllers threads.js ${err}`)
                  })
            });
        })
        .catch((err) => {
          console.log(`0.2 controllers threads.js ${err}`)
        })
}

//FIX HERE
export function getMessagesByThreadId(params) {
    return Promise.all([data.getThreadById(params.id), loadTemplate('messages')])
        .then(([data, template]) => {
            let html = template(data);
            $appContainer.append(html);
            return data;
        })
        .then(() => {
          $('#message-new-template').on('submit', function(e) {
            e.preventDefault();

            var input = $('#message-new-template input').val(),
                username = userGetCurrent();

            var body = {
              title: input,
              username: username
            }

            data.addMessage(params.id, body)
              .catch((err) => {
                console.log(`threads controller 2 ${err}`)
              });


          });
        })
        .catch((err) => {
          console.log(`threads controller 3 ${err}`)
        });
}
=======
        .catch(console.log)
}

export function getThreadById(params) {
    return Promise.all([data.getThreadById(params.id), loadTemplate('messages')])
        .then(([data, template]) => {
            console.log(data)
            let html = template(data);
            $appContainer.append(html);
        })
        .catch(console.log)
}

export function getGallery(params) {
    loadTemplate('gallery')
        .then(template => {
            $appContainer.html(template());
        });
}
>>>>>>> e6625f2bb98f445568025b0d45f48912a6baa280
