module.export = function checkIfMozilla() {
    var browserName = navigator.appCodeName,
        isMozilla = browserName == "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}
