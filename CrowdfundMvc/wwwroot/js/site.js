function submitProjectCreatorToServer() {
 
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
            //customerId = data["id"]
            alert('You have successfully registered')
            //window.open("/Home/Shopping?customerId=" + customerId, "_self")
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