import { load as loadTemplate } from 'templates';
import { commonController } from 'commonController';
import * as data from 'threads.data';

const $appContainer = $('#app-container');

export function loadHome() {

  commonController.loadAll();

  const promise = Promise.all([data.getThreads(), loadTemplate('home')])
    .then(([data, template]) => {
        // this causes promise exception, because values are 0 in the beginign
        // var lastThreeTopics = data.result.slice(Math.max(data.result.length - 3, 1))
        // console.log(lastThreeTopics);
        var html = template(data)
        $appContainer.html(html);
    })
    .catch((e)=> {
      console.log(`fix controllers/home ${err.reason}`);
    })

  return promise;
}
