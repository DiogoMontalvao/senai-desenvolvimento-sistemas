function atualizarHorario() {
    let date = new Date();

    let horas = date.getHours();
    let minutos = date.getMinutes();
    let segundos = date.getSeconds();

    let horasText = document.getElementById("horasText");
    horasText.innerText = horas.toString().padStart(2, "0");

    let minutosText = document.getElementById("minutosText");
    minutosText.innerText = minutos.toString().padStart(2, "0");

    let segundosText = document.getElementById("segundosText");
    segundosText.innerText = segundos.toString().padStart(2, "0");   
}

