$(document).ready(function () {
    $('#btnSubmit').click(function(e){
        if ($('#ddlStatus').val() == '0') {
            $('#ddlError').css('visibility', 'visible');
            $('#ddlError').text("Status Required").addClass("text-danger");;
            e.preventDefault();
        }
        else {
            $('#ddlError').text("").removeClass("text-danger");
            $('#ddlError').text("");
            $('#ddlError').css('visibility', 'hidden');
        }
    });
});