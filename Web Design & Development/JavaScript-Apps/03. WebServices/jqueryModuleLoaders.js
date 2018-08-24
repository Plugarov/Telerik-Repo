

/*  
    Virtual server:
    npm install -g http-server 
    http-server 
    http://176.14.201.145:8080/index.html 
*/
function getAll() {
    $.getJSON("http://176.14.201.145:8080/index.html", function (data) {
        // 1.Create xhr
        var xhr = new XMLHttpRequest();

        // 2.Open xhr  to url and VERB
        var url = "http://telerikacademy.com";
        xhr.open("GET", url, true);

        // 3.Setup

        // 3.1 Add headers

        // 4.Attach to ready event
        xhr.onreadystatechange = function () {
            console.log(`State: ${xhr.readyState}`);

            if (xhr.readyState !== XMLHttpRequest.DONE) {
                return;
            }

            switch (0 | (xhr.status / 100)) {
                case 2:
                    console.log(xhr.responseText);
                    var body = JSON.parse(xhr.responseText);
                    console.log(body);
                    break;
                default:
                    alert('Error');
                    break;
            }
        };

        // 5.Send the request
        xhr.send();
    });

}

function addNew() {
    var name = "John" + Math.random(),
        age = Math.random() * 150;

    $.ajax({
        url: 'http://',
        metod: 'POST',
        'contentType': 'application/json',
        'header': {

        },
        data: JSON.stringify({ name, age }),
        success: function (data) {
            getAll();
        }
    });

    // sendHttpRequest(url, 'POST', { name, age }, function () {
    //     getAll();
    // });
}

var btn;
window.onload = function () {
    getAll();
    btn = document.getElementById('btn-add');
    btn.addEventListener('click', addNew);

    // 1.Create xhr
    var xhr = new XMLHttpRequest();

    // 2.Open xhr  to url and VERB
    xhr.open("POST", url, true);

    // 3.Setup
    // 3.1 Add headers
    xhr.setRequestHeader('Content-Type', 'Application/json')

    // 4.Attach to ready event
    xhr.onreadystatechange = function () {
        console.log(`State: ${xhr.readyState}`);

        if (xhr.readyState !== XMLHttpRequest.DONE) {
            return;
        }

        switch (0 | (xhr.status / 100)) {
            case 2:
                getAll();
                break;
            default:
                alert('Error');
                break;
        }
    };

    // 5.Send the request  
    var body = {
        age,
        name
    }

    xhr.send(body);
}