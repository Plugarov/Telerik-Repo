import 'jquery';
import * as db from 'data';

//import { add, all, findById } from 'data';
// if used, use functions without `db.`

export function attachEvents() {
    $('#btn-add').on('click', function () {
        const newPerson = {
            name: $('#person-name').val(),
            age: $('#person-age').val()
        }
    
        db.add(newPerson);
    });
    
    $('#btn-all').on('click', function () {
        const peopleHtml = db.all().map(p => `<li>${p.name} - ${p.age} </li>`)
    
        $('#list').html(peopleHtml.join(''));
    });
}