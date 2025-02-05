var puntaje = 0;
let correctas = ["c01", "c02", "c03", "c04", "c05", "c06", "c07", "c08", "c09", "c10"];
var contador;

function iniciarContador() {
    var duracion = 10 * 60 * 1000;
    contador = setTimeout(finalizarContador, duracion);
    actualizarContador(duracion / 1000);
}

function actualizarContador(segundosRestantes) {
    var display = document.querySelector('#timer');
    var intervalId = setInterval(function () {
        var minutes = Math.floor(segundosRestantes / 60);
        var seconds = segundosRestantes % 60;

        minutes = minutes < 10 ? '0' + minutes : minutes;
        seconds = seconds < 10 ? '0' + seconds : seconds;

        display.textContent = 'Tiempo restante : ' + minutes + ':' + seconds;

        if (segundosRestantes > 0) {
            segundosRestantes--;
        } else {
            clearInterval(intervalId);
            alert('Tu puntaje final es: ' + (puntaje/10)*100 + '%');
            puntaje = 0;
            window.location.href = "../vista/login.html";
        }
    }, 1000);
}

function finalizarContador() {
    alert("El tiempo ha terminado. El cuestionario se enviará automáticamente.");
    document.querySelector("form").submit();
}

window.onload = function () {
    iniciarContador();
};


document.getElementById('loginForm').addEventListener('submit', function(event) { 
    event.preventDefault(); 

    const username = document.getElementById('username').value; 
    const password = document.getElementById('password').value; 
    const errorMessage = document.getElementById('errorMessage'); 

     
    const validUsername = 'usuario';
    const validPassword = 'contraseña'; 

    if (username === validUsername && password === validPassword) { 
        alert('Inicio de sesión exitoso!'); 
        window.location.assign("../vista/cuestionarios.html")
    } else { 
        errorMessage.textContent = 'Nombre de usuario o contraseña incorrectos.';
    }
});

function responder(pregunta, elemento) {
    var respuesta = elemento.id;
    
    var score = document.querySelector('#score');    
    var opciones = elemento.parentNode.children;
    
    for (var i = 0; i < opciones.length; i++) {
      opciones[i].classList.remove('selected');
      opciones[i].classList.add('deshabilitada');
    }
    elemento.classList.add('selected');

    if(respuesta == correctas[pregunta-1]){
        elemento.classList.add('correcta');
        puntaje++; 
        score.textContent = 'Tu puntaje actual es: ' + puntaje;
    } else{
        elemento.classList.add('incorrecta');   
    }
}

function finalizar(){
    alert('Tu puntaje final es: ' + (puntaje/10)*100 + '%');
    puntaje = 0;
    window.location.href = "../vista/login.html";
}