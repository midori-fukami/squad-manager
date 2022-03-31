$('form').on('submit', function (event) {
    event.preventDefault();

    var formData = {
        "password": $("#password").val(),
        "username": $("#email").val(),
        "person": {
            "email": $("#email").val(),
        }
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:44317/api/user",
        success: function (result) {
            if (result.response == 'ERROR')
                alert("Credenciais inválidas")
            else {
                let baseUrl = $('#btnLogin').data('url');
                window.location = baseUrl + "?" +
                    "UserId=" + result.userId +
                    "&PersonId=" + result.personId +
                    "&Username=" + result.username +
                    "&Email=" + result.email;
            }                
        },
        error: function (error) {
            console.log(error);
        }
    })
});