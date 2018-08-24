https://github.com/TelerikAcademy/JavaScript-Applications/blob/master/Topics/03.%20Consuming%20Web%20Services/demos/7.%20jquery-get-post.html

var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key',
    AUTH_KEY_STORAGE_KEY = 'auth-key-key';

  // start users
  function userLogin(user) {
    return new Promise((resolve, reject) => {
      var logUser = {
        username: user.username,
        passHash: user.password,
      }

      $.ajax({
        url: '/api/auth',
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify(logUser),
        success: function (user) {
          // localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
          // localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
          resolve(user);
        },
        error: function (user) {
          reject(user);
        }
      })
    })
  }

  function userLogout() {
    return new Promise((resolve, reject) => {
      localStorage.removeItem(AUTH_KEY_STORAGE_KEY);
      localStorage.removeItem(USERNAME_STORAGE_KEY);
      resolve();
    })
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }

  function userRegister(user) {
    return new Promise((resolve, reject) => {
      var reqUser = {
        username: user.username,
        passHash: user.password
      };

      $.ajax({
        url: 'api/users',
        method: 'POST',
        data: JSON.stringify(reqUser),
        contentType: 'application/json',
        success: function (user) {
          // localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
          // localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
          resolve(user);
        },
        error: function (err) {
          reject(err);
        }
      });
    });
  }
  // end users

  // start threads
  function threadsGet() {
    return new Promise((resolve, reject) => {
      $.getJSON('api/threads')
        .done(resolve)
        .fail(reject);
    })
  }

  function threadsAdd(title) {

  }

  function threadById(id) {

  }

  function threadsAddMessage(threadId, content) {

  }
  // end threads

  // start gallery
  function galleryGet() {
    const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;

  }
  // end gallery

  return {
    users: {
      login: userLogin,
      logout: userLogout,
      register: userRegister,
      current: userGetCurrent
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadById,
      addMessage: threadsAddMessage
    },
    gallery: {
      get: galleryGet,
    }
  }
})();