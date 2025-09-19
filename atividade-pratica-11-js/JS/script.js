function calcular() {
    let valor1 = parseInt(document.getElementById("valor1").value);
    let valor2 = parseInt(document.getElementById("valor2").value);

    let operacaoSelect = document.getElementById("operacao");
    let operacao = operacaoSelect.options[operacaoSelect.selectedIndex].text;

    let resultado = document.getElementById("resultado");

    if (!Number.isInteger(valor1) || !Number.isInteger(valor2)) {
        resultado.innerText = "Digite um número válido";
        return;
    }

    switch (operacao) {
        case "+":
            resultado.innerText = (valor1 + valor2);
            break;

        case "-":
            resultado.innerText = (valor1 - valor2);
            break;

        case "*":
            resultado.innerText = (valor1 * valor2);
            break;

        case "/":
            if (valor1 == 0 || valor2 == 0) {
                resultado.innerText = "Não é possível dividir por 0";
                return;
            }

            resultado.innerText = (valor1 / valor2);
            break;

        default:
            resultado.innerText = "Operação Inválida";
    }
}