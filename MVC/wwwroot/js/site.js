

//for ajax controller
function showPerson() {

    $.ajax({
        type: "GET",
        url: "Ajax/People",
        success: function (output) {
            console.log(output);
            alert('Ajax show, success');
            document.getElementById("show").innerHTML = output;

        }
    })
}


function deletePerson() {
    var id = document.getElementById("Id").value
    $.ajax({
        type: "GET",
        url: `Ajax/Delete/${id}`,
        success: function (output) {
            console.log(output);
            alert(`Ajax delete, success id ${id}`);
            document.getElementById("show").innerHTML = output;
        }
    })
}


function personDetails() {
    var id = document.getElementById("Id").value;
    $.ajax({
        type: "POST",
        url: `Ajax/Details/${id}`,
        success: function (output) {
            alert(`Ajax details, success id ${id}`);
            document.getElementById("show").innerHTML = output;

        }
    })
}