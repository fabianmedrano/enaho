var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    Console.log("CLick");
    acc[i].addEventListener("click", function () {

        Console.log("CLick");
        /* Toggle between adding and removing the "active" class,
        to highlight the button that controls the panel */
        this.classList.toggle("active");

        /* Toggle between hiding and showing the active panel */
        var contenido = document.getElementsByClassName("contenido");
        if (contenido.style.display === "block") {
            contenido.style.display = "none";
        } else {
            contenido.style.display = "block";
        }
    });
} 