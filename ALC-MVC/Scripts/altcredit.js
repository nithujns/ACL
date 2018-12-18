    $(document).ready(function () {

        $("button#close_model_button").click(function () {
           // alert("Hai");
            $("#liModal-21").hide();
            //  $("#liModal-21").css("style","display:none;");
        });


        //$('#button').submit(function (e) {
        //    e.preventDefault();
        //    // Coding
        //    $('#IDModal').modal('toggle'); //or  $('#IDModal').modal('hide');
        //    return false;
        //});


        $("form#contact_form").submit(function (event) {
            //alert("Submitted");
            event.preventDefault();

            var post_url = "/Home/ajaxContact" //get form action url
            var request_method = $(this).attr("method"); //get form GET/POST method
            var form_data = $(this).serialize(); //Encode form elements for submission

            $.ajax({
                type: "POST",
                url: post_url,
                data: form_data,
                //contentType: "application/json; charset=utf-8",
               // data: '{"userName":"' + $("#usernameInput").val() + '","password":"' + $("#passwordInput").val() + '"}',
               // dataType: "html",
                success: function (result, status, xhr) {
                    $('#SuccessErrorMsgPanel').append('<h4> Contact details saved successfully! Our rep will contact you </h4><p>');
                    $('#SuccessErrorMsgPanel').show();

                    //alert("Thank you for your inputs - xxx");
                    $("#liModal-21").hide();

                    

                    //$("#dataDiv").html(result);
                },
                error: function (xhr, status, error) {
                    //$("#dataDiv").html("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
                }
            });  

        });

            });