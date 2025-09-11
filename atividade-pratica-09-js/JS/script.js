var valor = parseInt(window.prompt("Número maior, menor ou igual a 10"));

if (valor > 10)
    document.writeln("<h1>Maior que 10</h1>");

if (valor == 10)
    document.writeln("<h1>Igual a 10</h1>");

if (valor < 10)
    document.writeln("<h1>Menor que 10</h1>");


var numero1 = parseInt(window.prompt("Primeiro número para soma"));
var numero2 = parseInt(window.prompt("Segundo número para soma"));

document.writeln("<h1>Soma: " + (numero1 + numero2) + "</h1>");

var numero01 = parseInt(window.prompt("Primeiro número"));
var numero02 = parseInt(window.prompt("Segundo número"));
var operacao = window.prompt("Operação a ser realizada (+, -, * ou /)");

switch (operacao) {
    case "+":
        document.writeln("<h1>Soma: " + (numero01 + numero02) + "</h1>");
        break;

    case "-":
        document.writeln("<h1>Subtração: " + (numero01 - numero02) + "</h1>");
        break;

    case "*":
        document.writeln("<h1>Multiplicação: " + (numero01 * numero02) + "</h1>");
        break;

    case "/":
        document.writeln("<h1>Divisão: " + (numero01 / numero02) + "</h1>");
        break;

    default:
        document.writeln("Operação inválida.");
}

var nome = window.prompt("Nome");
var repeticoes = parseInt(window.prompt("Repetições"));

for (var i = 0; i < repeticoes; i++) {
    document.writeln("<h1>" + nome + "</h1>");
}



