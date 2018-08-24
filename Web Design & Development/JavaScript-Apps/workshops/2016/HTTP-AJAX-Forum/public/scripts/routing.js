import { data } from './data.js'
import { templateLoader as tl } from './template-loader.js'


var router = (function () {
    let navigo;

    function init() {
        navigo = new Navigo(null, false);

        function showMsg(msg, type, cssClass, delay) {
            let container = alertTemplate.clone(true)
                .addClass(cssClass).text(`${type}: ${msg}`)
                .appendTo(root);

            setTimeout(() => {
                container.remove();
            }, delay || 2000)
        }

        navigo.on('/threads/:id', (params) => {
            Promise.all([data.threads.getById(params.id), tl.get('messages')])
                .then(([data, template]) => {
                    let $container = $('.container-messages'),
                        html = template(data);

                    if ($container.length >= 1) {
                        $container.remove();
                        $('#content').append(html)
                    } else {
                        $('#content').append(html)
                    }
                })
                .catch(console.log)
        });

        navigo.on('/threads', () => {
            Promise.all([data.threads.get(), tl.get('threads')])
                .then(([data, template]) => {
                    let html = template(data);
                    $('#content').html(html);
                })
                .catch(console.log)
        })

        navigo.on('/gallery', () => {
            Promise.all([data.gallery.get(), tl.get('gallery')])
                .then(([data, template]) => {
                    let html = template(data);
                    $('#content').html(html);
                })
                .catch(console.log)
        })
    }

    return {
        init
    }
}())

export { router };