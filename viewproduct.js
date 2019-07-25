$(document).ready(function () {
    
    tab_data = "";
     phonenumber = Cookies.get('phonenum');
    password = Cookies.get('pass');
    merchantid = Cookies.get('_id');
    name = Cookies.get('name');
    $('#label_merchant').val(name);
    $('#label_merchant').html(name);


    $.ajax({

        url: '/api/Table',
        type: "GET",
        data: { "uat": merchantid },
        success: function (data, e) {
            if (data.success == true) {
                $('#tab_view').DataTable({
                    data: data.num
                });
            }
            else {
                alert(data.message);
            }
        },

        failure: function (data) {
            alert("fail");
        }
    }); 
        
 });


    
