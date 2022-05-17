//For Enter Key Press Event
function runScript(e) {
    if (e.keyCode == 13) {

        //Call GetNews Function
        GetNews();

        return false;
    }
}

//Function for GetNews Using Ajax Post Method
function GetNews() {

    //Set FadeIn for Progressive Div
    $("#ProgressiveDiv").fadeIn();

    //Create Ajax Post Method
    $.ajax({
        type: "POST", // Ajax Method
        url: "News.aspx/GetNewsContent",  //Page URL / Method name
        data: "{'NewsParameters':'" +
            document.getElementById("txtSubject").value + "'}", // Pass Parameters
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (data) { // Function call on success

            $("#DivNews").empty(); // Set Div Empty

            //Set For loop for binding Div Row wise
            for (var i = 0; i < data.d.length; i++) {

                //Design Div Dynamically using append
                $("#DivNews").append("<tr><td>"
                     + data.d[i].title +
                    data.d[i].Description + "</td></tr>");
            }

            //set fadeOut for ProgressiveDiv
            $("#ProgressiveDiv").fadeOut(500);
        },

        error: function (result) { // Function call on failure or error
            alert(result.d);
        }
    });
}