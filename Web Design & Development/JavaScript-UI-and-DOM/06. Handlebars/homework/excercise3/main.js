$.fn.listview = function (data) {

    var hbTemplate = document.getElementById('book-item-template').innerHTML;
    
    var passedObjectName = Object.keys(data)[0];
    
    var result = `{{#${passedObjectName}}} ${hbTemplate} {{/${passedObjectName}}}`;

    var template = Handlebars.compile(result);

    var container = document.getElementById('books-list');

    container.innerHTML = template(data);

};