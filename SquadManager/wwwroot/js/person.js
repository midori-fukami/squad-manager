$('form').on('submit', function (event) {
    event.preventDefault();

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    var type = document.getElementById('type').value;

    var raw = JSON.stringify({
        "id": $("#Id").val() != "" ? parseInt($("#Id").val()) : 0,
        "name": $("#name").val(),
        "email": $("#email").val(),
        "type": type
    });

    var requestOptions = {
        method: $("#Id").val() != null && $("#Id").val() != "" ? 'PATCH' : 'POST',
        headers: myHeaders,
        body: raw,
        redirect: 'follow'
    };

    fetch("https://localhost:44317/api/Person/" + ($("#Id").val() != null && $("#Id").val() != "" ? 'update' : 'create'), requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));
});