$(document).ready(function () {

    $(".rect").show();
    $(".circ").hide();


    $("#shapeType").on("change", function () {
        var val = $(this).val();
        if (val == "1") {
            $(".tect").show();
            $(".circ").hide();
        }
        if (val == "2") {
            $(".rect").hide();
            $(".circ").show();

        }


    });



})