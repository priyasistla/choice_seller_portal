$(document).ready(function () {

    tab_data = "";
    //phonenumber = Cookies.get('phonenum');
    //password = Cookies.get('pass');
    merchantid = Cookies.get('_id');
       

    $.ajax({

        url: '/api/order',
        type: "GET",
        data: { "merchantid": merchantid },
        success: function (data, e) {
            if (data.success == true) {
                $('#tab_order').DataTable({
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

    /*url = '/api/Table';
    tab_data = '';
    $.get(url, function (data, e) {
        if (data.success == true) {
            $('#tab_view').Display({
                data: data.num
            });

        }
        else {
            alert(data.message);
        }

    });

*/

});



