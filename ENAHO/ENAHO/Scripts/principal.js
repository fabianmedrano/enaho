$(document).ready(function () {

    $("#row_pagaria_mesualidad").hide();
    $("#row_mensualidad").hide();
    $("#row_tb_material__predominante_vivienda").hide();
    $("#row_material__predominante_techo").hide();


    if ($("#rb_mismo_prespuesto input:checked").val() == "NO") {

        $("#row_numero_hogares_vivienda").show();
    } else {
        $("#row_numero_hogares_vivienda").hide();
    }

    if ($("#rb_tipo_vivienda input:checked").val() == "OTRO") {

        $("#row_especificar_tipo_vivienda").show();
    } else {
        $("#row_especificar_tipo_vivienda").hide();
    }
    ///           VIVIENDA Y SERVICIOS
    if (
        ($("#rb_esta_vivienda input:checked").val() == "1") ||
        ($("#rb_esta_vivienda input:checked").val() == "2") ||
        ($("#rb_esta_vivienda input:checked").val() == "5")
    ) {

        $("#row_pagaria_mesualidad").show();
    } else {
        $("#row_pagaria_mesualidad").hide();
    }


    if (
        ($("#rb_esta_vivienda input:checked").val() == "3") ||
        ($("#rb_esta_vivienda input:checked").val() == "2")
    ) {

        $("#row_mensualidad").show();
    } else {
        $("#row_mensualidad").hide();
    }

    if ($("#rb_material_predominante_vivienda input:checked").val() == "OTRO") {

        $("#row_tb_material__predominante_vivienda").show();

    } else {
        $("#row_tb_material__predominante_vivienda").hide();
    }

    if ($("#rb_material__predominante_techo input:checked").val() == "OTRO") {

        $("#row_material__predominante_techo").show();

    } else {
        $("#row_material__predominante_techo").hide();
    }

    if ($("#rb_material__predominante_piso input:checked").val() == "OTRO") {

        $("#row_material__predominante_piso").show();

    } else {
        $("#row_material__predominante_piso").hide();
    }
    if ($("#rb_origen_agua_consumo input:checked").val() == "OTRO") {

        $("#row_origen_agua_consumo").show();

    } else {
        $("#row_origen_agua_consumo").hide();
    }
    if ($("#rb_servicio_sanitario input:checked").val() == "OTRO") {

        $("#row_servicio_sanitario").show();

    } else {
        $("#row_servicio_sanitario").hide();
    }
    if ($("#rb_tiene_banos input:checked").val() == "1") {

        $("#line_uso_bano").show();
        $("#row_tiene_banos").show();

    } else {
        $("#row_tiene_banos").hide();
        $("#line_uso_bano").hide();
    }
    if ($("#rb_tiene_banos input:checked").val() == "2") {

        $("#row_uso_bano").hide();
    } else {
        $("#row_uso_bano").show();
    }

    if ($("#rb_luz_electrica input:checked").val() == "OTRO") {

        $("#row_luz_electrica").show();
    } else {

        $("#row_luz_electrica").hide();
    }
    if ($("#rb_energia_cosinar input:checked").val() == "OTRO") {

        $("#row_energia_cosinar").show();
    } else {

        $("#row_energia_cosinar").hide();
    }
    if ($("#rb_eliminar_basura input:checked").val() == "OTRO") {

        $("#row_eliminar_basura").show();
    } else {

        $("#row_eliminar_basura").hide();
    }
    
});