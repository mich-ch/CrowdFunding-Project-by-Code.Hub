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

function editProject(projectId, projectreatorid) {
    
    alert(projectId);
    alert(projectreatorid);
    window.open("/Home/EditProject?projectId=" + projectId + "&projectCreatorId=" + projectreatorid, "_self")

}

function myFunction(backerId) {
    var x = document.getElementById("mySelect").value;
    window.open("/Home/ProjectsByCategory?projectCat=" + x + "&backerId=" + backerId, "_self");
}

function search( backerId) {
    var x = document.getElementById("srch").value;
    window.open("/Home/SearchProject?projectTitle=" + x + "&backerId=" + backerId, "_self");
}



function doUpdateProject(projectId, projectreatorid) {
    actionMethod = "PUT"
    actionUrl = "/apiprojectcreator/updateproject"
    sendData = {
        "Category": $('#Category').val(),
        "ProjectCreatorId": projectreatorid,
        "Title": $('#Title').val(),
        "Description": $('#Description').val(),
        "StatusUpdate": $('#StatusUpdate').val(),
        "ProjectId": projectId,
        "Goal": parseFloat($('#Goal').val())

    }

    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),

        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html("The update has been made successfully");
            window.open("/Home/ProfileProject?ProjectId=" + projectId + "&projectCreatorId=" + projectreatorid, "_self")

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });


}


function fund(fundId, backerId, projectId) {
    
    actionMethod = "POST"
    actionUrl = "/apibacker/addbackerfundingpackage"
    //   
   

    sendData = {
        "FundingPackageId": fundId,
        "BackerId": backerId,
        "ProjectId": projectId
       
    }
 

    alert(JSON.stringify(sendData))
    //window.open("/Home/ProfileBacker?backerId=" + backerId, "_self")

    $.ajax({    //EDW DEN MPAINEI STH SUCCESS
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
            $('#responseDiv').html(JSON.stringify(data));

            alert('You have successfully add fund')
            window.open("/Home/ProfileBacker?backerId=" + backerId, "_self")
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}


function createpackage(ProjectId, ProjectCreatorId) {


    actionMethod = "POST"
    actionUrl = "/apiprojectcreator/addpackage"
      

    sendData = {
        "Price": parseFloat($('#Price').val()),
        "ProjectId": ProjectId,
        "Reward": $('#Reward').val()
        
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

            alert('You have successfully add package')
            window.open("/Home/ProfileProject?ProjectId=" + ProjectId + "&projectCreatorId=" + ProjectCreatorId, "_self")
         

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

function ShowFundingPackages(backerId, projectId) {
 
    
    window.open("/Home/Fund?projectId=" + projectId + "&backerId=" + backerId, "_self");
}

function ShowAlProjects(backerId) {
    window.open("/Home/Projects?backerId=" + backerId, "_self");
}

function addpackage(ProjectId, ProjectCreatorId) {
    window.open("/Home/AddFundingPackage?ProjectId=" + ProjectId + "&projectCreatorId=" + ProjectCreatorId, "_self");
    

}

function ProfileProject(projectId, projectCreatorId) {
    //edw
    
    //window.open("/Home/ProfileProject?projectCreatorId=" + projectId, "_self");
    window.open("/Home/ProfileProject?projectId=" + projectId + "&projectCreatorId=" + projectCreatorId, "_self");

    
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