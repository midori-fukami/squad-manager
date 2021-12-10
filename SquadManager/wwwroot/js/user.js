$('form').on('submit', function (event) {
    event.preventDefault();

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
        "id": parseInt($("#UserId").val()),
        "password": $("#password").val(),
        "confirmPassword": $("#confirmPassword").val(),
        "personId": parseInt($("#PersonId").val()),
        "person": {
            "id": parseInt($("#PersonId").val()),
            "username": $("#username").val(),
            "email": $("#email").val()
        }
    });

    var requestOptions = {
        method: 'PATCH',
        headers: myHeaders,
        body: raw,
        redirect: 'follow'
    };

    fetch("https://localhost:44317/api/User/update", requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));
});