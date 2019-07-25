$(document).ready(function () {
    var pname = $('#prod_nm').val();

    tab_data = "";
   



    $.ajax({

        url: '/api/mer',
        type: "GET",
        data: {"pname": pname},
        success: function (data, e) {
            if (data.success == true) {
                $("#tab_order").DataTable({
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



