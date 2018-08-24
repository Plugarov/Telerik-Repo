import { load as loadTemplate } from 'templates';
import { commonController } from 'commonController';
import * as data from 'threads.data';

const $appContainer = $('#app-container');

export function loadHome() {
  const promise = Promise.all([data.getThreads(), loadTemplate('home')])
    .then(([data, template]) => {
      var html = template(data);
      $appContainer.html(html);
    })
    .then(() => {
      commonController.loadAll();
    })
    .catch((err) => {
      console.log(`fix controllers/home ${err}`);
    })

  return promise;
}

export function notFound() {
  commonController.loadAll();

  const promise = new Promise((resolve, reject) => {
    resolve(loadTemplate('page-not-found'))
  })
    .then((template) => {
      var html = template;
      $appContainer.html(html);
    })
    .then(() => {
      commonController.loadAll();
    })
    .catch((err) => {
      console.log(`fix controllers/home ${err}`);
    })

  return promise;
}
