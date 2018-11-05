
$(document).ready(function () {

    $(".montos").mask("999,999,999");
    $(".telefono").mask("9999-9999");
    $(".fecha").mask("9999");
    $(".cantidad").mask("99");

    $(".alfanumerico").mask(
        'ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ',
        { translation: { 'Z': { pattern: /[a-zA-Z0-9\s]/, recursive: true } } });
});
