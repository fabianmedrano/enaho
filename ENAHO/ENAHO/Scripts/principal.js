$(document).ready(function () {
    $("#row_numero_hogares_vivienda").hide();
    if ($("#rb_mismo_prespuesto input:checked").val() == "NO") {

        $("#row_numero_hogares_vivienda").show();
    }else {
         $("#row_numero_hogares_vivienda").hide();
    }

});