import { get as getRequest } from 'requester';
// import { Handlebars } from 'handlebars'; // FIX ME

const cacheObj = {};

export function load(templateName) {
  if (cacheObj.hasOwnProperty(templateName)) {
    return Promise.resolve(cacheObj[templateName])
      .catch((err) => {
        console.log(`templates.js ${err}`);
      });
  }

  return getRequest(`templates/${templateName}.handlebars`)
    .then(template => {
      const compiledTemplate = Handlebars.compile(template);
      cacheObj[templateName] = compiledTemplate;

      return Promise.resolve(compiledTemplate);
    })
    .catch((err) => {
      console.log(`templates utils ${err}`)
    });
}
