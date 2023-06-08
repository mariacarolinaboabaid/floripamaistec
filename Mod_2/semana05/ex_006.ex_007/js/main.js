const botaoEntrar = document.getElementById("login")

let usuarios = sessionStorage.getItem("usuarios")
let usuariosCadastrados = JSON.parse(usuarios);


botaoEntrar.onclick = function () {

    let user = document.getElementById("user")
    let senha = document.getElementById("password")

    let validacaoUser = false
    let validacaoSenha = false

    // Loop lista usuários 
    for (let item in usuariosCadastrados) 
    {
        // Loop objeto usuário
        for (let key in usuariosCadastrados[item]) {

            // Validando senha e usuário
            if (key === "usuario" && user.value === usuariosCadastrados[item][key]) 
            {
                validacaoUser = true
            }
            if (key === "senha" && senha.value === usuariosCadastrados[item][key]) 
            {
                validacaoSenha = true
            }
        }
        // Senha e usuários válidos
        if (validacaoUser === true && validacaoSenha === true)
        {
            window.location.href = "home.html"
        }
        // Usuário válido, mas senha errada
        else if (validacaoUser === true && validacaoSenha === false)
        {
            return alert("A senha inserida está errada.")
        }

    }
    // Usuário inválido
    if (validacaoUser === false){
        alert("Usuário inexistente")
    }



}