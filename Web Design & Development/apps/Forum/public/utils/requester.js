function request(url, type, body, headers) {
    const promise = new Promise((resolve, reject) =>
        $.ajax({
            url,
            type,
            contentType: 'application/json',
            headers,
            data: body,
            success: resolve,
            error: reject
        }))

    return promise;
}

//FIGURE OUT IF CACTCH IS NEEDED
export function get(url, headers = {}) {
    return request(url, 'GET', '', headers)
      .catch(console.log);
}

export function post(url, body, headers = {}) {
    return request(url, 'POST', JSON.stringify(body), headers)
      .catch((err) => {
        console.log(`requester.js 2 ${err}`)
      });;
}

export function put(url, body, headers = {}) {
    return request(url, 'PUT', JSON.stringify(body), headers)
      .catch((err) => {
        console.log(`requester.js 3 ${err}`)
      });;
}
