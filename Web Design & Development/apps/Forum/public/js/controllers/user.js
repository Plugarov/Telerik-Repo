import * as data from 'user.data';
import { load as loadTemplate } from 'templates';
import { commonController } from 'commonController';

const $appContainer = $('#app-container');

export function loadLogin(){
  loadTemplate('login')
    .then((template) => {
      $appContainer.html(template);
    })
    .then(() => {

      $('#login-form').on('submit', function(e) {
        e.preventDefault();

        const username = $('#input-username').val();
        const password = $('#input-password').val();

        data.login(username, password)
          .then(
              result => {
                  location.href = '#/home';
              },
              errorMsg => console.log('error user.js'));
      });
    })
    .catch('error user.js')
}

export function loadRegister(){
    loadTemplate('register')
      .then((template) => {
          $appContainer.html(template);
      })
      .then(() => {
          $('#register-form').on('submit', function(e) {
            e.preventDefault();

            const username = $('#input-username').val();
            const password = $('#input-password').val();

            data.register(username, password)
              .then(
                result => {
                  location.href = '#/home'
                },
                error => console.log('error user.js')
              )
          })
      })
      .catch('error user.js')
}

export function loadLogout() {
  data.logout()
    .then(() => {
      commonController.loadAll();
      location.href = '#/home';
    });
}
