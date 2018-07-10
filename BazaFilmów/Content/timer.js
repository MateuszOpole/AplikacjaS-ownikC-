var numer = 1;

var timer1 = 0;
var timer2 = 0;
 
function zmienslajd() {


    var plik = "<img  class=\"picture\" src=\"/Content/img/ben" + numer + ".jpg\" / >";

    document.getElementById("pictures").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/sny" + numer + ".jpg\" / >";


    document.getElementById("pictures1").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/wilk" + numer + ".jpg\" / >";

    document.getElementById("pictures2").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/kod" + numer + ".jpg\" / >";

    document.getElementById("pictures3").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/bond" + numer + ".jpg\" / >";

    document.getElementById("pictures4").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/bat" + numer + ".jpg\" / >";

    document.getElementById("pictures5").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/tyk" + numer + ".jpg\" / >";

    document.getElementById("pictures6").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/forrest" + numer + ".jpg\" / >";

    document.getElementById("pictures7").innerHTML = plik;
    var plik = "<img  class=\"picture\" src=\"/Content/img/lego" + numer + ".jpg\" / >";

    document.getElementById("pictures8").innerHTML = plik;
    numer++; if (numer > 3) numer = 1;

    $("#pictures").fadeIn(500);
    $("#pictures1").fadeIn(500);
    $("#pictures2").fadeIn(500);
    $("#pictures3").fadeIn(500);
    $("#pictures4").fadeIn(500);
    $("#pictures5").fadeIn(500);
    $("#pictures6").fadeIn(500);
    $("#pictures7").fadeIn(500);
    $("#pictures8").fadeIn(500);
    timer1 = setTimeout("zmienslajd()", 5000);

    timer2 = setTimeout("schowaj()", 2500);

}
function schowaj() {
    $("#pictures").fadeOut(600);
    $("#pictures1").fadeOut(600);
    $("#pictures2").fadeOut(600);
    $("#pictures3").fadeOut(600);
    $("#pictures4").fadeOut(600);
    $("#pictures5").fadeOut(600);
    $("#pictures6").fadeOut(600);
    $("#pictures7").fadeOut(600);
    $("#pictures8").fadeOut(600);
}
