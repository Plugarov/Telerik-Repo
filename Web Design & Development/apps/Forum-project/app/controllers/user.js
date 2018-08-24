import * as data from 'user.data';
import { load as loadTemplate } from 'templates';
import { commonController } from 'commonController';
import { User } from '../models/user.js'

const $appContainer = $('#app-container');

export function loadLogin() {
  loadTemplate('login')
    .then((template) => {
      $appContainer.html(template);
    })
    .then(() => {
      commonController.loadAll();

      $('#login-form').on('submit', function (e) {
        e.preventDefault();

        const username = $('#input-username').val();
        const password = $('#input-password').val();

        data.login(username, password)
          .then(
          result => {
            toastr.success('Login successful')
            location.href = '#/home';
          },
          errorMsg => {
            toastr.error('Invalid username or password.');
          });
      });
    })
    .catch('error user.js');
}

export function loadRegister() {
  loadTemplate('register')
    .then((template) => {
      $appContainer.html(template);
    })
    .then(() => {
      commonController.loadAll();

      $('#register-form').on('submit', function (e) {
        e.preventDefault();

        const username = $('#input-username').val();
        const password = $('#input-password').val();

        var user = new User(username, password);

        data.register(user)
          .then(
          result => {
            toastr.success('Registration successful');
            location.href = '#/home';
          },
          error => toastr.warning(error.responseJSON.err)
          )
      })
    })
    .catch('error user.js');
}

export function loadLogout() {
  data.logout()
    .then(() => {
      commonController.loadAll();
      toastr.success('Logout successful');
      location.href = '#/home';
    });
}
