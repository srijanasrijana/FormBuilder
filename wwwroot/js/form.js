$(document).ready(function () {
    $("#jsonForm").submit(function (e) {
        e.preventDefault(); // avoid to execute the actual submit of the form.

        var form = $(this);
        var actionUrl = form.attr('action');
        var data = JSON.parse(($("#json").val()));
        $.ajax({
            type: "POST",
            url: actionUrl,
            dataType: "JSON",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(data),
            success: function (response) {
                if (response.status == true) {
                    $("#htmlForm").html(response.htmlForm);
                }
            }
        });

    });
});