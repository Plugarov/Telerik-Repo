//http://127.0.0.1:8080/#pesho
//location.hash -> pesho

const appContainer = $('#container');

$(window).on('hashchange', (ev) => {
    var hashUrl = location.hash;
   
    if (hashUrl === '#home') {
        console.log(1);
        appContainer.html('Home Page')
    } else if (hashUrl === '#user') {
        appContainer.html('Showing users');
    } else if (hashUrl.indexOf('#user/') === 0) {
        const userName = hashUrl.substr(7);
        appContainer.html(`Showing info for user ${userName}`)
    }
 
})
