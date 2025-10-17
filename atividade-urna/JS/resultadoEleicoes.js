const votosNulosText = document.getElementById("votosNulosText");
const votosBrancosText = document.getElementById("votosBrancosText");

const votosValidosVereadorText = document.getElementById("votosValidosVereadorText");
const votosNaaraText = document.getElementById("votosNaaraText");
const votosKarolText = document.getElementById("votosKarolText");

const votosValidosPrefeitoText = document.getElementById("votosValidosPrefeitoText");
const votosFernandaText = document.getElementById("votosFernandaText");
const votosVitorugoText = document.getElementById("votosVitorugoText");

const vereadorText = document.getElementById("vereadorText");
const prefeitoText = document.getElementById("prefeitoText");

var votosNulos = localStorage.getItem("votosNulos");
var votosBrancos = localStorage.getItem("votosBrancos");

var votosKarol = localStorage.getItem("votosKarol");
var votosNaara = localStorage.getItem("votosNaara");

var votosFernanda = localStorage.getItem("votosFernanda");
var votosVitorugo = localStorage.getItem("votosVitorugo");

var votosValidosVereador = 0;
var votosValidosPrefeito = 0;

function resultadoEleicoes() {
    contabilizarVotos();

    preencherVotos();
}

function contabilizarVotos() {
    votosValidosVereador = votosNaara + votosKarol;
    votosValidosPrefeito = votosFernanda + votosVitorugo;
}

function preencherVotos() {
    if (votosNulos == 0) votosNulosText.innerText = 0;
    else votosNulosText.innerText = votosNulos;

    if (votosBrancos == 0) votosBrancosText.innerText = 0;
    else votosBrancosText.innerText = votosBrancos;

    if (votosValidosVereador == 0) {
        votosValidosVereadorText.innerText = 0;
        votosNaaraText.innerText = 0;
        votosKarolText.innerText = 0;
    }
    else {
        votosValidosVereadorText.innerText = votosValidosVereador;
        votosNaaraText.innerText = votosNaara;
        votosKarolText.innerText = votosKarol;
    }

    if (votosValidosPrefeito == 0) {
        votosValidosPrefeitoText.innerText = 0;
        votosFernandaText.innerText = 0;
        votosVitorugoText.innerText = 0;
    }
    else {
        votosValidosPrefeitoText.innerText = votosValidosPrefeito;
        votosFernandaText.innerText = votosFernanda;
        votosVitorugoText.innerText = votosVitorugo;
    }
}