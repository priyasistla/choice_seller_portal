$(document).ready(function () {
    merchantid = Cookies.get('_id');
    name = Cookies.get('name');
    email=Cookies.get('email');
    phone=Cookies.get('phonenum');
    address=Cookies.get('address');
   // password = Cookies.get('pass');
    //merchantid = Cookies.get('_id');
    $("#lab_name").val(name);
    $("#lab_name").html(name);
     
    $("#lab_address").val(address);
    $("#lab_address").html(address);
    $("#lab_email").val(email);
    $("#lab_email").html(email);
    $("#lab_phnum").val(phone);
    $("#lab_phnum").html(phone);



    });
