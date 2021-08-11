$('form').on('submit', function (event) {
    event.preventDefault();

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json;charset=UTF-8",        
        data: JSON.stringify($("#email").val()),
        url: "https://localhost:44317/api/User/forgot",
        success: function (result) {
            if (result.response == 'OK')
                alert("E-mail foi enviado para recuperar a senha");
            else
                alert("Erro inesperado");
        },
        error: function (error) {
            console.log(error);
        }
    });
});