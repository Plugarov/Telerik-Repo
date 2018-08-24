


navigator.geolocation.getCurrentPosition(
    function success(pos) {
        var root = document.getElementById('bomb')
        var src = "http://maps.googleapis.com/maps/api/staticmap?center=" + pos.coords.latitude + "," + pos.coords.longitude + "&zoom=13&size=500x500&sensor=false";

        var img = document.createElement('img');
        img.setAttribute('src', src);

        root.appendChild(img);
    },
    function error(err) {
        console.log(err);
    },
    options = {
        enableHighAccuracy: true,
        timeout: 5000,
        maximumAge: 0
    });