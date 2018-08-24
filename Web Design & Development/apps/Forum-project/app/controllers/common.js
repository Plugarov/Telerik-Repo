import { load as loadTemplate } from 'templates';
import { hasUser } from 'user.data';
import { getRecentThreads, getRecentMessages } from 'user.data';

const $appContainer = $('#app-container');

class CommonController {
  loginNotify() {
    if (!hasUser()) {
      loadTemplate('login-notify')
        .then((template) => {
          $appContainer.prepend(template);
        })
        .catch(console.log);
    }
  }

  showHideLoginRegister() {
    if (hasUser()) {
      $('#logout-button').removeClass('hidden');
      $('#register-button').addClass('hidden');
      $('#login-button').addClass('hidden');
    }
    else {
      $('#logout-button').addClass('hidden');
      $('#register-button').removeClass('hidden');
      $('#login-button').removeClass('hidden');
    }
  }

  navLinkSelectActive() {
    $('.nav').click(function (e) {
      const target = e.target;
      $(target).parent().addClass('active');
      $(target).parent().siblings().removeClass('active');
    });
  }

  loadFooter() {
    var promise = Promise.all([getRecentThreads(), getRecentMessages(), loadTemplate('footer')])
      .then(([threads, messages, template]) => {
        var data = {
          threads: threads,
          messages: messages,
        }

        data.threads.result.forEach((thread) => {
          if (thread.title.length > 125) {
            thread.title = thread.title.substring(0, 125);
          }
        });

        data.messages.result.forEach((messages) => {
          if (messages.title.length > 125) {
            messages.title = messages.title.substring(0, 125) + '...';
          }
        });

        var html = template(data);
        $('footer').html(html)
      });

    return promise;
  }

  loadAll() {
    this.loginNotify();
    this.navLinkSelectActive();
    this.showHideLoginRegister();
    this.loadFooter();
  }
}

let commonController = new CommonController();

export { commonController };
