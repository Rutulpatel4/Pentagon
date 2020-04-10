function geoFindMe() {
    const status = document.querySelector("#status");


    function success(position) {
        const latitude = position.coords.latitude;
        const longitude = position.coords.longitude;

        status.textContent =
            "latitude = " + latitude + ",  longitude = " + longitude;
        //alert("latitude = " + latitude + ",  longitude = " + longitude);
    }

    function error() {
        status.textContent = "Unable to retrieve your location";
    }

    if (!navigator.geolocation) {
        status.textContent = "Geolocation is not supported by your browser";
    } else {
        status.textContent = "Locating…";
        navigator.geolocation.watchPosition(success, error);
    }
}

window.onload = geoFindMe();