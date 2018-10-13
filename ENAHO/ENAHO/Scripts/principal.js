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
    if ($("#rb_telefono_celular input:checked").val() == "1") {

        $("#tb_cantidad_telefonos").show();
    } else {

        $("#tb_cantidad_telefonos").hide();
    }
    if ($("#rb_telefono_recidencia input:checked").val() == "1") {

        $("#tb_telefono_recidencia_cantidad").show();
    } else {

        $("#tb_telefono_recidencia_cantidad").hide();
    }

    if ($("#rb_pc_portatil input:checked").val() == "1") {

        $("#tb_pc_portatil_cantidad").show();
    } else {

        $("#tb_pc_portatil_cantidad").hide();
    }
    if ($("#rb_pc_escritorio input:checked").val() == "1") {

        $("#tb_pc_escritorio_cantidad").show();
    } else {

        $("#tb_pc_escritorio_cantidad").hide();
    }
    if ($("#rb_tableta input:checked").val() == "1") {

        $("#tb_tableta_cantidad").show();
    } else {

        $("#tb_tableta_cantidad").hide();
    }
    
    if ($("#rb_fax input:checked").val() == "1") {

        $("#tb_fax_cantidad").show();
    } else {

        $("#tb_fax_cantidad").hide();
    }

    if ($("#rb_radio input:checked").val() == "1") {
        $("#tb_radio_cantidad").show();
    } else {
        $("#tb_radio_cantidad").hide();
    }

    if ($("#rb_carro input:checked").val() == "1") {
        $("#tb_carro_cantidad").show();
    } else {
        $("#tb_carro_cantidad").hide();
    }

    if ($("#rb_moto input:checked").val() == "1") {
        $("#tb_moto_cantidad").show();
    } else {
        $("#tb_moto_cantidad").hide();
    }

    if ($("#rb_tv input:checked").val() == "1") {
        $("#tb_tv_cantidad").show();
    } else {
        $("#tb_tv_cantidad").hide();
    }

    if ($("#rb_tv input:checked").val() == "1") {
        $("#tb_tv_cantidad").show();
    } else {
        $("#tb_tv_cantidad").hide();
    }
    if ($("#rb_tv_convencional input:checked").val() == "1") {
        $("#tb_tv_convencional_cantidad").show();
    } else {
        $("#tb_tv_convencional_cantidad").hide();
    }
    

    if ($("#rb_internet input:checked").val() == "1") {

        $("#seccion_tipo_coneccion").show();
        $("#seccion_empresa_internet").show();
        $("#seccion_router").show();

    } else {
        $("#seccion_tipo_coneccion").hide();
        $("#seccion_empresa_internet").hide();
        $("#seccion_router").hide();
    }

    if ($("#rb_tipo_coneccion input:checked").val() == "OTRO") {
        $("#row_tipo_coneccion").show();
    } else {
        $("#row_tipo_coneccion").hide();
    }
    
    
});