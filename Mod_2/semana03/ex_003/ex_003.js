function calcularIMC(peso, altura){
    var imc = peso / (altura * altura)
    imc = imc.toFixed(2);
    return imc
}

console.log("O seu IMC é: " + calcularIMC(80, 1.80) + " kg/m2.")


