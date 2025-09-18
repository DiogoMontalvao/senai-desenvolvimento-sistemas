var valor = parseInt(prompt("Número maior, menor ou igual a 10"));

if (valor > 10)
    document.writeln("<h1>Maior que 10</h1>");

if (valor == 10)
    document.writeln("<h1>Igual a 10</h1>");

if (valor < 10)
    document.writeln("<h1>Menor que 10</h1>");


var numero1 = parseInt(prompt("Primeiro número para soma"));
var numero2 = parseInt(prompt("Segundo número para soma"));

document.writeln(`<h1>Soma: ${(numero1 + numero2)}</h1>`);

var numero01 = parseInt(prompt("Primeiro número"));
var numero02 = parseInt(prompt("Segundo número"));
var operacao = prompt("Operação a ser realizada (+, -, * ou /)");

switch (operacao) {
    case "+":
        document.writeln(`<h1>Soma: ${(numero01 + numero02)}</h1>`);
        break;

    case "-":
        document.writeln(`<h1>Subtração: ${(numero01 - numero02)}</h1>`);
        break;

    case "*":
        document.writeln(`<h1>Multiplicação: ${(numero01 * numero02)}</h1>`);
        break;

    case "/":
        document.writeln(`<h1>Divisão: ${(numero01 / numero02)}</h1>`);
        break;

    default:
        document.writeln("<h1>Operação inválida.</h1>");
}

var nome = prompt("Nome");
var repeticoes = parseInt(prompt("Repetições"));

for (var i = 0; i < repeticoes; i++) {
    document.writeln(`<h1>${nome}</h1>`);
}



