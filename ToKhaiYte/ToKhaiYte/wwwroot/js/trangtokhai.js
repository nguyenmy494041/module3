function capitaliseName() {
    var str = document.getElementById("name").value;
    document.getElementById("name").value = str.charAt(0).toUpperCase() + str.slice(1);

}