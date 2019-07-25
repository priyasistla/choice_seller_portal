$(document).ready(function () {
    $("#but_login").click(function (e) {
        e.preventDefault();
        var phone = $("#tb_phonenum").val();
        var password = $("#tb_pass").val();
        var name = $("tb_name").val();


        

        $.ajax({
            url: '/api/login/post',
            type: "GET",
            data: { "phone": phone, "password": password },
            success: function (data) {

                    console.log(data);
                if (data.message == "Success")
                {
                    alert(data.uat);
                    // save the UAT, username in cookies
                    // on merchant page, load the UAT and username from cookies and display name on page
                    Cookies.set('phonenum', phone);
                    Cookies.set('pass', password);
                    Cookies.set('_id', data.uat);
                    Cookies.set('name', data.name);
                    Cookies.set('email', data.email);
                    Cookies.set('phone', data.phone);
                    Cookies.set('address', data.address);



                    window.location.href = "merchant.html";
                    
                   
                    
                }
                else
                {
                    alert("Not Successful, Try again");
                }
                console.log(data);

            },
            failure: function (data) {
                alert("1" + data.message);
            },

        });

    });

});


