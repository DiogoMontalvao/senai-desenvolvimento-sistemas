const cep = document.getElementById("cep");
const erroCepText = document.getElementById("erroCepText");

const rua = document.getElementById("rua");
const bairro = document.getElementById("bairro");
const cidade = document.getElementById("cidade");
const estado = document.getElementById("estado");

const corretoCepText = document.getElementById("corretoCepText");

function validar() {
    if (cep.value.length != 8) {
        limparCampos();

        erroCepText.innerText = "Digite um CEP válido.";

        return;
    }

    const ajax = new XMLHttpRequest();

    ajax.open("get", `https://viacep.com.br/ws/${cep.value}/json/`);
    ajax.send();

    ajax.onload = function () {
        let requisicao = JSON.parse(this.responseText);

        console.log(requisicao.erro);

        if (requisicao.erro == "true") {
            limparCampos();
            erroCepText.innerText = "CEP não encontrado.";
            return;
        }

        limparCampos();

        cep.value = requisicao.cep;
        rua.value = requisicao.logradouro;
        bairro.value = requisicao.bairro;
        cidade.value = requisicao.localidade;
        estado.value = requisicao.estado;

        corretoCepText.innerText = "Endereço cadastrado com sucesso!";
    };
}

function limparCampos() {
    cep.value = "";
    erroCepText.innerText = ""

    rua.value = "";
    bairro.value = "";
    cidade.value = "";
    estado.value = "";

    corretoCepText.innerText = "";
}