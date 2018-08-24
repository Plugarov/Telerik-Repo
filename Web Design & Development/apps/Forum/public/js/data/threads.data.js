import * as requester from 'requester';

export function addThread(body) {
  return requester.post('api/threads', body);
}

export function addMessage(id, message) {
  return requester.post(`api/threads/${id}/messages`, message)
}

export function getThreads() {
    return requester.get('api/threads');
}

export function getThreadById(id) {
    return requester.get(`api/threads/${id}`);
}
