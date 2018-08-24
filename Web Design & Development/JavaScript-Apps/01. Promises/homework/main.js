//46min

(function () {
    var myPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((pos) => {
            resolve(pos);
        });
    });

    function parsePosition(pos) {
        return {
            lat: pos.coords.latitude,
            long: pos.coords.longitude
        };
    }

    function displayMap(pos) {
        var map = document.getElementById('map')
        var src = `http://maps.googleapis.com/maps/api/staticmap?center=
        ${pos.latitude},${pos.longitude}&zoom=13&size=500x500&sensor=false`;

        map.setAttribute('src', src);
    }

    myPromise
        .then(parsePosition)
        .then(displayMap)
        .catch();

}());

// vs
// (function () {
// navigator.geolocation.getCurrentPosition(
//     function success(pos) {
//         var root = document.getElementById('bomb')
//         var src = "http://maps.googleapis.com/maps/api/staticmap?center=" + pos.coords.latitude + "," + pos.coords.longitude + "&zoom=13&size=500x500&sensor=false";

//         var img = document.createElement('img');
//         img.setAttribute('src', src);

//         root.appendChild(img);
//     },
//     function error(err) {
//         console.log(err);
//     },
//     options = {
//         enableHighAccuracy: true,
//         timeout: 5000,
//         maximumAge: 0
//     });
// }());
