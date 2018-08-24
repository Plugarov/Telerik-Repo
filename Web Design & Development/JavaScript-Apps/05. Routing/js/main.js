
$(() => {
  let result = $('#result'),
    router = new Navigo(null, false);

  function print(obj) {
    console.log(JSON.stringify(obj));
  }

  router
    .on('test/:query', (params) => {
      //шибания въпросителен не бачка тука
      console.log(params.query);
      getQueryParams(params.query)
    })
    .on('settings', () => {
      console.log('settings')
    })
    .on('quit', () => {
      console.log('quit')
    })
    .on('book/:id/note/:noteID', params => console.log(params))
    .on({
      'book/:id': params => console.log(params),
      '*': () => console.log("HOME")
    })
    //.on('book/:id/note/:noteID', params => console.log(params)) // WON`T work here
    .resolve();



  function getQueryParams(query) {
    let hash, vars = {},
      hashes = query.substr(1)
        .split('&').forEach(val => {
          hash = val.split('=');
          vars[hash[0]] = hash[1];
        });
    return vars;
  }

})