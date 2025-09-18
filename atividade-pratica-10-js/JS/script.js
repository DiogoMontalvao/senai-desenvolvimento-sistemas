function questao01() {
    let nome = prompt("Digite o nome do aluno");

    let nota1 = Number(prompt("Digite a primeira nota"));
    let nota2 = Number(prompt("Digite a segunda nota"));
    let nota3 = Number(prompt("Digite a terceira nota"));
    let media = (nota1 + nota2 + nota3) / 3;

    let situacao;

    if (media >= 7) situacao = situacao = "Aprovado";
    if (media >= 5 && media < 7) situacao = "Recuperação";
    if (media < 5) situacao = situacao = "Reprovado";

    let questao01Text = document.getElementById("questao01Text");
    questao01Text.style.display = "block";
    questao01Text.innerText =
        `Aluno: ${nome}
        Média: ${media.toFixed(1)}
        Situação: ${situacao}`;
}

function questao02() {
    let grausCelsius = Number(prompt("Digite a temperatura em graus Celsius"));

    let grausFahrenheit = (grausCelsius * 1.8) + 32;

    let questao02Text = document.getElementById("questao02Text");
    questao02Text.style.display = "block";
    questao02Text.innerText = `Fahrenheit: ${grausFahrenheit.toFixed(1)} °F`;
}

function questao03() {
    let numero = Number(prompt("Digite um número"));

    let parOuImpar;

    if (numero % 2 == 0) parOuImpar = "Par";
    if (numero % 2 != 0) parOuImpar = "Ímpar";

    let questao03Text = document.getElementById("questao03Text");
    questao03Text.style.display = "block";
    questao03Text.innerText = parOuImpar;
}

// function questao04() {
//     let numeroAleatorio = Math.random() * 10 + 1;
//     console.log(numeroAleatorio);

//     let numero = Number(prompt("Adivinhe o número"));
//     console.log(numero);

//     let tentativas = 1;
//     while (numero != numeroAleatorio) {
//         tentativas++;

//         if (numero > numeroAleatorio) Number(prompt("O número é menor"));
//         if (numero < numeroAleatorio) Number(prompt("O número é maior"));
//     }

//     let questao04Text = document.getElementById("questao04Text");
//     questao04Text.style.display = "block";
//     questao04Text.innerText = 
//         `Acertou o número: ${numeroAleatorio}
//         Tentativas: ${tentativas}
//         `;
// }

