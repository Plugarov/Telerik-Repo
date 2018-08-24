import * as requester from 'requester';

export function getThreads() {
    return requester.get('api/threads');
}

export function getThreadById(id) {
    return requester.get(`api/threads/${id}`);
}


export function login(username, passHash) {
    const body = {
        username,
        passHash
    };

    return requester.put('api/auth', body);
}

export function register(username, passHash) {
    const body = {
        username,
        passHash
    };

    return requester.post('api/users', body);
}
