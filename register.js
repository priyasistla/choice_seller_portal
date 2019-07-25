$(document).ready(function () {
    var name = "";
    $('#butt_signup').attr("disabled", true);
    $('#tb_password, #tb_repass').on('keyup', function () {
        if ($('#tb_password').val() == $('#tb_repass').val()) {
            $('#message').html('Matching').css('color', 'green');
            $('#butt_signup').attr("disabled", false);
            var name = "";
            name = $('#tb_name').val();
            var phone = $('#tb_phnum').val();
            var email = $('#tb_email').val();
            var shop_name = $('#tb_shopname').val();
            var password = $('#tb_password').val();
            var re_password = $('#tb_repass').val();




        }
        else {
            $('#message').html('Not Matching').css('color', 'red');
            $('#butt_signup').attr("disabled", true);
        }
    });
    $('#butt_signup').click(function (e) {
        e.preventDefault();
        name = $('#tb_name').val();
        phone = $('#tb_phnum').val();
        email = $('#tb_email').val();
        shop_name = $('#tb_shopname').val();
        password = $('#tb_password').val();
        re_password = $('#tb_repass').val();
        $.ajax({
            url: '/api/register',
            type: "GET",
            //Access-Control-Allow-Origin: "",
            data: { "name": name, "phone": phone, "email": email, "address": shop_name, "password": password, "re_pass": re_password },
            success: function (data) {
                alert(data),
                    window.location.href = "login.html";

                    

            },
            failure: function (data) {
                alert("1" + data);
            },


        });
        


    });
    
});
