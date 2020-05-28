function submitProjectCreatorToServer(projectcreatorid) {
 
    actionMethod = "POST"
    actionUrl = "/apiprojectcreator/addprojectcreator"
    sendData = {
        "FullName": $('#FullName').val(),
        "Address": $('#Address').val(),
        "Email": $('#Email').val(),
        "Phone": $('#Phone').val()
    }
    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html(JSON.stringify(data));
            $('#FullName').val("");
            $('#Address').val("")
            $('#Email').val("")
            $('#Phone').val("")
            projectcreatorid = data["id"]
            //alert('You have successfully registered')
            window.open("/AddProject?projectcreatorid=" + projectcreatorid, "_self")

           
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}

$('#loginButton').click(
    function () {

        actionMethod = "POST"
        actionUrl = "/apibacker/login"
        sendData = {
            "Email": $('#Email').val()
        }
        $.ajax({
            url: actionUrl,
            dataType: 'json',
            type: actionMethod,
            data: JSON.stringify(sendData),

            contentType: 'application/json',
            processData: false,
            success: function (data, textStatus, jQxhr) {
                if (data == null) {
                    $('#responseDiv').html("There is no such backer");
                }
                else {
                    //backerId = data["id"]
                    alert('You have successfully login')
                    //window.open("/Home/addproject?backerId="+backerId,"_self")
                }

            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });



    }

);

function submitProjectToServer(projectcreatorid) {

    actionMethod = "POST"
    actionUrl = "/apiprojectcreator/addproject"
    sendData = {
        "Title": $('#Title').val(),
        "Description": $('#Description').val(),
        "StatusUpdate": $('#StatusUpdate').val(),
        "Goal": $('#Goal').val(),
        "Category": $('#Category').val(),
        "ProjectCreatorId": projectcreatorid

    }
    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html(JSON.stringify(data));
            $('#Title').val("");
            $('#Description').val("")
            $('#StatusUpdate').val("")
            $('#Goal').val("")
            $('#Category').val("")
           // projectcreatorid = data["id"]
            alert('You have successfully add project')
            //window.open("/Home/AddProject?projectcreatorid=" + projectcreatorid, "_self")
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}

function submitBackerToServer() {
 
    actionMethod = "POST"
    actionUrl = "/apibacker/addbacker"
    sendData = {
        "FullName": $('#FullName').val(),
        "Address": $('#Address').val(),
        "Email": $('#Email').val(),
        "Phone": $('#Phone').val()
    }
    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html(JSON.stringify(data));
            $('#FullName').val("");
            $('#Address').val("")
            $('#Email').val("")
            $('#Phone').val("")
            //customerId = data["id"]
            alert('You have successfully registered')
            //window.open("/Home/Shopping?customerId=" + customerId, "_self")
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}