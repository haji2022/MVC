function listPeople() {
    //alert();
    $.ajax({
        type: "GET",
        url: "/Ajax/People",
        dataType: "html",
        success: function (response) {
            $("#show").html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

/*function Delete() {
    var id = document.getElementById("personId").value
    $.ajax({
        type: "GET",
        url: `Ajax/Delete/${id}`,
        success: function (output) {
            console.log(output);
            alert(`Ajax delete, success id ${id}`);
            document.getElementById("show").innerHTML = output;
        }
    })
}*/
function deletePerson() {
    var value = $("#personId").val();
    alert(value);
    $.ajax({
        type: "POST",
        url: "/Ajax/Delete",
        dataType: "html",
        data: { id: value },
        success: function (response) {
            $("#show").html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

function personDetails() {
    var value = $("#personId").val();
    alert(value);
    $.ajax({
        type: "POST",
        url: "/Ajax/Details",
        dataType: "html",
        data: { Id: value },
        success: function (response) {
            $("#show").html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

