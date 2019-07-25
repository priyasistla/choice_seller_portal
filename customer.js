$(document).ready(function () {
    
    
    $('#order').click(function () {
         
        var name = "";
        name = $('#name').val();
        var phone = $('#num').val();
        var email = $('#email').val();
        var pname = $('#pro_name').val();
        var address = $('#add').val();
        $.ajax({
            url: '/api/customer/get',
            type: "GET",
            //Access-Control-Allow-Origin: "",
            data: { "name": name, "phone": phone, "email": email,"pname":pname, "address": address},
            success: function (data) {
                alert(data);
                window.location.href = "login.html";



            },
            failure: function (data) {
                alert("1" + data);
            },


        });
        alert("Hello");


    });
    
            
            

            

            
       
        
    
});
