$(document).ready(function () {
    if ($("#rb_mismo_prespuesto input:checked").val() == "NO") {

        $("#row_numero_hogares_vivienda").show();
    }else {
         $("#row_numero_hogares_vivienda").hide();
    }

    if ($("#rb_tipo_vivienda input:checked").val() == "OTRO") {

        $("#row_especificar_tipo_vivienda").show();
    } else {
        $("#row_especificar_tipo_vivienda").hide();
    }
    
});