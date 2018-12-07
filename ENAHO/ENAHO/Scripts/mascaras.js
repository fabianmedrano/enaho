
$(document).ready(function () {

    $(".montos").mask("999.999", { reverse: true });
    $(".telefono").mask("9999-9999", { placeholder: '9999-9999' });
    $(".fecha").mask("9999");
    $(".cantidad").mask("99");

    $(".direccion").mask('AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA ',
        { placeholder: '150m este super todo gratis ' });
    $(".texto100").mask('AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA')

    $("#lt").mask("aaaaaaaaaaaaa");

});
