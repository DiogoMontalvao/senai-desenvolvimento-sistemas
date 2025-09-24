const css = document.getElementById("css");

const cargoText = document.getElementById("cargoText");

const numero1Text = document.getElementById("numero1Text");
const numero2Text = document.getElementById("numero2Text");
const numero3Text = document.getElementById("numero3Text");
const numero4Text = document.getElementById("numero4Text");
const numero5Text = document.getElementById("numero5Text");

const nomeText = document.getElementById("nomeText");
const partidoText = document.getElementById("partidoText");

const fotoCandidato = document.getElementById("fotoCandidato");

const umButton = document.getElementById("umButton");
const doisButton = document.getElementById("doisButton");
const tresButton = document.getElementById("tresButton");
const quatroButton = document.getElementById("quatroButton");
const cincoButton = document.getElementById("cincoButton");
const seisButton = document.getElementById("seisButton");
const seteButton = document.getElementById("seteButton");
const oitoButton = document.getElementById("oitoButton");
const noveButton = document.getElementById("noveButton");
const zeroButton = document.getElementById("zeroButton");

const brancoButton = document.getElementById("brancoButton");
const corrigeButton = document.getElementById("corrigeButton");
const confirmaButton = document.getElementById("confirmaButton");

const finalizarVotacaoButton = document.getElementById("finalizarVotacaoButton");
const proximoVotoButton = document.getElementById("proximoEleitorButton");

const numeroNaara = 12345;
const numeroKarol = 54321;

const numeroFernanda = 12;
const numeroVitorugo = 21;

var totalVotos = 0;

var votosBranco = 0;
var votosNulo = 0;

var votosKarol = 0;
var votosNaara = 0;

var votosFernanda = 0;
var votosVitorugo = 0;

function votacaoVereador() {
    css.href = "CSS/resultadoEleicoes.CSS";
    cargoText.innerText = "Vereador";

    clicaBotoesVereador();
    clicaNumerosVereador();
}

function clicaBotoesVereador() {
    brancoButton.onclick = votoBrancoVereador;
    corrigeButton.onclick = corrigirNumeroVereador;
    confirmaButton.onclick = confirmaVotoVereador;
}

function clicaNumerosVereador() {
    umButton.onclick = () => preencheNumeroVereador(1);
    doisButton.onclick = () => preencheNumeroVereador(2);
    tresButton.onclick = () => preencheNumeroVereador(3);
    quatroButton.onclick = () => preencheNumeroVereador(4);
    cincoButton.onclick = () => preencheNumeroVereador(5);
    seisButton.onclick = () => preencheNumeroVereador(6);
    seteButton.onclick = () => preencheNumeroVereador(7);
    oitoButton.onclick = () => preencheNumeroVereador(8);
    noveButton.onclick = () => preencheNumeroVereador(9);
    zeroButton.onclick = () => preencheNumeroVereador(0);
}

function votoNuloVereador() {
    totalVotos++;
    votosNulo++;

    css.href = "CSS/mensagemCentral.CSS";
    cargoText.innerText = "Voto Nulo";

    setTimeout(votacaoPrefeito, 2000);
}

function votoBrancoVereador() {
    totalVotos++;
    votosBranco++;

    css.href = "CSS/mensagemCentral.CSS";
    cargoText.innerText = "Voto Branco";

    setTimeout(votacaoPrefeito, 2000);
}

function corrigirNumeroVereador() {
    numero1Text.innerText = "";
    numero2Text.innerText = "";
    numero3Text.innerText = "";
    numero4Text.innerText = "";
    numero5Text.innerText = "";

    nomeText.innerText = "";
    partidoText.innerText = "";
    fotoCandidato.src = "";
}

function confirmaVotoVereador() {
    if (numero1Text.innerText.trim().length === 0 ||
        numero2Text.innerText.trim().length === 0 ||
        numero3Text.innerText.trim().length === 0 ||
        numero4Text.innerText.trim().length === 0 ||
        numero5Text.innerText.trim().length === 0) {
        votoNuloVereador();
        return;
    }

    let voto = "".concat(
        [numero1Text.innerText,
        numero2Text.innerText,
        numero3Text.innerText,
        numero4Text.innerText,
        numero5Text.innerText]
    ).replaceAll(",", "");

    if (voto != numeroKarol && voto != numeroNaara) {
        votoNuloVereador();
        return;
    }

    if (voto == numeroKarol) {
        totalVotos++;
        votosKarol++;

        css.href = "CSS/mensagemCentral.CSS";
        cargoText.innerText = "Voto Contabilizado";

        setTimeout(votacaoPrefeito, 2000);
        return;
    }

    if (voto == numeroNaara) {
        totalVotos++;
        votosNaara++;

        css.href = "CSS/mensagemCentral.CSS";
        cargoText.innerText = "Voto Contabilizado";

        setTimeout(votacaoPrefeito, 2000);
        return;
    }
}

function preencheNumeroVereador(numero) {
    if (numero1Text.innerText.trim().length === 0) numero1Text.innerText = numero;
    else
        if (numero2Text.innerText.trim().length === 0) numero2Text.innerText = numero;
        else
            if (numero3Text.innerText.trim().length === 0) numero3Text.innerText = numero;
            else
                if (numero4Text.innerText.trim().length === 0) numero4Text.innerText = numero;
                else
                    if (numero5Text.innerText.trim().length === 0) numero5Text.innerText = numero;

    let voto = "".concat(
        [numero1Text.innerText,
        numero2Text.innerText,
        numero3Text.innerText,
        numero4Text.innerText,
        numero5Text.innerText]
    ).replaceAll(",", "");

    if (voto == numeroKarol) {
        nomeText.innerText = "Karol";
        partidoText.innerText = "Cadeira 5";
        fotoCandidato.src = "SRC/karol.png";
    }

    if (voto == numeroNaara) {
        nomeText.innerText = "Naara";
        partidoText.innerText = "Cadeira 2";
        fotoCandidato.src = "SRC/naara.png";
    }
}

// Parte do Prefeitoooo

function votacaoPrefeito() {
    css.href = "CSS/prefeito.CSS";
    cargoText.innerText = "Prefeito";

    corrigirNumeroPrefeito();

    clicaBotoesPrefeito();
    clicaNumerosPrefeito();
}

function clicaBotoesPrefeito() {
    brancoButton.onclick = votoBrancoPrefeito;
    corrigeButton.onclick = corrigirNumeroPrefeito;
    confirmaButton.onclick = confirmaVotoPrefeito;
}

function clicaNumerosPrefeito() {
    umButton.onclick = () => preencheNumeroPrefeito(1);
    doisButton.onclick = () => preencheNumeroPrefeito(2);
    tresButton.onclick = () => preencheNumeroPrefeito(3);
    quatroButton.onclick = () => preencheNumeroPrefeito(4);
    cincoButton.onclick = () => preencheNumeroPrefeito(5);
    seisButton.onclick = () => preencheNumeroPrefeito(6);
    seteButton.onclick = () => preencheNumeroPrefeito(7);
    oitoButton.onclick = () => preencheNumeroPrefeito(8);
    noveButton.onclick = () => preencheNumeroPrefeito(9);
    zeroButton.onclick = () => preencheNumeroPrefeito(0);
}

function votoBrancoPrefeito() {
    totalVotos++;
    votosBranco++;

    css.href = "CSS/mensagemCentral.CSS";
    cargoText.innerText = "Voto Branco";

    setTimeout(fimVotacao, 2000);
}

function votoNuloPrefeito() {
    totalVotos++;
    votosNulo++;

    css.href = "CSS/votoNulo.CSS";
    cargoText.innerText = "Voto Nulo";

    setTimeout(fimVotacao, 2000);
}

function corrigirNumeroPrefeito() {
    numero1Text.innerText = "";
    numero2Text.innerText = "";

    nomeText.innerText = "";
    partidoText.innerText = "";
    fotoCandidato.src = "";
}

function confirmaVotoPrefeito() {
    if (numero1Text.innerText.trim().length === 0 ||
        numero2Text.innerText.trim().length === 0) {
        votoNuloPrefeito();
        return;
    }

    let voto = "".concat([numero1Text.innerText, numero2Text.innerText]).replaceAll(",", "");

    if (voto != numeroFernanda && voto != numeroVitorugo) {
        votoNuloPrefeito();
        return;
    }

    if (voto == numeroFernanda) {
        totalVotos++;
        votosFernanda++;

        css.href = "CSS/mensagemCentral.CSS";
        cargoText.innerText = "Voto Contabilizado";

        setTimeout(fimVotacao, 2000);
        return;
    }

    if (voto == numeroVitorugo) {
        totalVotos++;
        votosVitorugo++;

        css.href = "CSS/mensagemCentral.CSS";
        cargoText.innerText = "Voto Contabilizado";

        setTimeout(fimVotacao, 2000);
        return;
    }
}

function preencheNumeroPrefeito(numero) {
    if (numero1Text.innerText.trim().length === 0) numero1Text.innerText = numero;
    else
        if (numero2Text.innerText.trim().length === 0) numero2Text.innerText = numero;

    let voto = "".concat([numero1Text.innerText, numero2Text.innerText]).replaceAll(",", "");

    if (voto == numeroFernanda) {
        nomeText.innerText = "Fernandinha Beira-Mar";
        partidoText.innerText = "Cadeira 1";
        fotoCandidato.src = "SRC/fernanda.png";
    }

    if (voto == numeroVitorugo) {
        nomeText.innerText = "Vitorugo";
        partidoText.innerText = "Foragido";
        fotoCandidato.src = "SRC/vitorugo.png";
    }
}

// Parte do Fim da Votação

function fimVotacao() {
    css.href = "CSS/fimVotacao.CSS";
    cargoText.innerText = "FIM";

    proximoVotoButton.onclick = votacaoVereador;
    finalizarVotacaoButton.onclick = resultadoEleicoes;
}

function resultadoEleicoes() {
    contabilizarVotos();

    
}

function contabilizarVotos() {
    let votosValidosVereador = votosNaara + votosKarol;
    let votosValidosPrefeito = votosFernanda + votosVitorugo;

    let porcentagemNaara = 0;
    let porcentagemKarol = 0;

    let porcentagemFernanda = 0;
    let porcentagemVitorugo = 0;

    if (votosValidosVereador > 0) {
        porcentagemNaara = (votosNaara / votosValidosVereador) * 100;
        porcentagemKarol = (votosKarol / votosValidosVereador) * 100;
    } 
    
    if (votosValidosPrefeito > 0) {
        porcentagemFernanda = (votosFernanda / votosValidosPrefeito) * 100;
        porcentagemVitorugo = (votosVitorugo / votosValidosPrefeito) * 100;
    } 
}



