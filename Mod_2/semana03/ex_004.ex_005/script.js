function calcularIMC(){

    var peso = document.getElementById("peso").value
    var altura = document.getElementById("altura").value
    var imc = peso / (altura * altura)
    imc = imc.toFixed(2);

    var classificacao = ""
    if (imc < 18.5) {
        classificacao = "Você está abaixo do peso"
    }
    else if (imc >= 18.5 && imc <= 24.9){
        classificacao = "Você está com peso normal"
    }
    else if (imc >= 25 && imc <= 29.9){
        classificacao = "Você está com sobrepeso"
    }
    else if (imc >= 30 && imc <= 34.9){
        classificacao = "Você está com obesidade grau 1"
    }
    else if (imc >= 25 && imc <= 39.9){
        classificacao = "Você está com obesidade grau 2"
    }
    else {
        classificacao = "Você está com obesidade grau 3"
    }

    var resultado = document.getElementById("resultado")
    resultado.removeAttribute("hidden")

    var imcResultado = document.getElementById("imcResultado")
    imcResultado.innerHTML = "IMC = " + imc 

    var classResultado = document.getElementById("classResultado")
    classResultado.innerHTML = classificacao
}
