
$(document).ready(function () {
        if ($("#rb_6_aqui_vivienda input:checked").val() == "false") {

        $("#row_tienen_tro_lugar").show();
    } else {
        $("#row_tienen_tro_lugar").hide();
    }

    if ($("#rb_personas_otro_lugar_vivir input:checked").val() == "true") {

        $("#row_numero_personas_otra_vivienda").show();
    } else {
        $("#row_numero_personas_otra_vivienda").hide();
    }


    if ($("#rb_alguna_personas_viviendo_otra_parte input:checked").val() == "true") {

        $("#row_personas_ausentes_menos_6_meses").show();
    } else {
        $("#row_personas_ausentes_menos_6_meses").hide();
    }


    if ($("#rb_personas_ausentes_menos_6_meses input:checked").val() == "true") {

        $("#row_numero_personas_ausentes_menos_6_meses").show();
    } else {
        $("#row_numero_personas_ausentes_menos_6_meses").hide();
    }



    if ($("#rb_servicio_domestico input:checked").val() == "true") {

        $("#row_servico_domestico").show();
    } else {
        $("#row_servico_domestico").hide();
    }

    if ($("#rb_alquilan_carto input:checked").val() == "true") {

        $("#row_servico_alquiler_cuarto").show();
    } else {
        $("#row_servico_alquiler_cuarto").hide();
    }
    if ($("#rb_resibido_bono input:checked").val() == "true") {

        $("#row_ano_bono").show();
        $("#row_tipo_bono").show();
        $("#row_solicito_bono").hide();
        $(".recibio").hide();

        recibio
      //  hide asta seccion r

    } else {
        $("#row_ano_bono").hide();
        $("#row_tipo_bono").hide();
        $("#row_solicito_bono").show();
        
    }
    if ($("#rb_solicitud_bono input:checked").val() == "true") {

        $("#row_razon_no_recibir").show();
    } else {
        $("#row_razon_no_recibir").hide();
    }

    if ($("#rb_razon_no_recibir input:checked").val() == "OTRO") {

        $("#row_especifique_no_resibir").show();
    } else {
        $("#row_especifique_no_resibir").hide();
    }

    if ($("#rb_razon_no_solicitar input:checked").val() == "OTRO") {

        $("#row_razon_no_solicitar").show();
    } else {
        $("#row_razon_no_solicitar").hide();
    }
    
    
    
});