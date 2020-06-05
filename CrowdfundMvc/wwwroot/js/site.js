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
        success: function (data) {
            if (data == null) {
            }
            else {
                projectCreatorid = data["id"]
                FullName = data["FullName"]
                Address = data["Address"]
                Email = data["Email"]
                Phone = data["Phone"]
                window.open("/Home/ProfileProjectCreator?projectCreatorid=" + projectCreatorid, "_self")

            }


        },
        error: function (errorThrown) {
            console.log(errorThrown);
        }
    });
}

function GoHome() {
    window.open("/Home/Index", "_self")
}

function editProject(projectId, projectreatorid) {
    window.open("/Home/EditProject?projectId=" + projectId + "&projectCreatorId=" + projectreatorid, "_self")

}

function ProfileProjectBacker(projectId, backerid) {

    window.open("/Home/ProfileProjectBacker?projectId=" + projectId + "&backerId=" + backerid, "_self")

}

function myFunction(backerId) {
    var x = document.getElementById("mySelect").value;
    window.open("/Home/ProjectsByCategory?projectCat=" + x + "&backerId=" + backerId, "_self");
}

function search(backerId) {
    var x = document.getElementById("srch").value;
    window.open("/Home/SearchProject?projectTitle=" + x + "&backerId=" + backerId, "_self");
}

$(document).ready(function () {
    $("#srch").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});

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
        success: function (data) {
            window.open("/Home/ProfileProject?ProjectId=" + projectId + "&projectCreatorId=" + projectreatorid, "_self")

        },
        error: function (errorThrown) {
            console.log(errorThrown);
        }
    });


}


function fund(fundId, backerId, projectId) {

    actionMethod = "POST"
    actionUrl = "/apibacker/addbackerfundingpackage"

    sendData = {
        "FundingPackageId": fundId,
        "BackerId": backerId,
        "ProjectId": projectId
    }

    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function () {
            window.open("/Home/ProfileBacker?backerId=" + backerId, "_self")
        },
        error: function (errorThrown) {
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

    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function () {
            window.open("/Home/ProfileProject?ProjectId=" + ProjectId + "&projectCreatorId=" + ProjectCreatorId, "_self")
        },
        error: function (errorThrown) {
            console.log(errorThrown);
        }
    });
}

function createProject(projectcreatorid) {


    actionMethod = "POST"
    actionUrl = "/apiprojectcreator/AddProject"

    sendData = {
        "Category": $('#Category').val(),
        "ProjectCreatorId": projectcreatorid,
        "Title": $('#Title').val(),
        "Description": $('#Description').val(),
        "StatusUpdate": $('#StatusUpdate').val(),
        "Goal": parseFloat($('#Goal').val())
    }

    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),
        contentType: 'application/json',
        processData: false,
        success: function () {
            window.open("/Home/ProfileProjectCreator?projectcreatorid=" + projectcreatorid, "_self")
        },
        error: function (errorThrown) {
            console.log(errorThrown);
        }
    });
}

function ProfileToAddProject(projCreatorId) {
    window.open("/Home/AddProject?projCreatorId=" + projCreatorId, "_self");
}

function ProjectCreator() {
    window.open("/Home/ProjectCreator", "_self");
}

function ContractStelios() {
    window.open("https://www.linkedin.com/in/chatzikechagias/");
}

function ContractPaschalis() {
    window.open("https://www.linkedin.com/in/paschalis-madikas-b34585b8/");
}

function ContractMichalis() {
    window.open("https://www.linkedin.com/in/michalis-chatziparaskevas/");
}

function Backer() {
    window.open("/Home/Backer", "_self");
}

function RegisterCreator() {
    window.open("/Home/AddProjectCreator", "_self");
}

function LoginCreator() {
    window.open("/Home/Login", "_self");
}

function RegisterBacker() {
    window.open("/Home/AddBacker", "_self");
}

function LoginBacker() {
    window.open("/Home/LoginBacker", "_self");
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
    window.open("/Home/ProfileProject?projectId=" + projectId + "&projectCreatorId=" + projectCreatorId, "_self");
}

function ProfileToShowTrendingProject(backerId) {
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
            success: function (data) {
                if (data == null) {
                }
                else {
                    projectCreatorid = data["id"]
                    FullName = data["FullName"]
                    Address = data["Address"]
                    Email = data["Email"]
                    Phone = data["Phone"]
                    window.open("/Home/ProfileProjectCreator?projectCreatorid=" + projectCreatorid, "_self")

                }

            },
            error: function (errorThrown) {
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
            success: function (data) {
                if (data == null) {
                }
                else {
                    backerid = data["id"]
                    FullName = data["FullName"]
                    Address = data["Address"]
                    Email = data["Email"]
                    Phone = data["Phone"]
                    window.open("/Home/ProfileBacker?backerid=" + backerid, "_self")
                }

            },
            error: function (errorThrown) {
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
        success: function (data) {
            $('#responseDiv').html(JSON.stringify(data));
            $('#Title').val("");
            $('#Description').val("")
            $('#StatusUpdate').val("")
            $('#Goal').val("")
            $('#Category').val("")
        },
        error: function (errorThrown) {
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
        success: function (data) {
            if (data == null) {
            }
            else {
                backerid = data["id"]
                FullName = data["FullName"]
                Address = data["Address"]
                Email = data["Email"]
                Phone = data["Phone"]
                window.open("/Home/ProfileBacker?backerid=" + backerid, "_self")
            }
        },
        error: function (errorThrown) {
            console.log(errorThrown);
        }




    });
}