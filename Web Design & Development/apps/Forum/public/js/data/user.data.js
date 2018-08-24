import * as requester from 'requester';

const HTTP_HEADER_KEY = "x-auth-key",
    KEY_STORAGE_USERNAME = "username",
    KEY_STORAGE_AUTH_KEY = "authKey";

export function hasUser() {
  return localStorage.getItem("KEY_STORAGE_USERNAME") !== null &&
        localStorage.getItem("KEY_STORAGE_AUTH_KEY") !== null
}

export function userGetCurrent() {
  return localStorage.getItem("KEY_STORAGE_USERNAME") || 'Anonymous';
}

export function login(username, passHash) {
    const body = {
      username,
      passHash
    };

    return requester.put('api/auth', body)
      .then(respUser => {
        const user = respUser.result;
        localStorage.setItem("KEY_STORAGE_USERNAME", respUser.username);
        localStorage.setItem("KEY_STORAGE_AUTH_KEY", respUser.authKey);
        return user;
      })
}

export function register(username, passHash) {
    const body = {
        username,
        passHash
    };

    return requester.post('api/users', body);
}

export function logout() {
  const promise = new Promise((resolve, reject) => {
    localStorage.removeItem("KEY_STORAGE_USERNAME");
    localStorage.removeItem("KEY_STORAGE_AUTH_KEY");

    resolve();
  });

  return promise;
}
