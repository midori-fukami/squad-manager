$('form').on('submit', function (event) {
    event.preventDefault();

    if ($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show();

        setTimeout(function () {
            $(".error span").hide();
        }, 3000)

        return;
    }

    var formData = {
        username: $("#username").val(),
        email: $("#email").val(),
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:44317/api/user/create",
        success: function (result) {
            if (result.response == 'OK')
                alert("Criado")
            else
                alert("Não foi possível criar")
        },
        error: function (error) {
            console.log(error);
        }
    })
});