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
            if (data == null) {
                $('#responseDiv').html("There is no such backer");
            }
            else {
                projectCreatorid = data["id"]
                FullName = data["FullName"]
                Address = data["Address"]
                Email = data["Email"]
                Phone = data["Phone"]
                alert('You have successfully login')
                window.open("/Home/ProfileProjectCreator?projectCreatorid=" + projectCreatorid, "_self")

            }

           
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}

function createProject(projectcreatorid) {


    actionMethod = "POST"
    actionUrl = "/apiprojectcreator/AddProject"
    //   

    sendData = {
        "Category": $('#Category').val(),
        "ProjectCreatorId": projectcreatorid,
        "Title": $('#Title').val(),
        "Description": $('#Description').val(),
        "StatusUpdate": $('#StatusUpdate').val(),
        "Goal": parseFloat($('#Goal').val())
    }

    alert(JSON.stringify(sendData))
    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html(JSON.stringify(data));

            alert('You have successfully add project')
            window.open("/Home/ProfileProjectCreator?projectcreatorid=" + projectcreatorid, "_self")
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}

function ProfileToAddProject(projCreatorId)
{
    window.open("/Home/AddProject?projCreatorId=" + projCreatorId, "_self");
}

function ProfileProject(projectId) {
    
    window.open("/Home/ProfileProject?ProjectId=" + projectId, "_self");
    
}

function ProfileToShowTrendingProject(backerId)
{
    window.open("/Home/TrendsProjects?backerId=" + backerId, "_self");
}
$('#loginButton').click(
    function () {

        actionMethod = "POST"
        actionUrl = "/apiprojectcreator/login"
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
                    $('#responseDiv').html("There is no such Project Creator");
                }
                else {
                    projectCreatorid = data["id"]
                    FullName = data["FullName"]
                    Address = data["Address"]
                    Email = data["Email"]
                    Phone = data["Phone"]
                    alert('You have successfully login')
                    window.open("/Home/ProfileProjectCreator?projectCreatorid=" + projectCreatorid , "_self")
                      
                }

            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });



    }

);

$('#loginBackerButton').click(
    function () {

        actionMethod = "POST"
        actionUrl = "/apibacker/loginBacker"
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
                    backerid = data["id"]
                    FullName = data["FullName"]
                    Address = data["Address"]
                    Email = data["Email"]
                    Phone = data["Phone"]
                    alert('You have successfully login')
                    window.open("/Home/ProfileBacker?backerid=" + backerid, "_self")

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
            if (data == null) {
                $('#responseDiv').html("There is no such backer");
            }
            else {
                backerid = data["id"]
                FullName = data["FullName"]
                Address = data["Address"]
                Email = data["Email"]
                Phone = data["Phone"]
                alert('You have successfully register')
                window.open("/Home/ProfileBacker?backerid=" + backerid, "_self")
            }
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }




    });
}



//function addProject() {
//    elementid = this.id
//    projectCreatorId = this.value
//    //basketId = $("#productsList").value
//    actionMethod = "POST"
//    actionUrl = "/apiprojectcreator/addproject"
//    sendData = {
//        "projectCreatorId": projectCreatorId,
//        //basketId": basketId
//    }
//    alert(JSON.stringify(sendData))
//    $.ajax({
//        url: actionUrl,
//        dataType: 'json',
//        type: actionMethod,
//        data: JSON.stringify(sendData),
//        contentType: 'application/json',
//        processData: false,
//        success: function (data, textStatus, jQxhr) {
//            //productName = data["name"] 
//            $('#MyBasket').append('<li><button href="#">' + productName + '</button></li>');
//            contr = '#' + elementid
//            $(contr).off('click');
//            $(contr).click(function () {
//                alert("cannot buy")
//            });
//            //     .attr("disabled", "disabled");
//        },
//        error: function (jqXhr, textStatus, errorThrown) {
//            console.log(errorThrown);
//        }
//    });
//}