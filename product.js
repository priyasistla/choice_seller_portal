$(document).ready(function () {  
    phonenumber = Cookies.get('phonenum');
    password = Cookies.get('pass');
    merchantid = Cookies.get('_id');

     
    var pname = "";
    pname = $('#tb_productname').val();
    var category = $('#tb_categories').val();
    var subcategory = $('#tb_subcategories').val();
    var productprice = $('#tb_productprice').val();
    var physicalprop = $('#tb_physical_prop').val();
       $('#but_add').click(function () {
         
        // var pname = "";
           pname = $('#tb_productname').val();
           category = $('#tb_categories').val();
           subcategory = $('#tb_subcategories').val();
           productprice = $('#tb_productprice').val();
           physicalprop = $('#tb_physical_prop').val();
           //phonenumber = "9874563210";
           alert(pname);
           alert(productprice);
           alert(subcategory);
           alert(category);
           alert(physicalprop);
         
          $.ajax({
                    url: '/api/product/get',
                    type: "GET",
              //Access-Control-Allow-Origin: "",
              data: { "pname": pname, "productprice": productprice, "category": category, "subcategory": subcategory, "physicalprop": physicalprop, "phonenumber": phonenumber },
              success: function (data)
              {
                  if (data.message == "Success") {
                      alert(data.message);

                  }  

              },
              failure: function (data)
              {
                        alert("1" + data);
               },

           });
                
      });   
});
