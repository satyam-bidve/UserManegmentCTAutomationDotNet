$(document).ready(function () {
    $(".Edit-button").click(function () {
        var userid = $(this).attr('data-id');
        console.log(userid);
        // send this userid to web service then controller and get user details 
        $.ajax({
            type: "POST",
            url: "/API/UserWebService.asmx/GetStudentDetailsByID",
            data: JSON.stringify({ userid: userid }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                if (response.d != undefined) {
                  
                   
                    // Populate your form fields with the user details
                    $("#User_Name").val(response.d.UserName);
                    $("#Role_Name").val(response.d.UserRole);
                    $("#Mobile_no").val(response.d.UserPhone);
                    $("#Email_ID").val(response.d.UserEmail);
                    console.log("Data fetched");
                    window.location = "UpdateUser.aspx";
                } else {
                    console.error("No data received from server");
                }
            },
            error: function (xhr, textStatus, errorThrown) {
               /* console.error("AJAX error:", errorThrown);*/
            }
        });

    });


    $(".delete-button").click(function () {
        var userid = $(this).attr('data-id');
        console.log(userid);
        if (confirm("Do you want to delete this Record?")) {
            //var row = $(this).closest("tr");
            $.ajax({
                type: "POST",
                url: "/API/UserWebService.asmx/DeleteUserByID",
                data: JSON.stringify({ userid: userid }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    location.reload()
                
                }
            });
        }
       
    });
});
