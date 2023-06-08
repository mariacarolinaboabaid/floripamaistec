let botaoCadastrar = document.getElementById("cadastrarConta")

let usuarios = []

const verificaStorage = sessionStorage.getItem("usuarios");

if (verificaStorage !== null) {
    const usersExistentes = JSON.parse(verificaStorage);
    usuarios = usersExistentes;
}

botaoCadastrar.onclick = function () {

    let dadosUsuario = {}

    let user = document.getElementById("user")
    let senha = document.getElementById("password")
    let confirmacaoSenha = document.getElementById("confirmPassword")

    let validacaoUsuario = false
    let validacaoSenha = false

    if (user.value.length <= 0) {
        alert("Insira um usuário válido!")
    }
    else {
        validacaoUsuario = true
    }

    if (senha.value.length < 10) {
        alert("A senha deve conter pelo menos 10 caracteres!")
        senha.value = ""
    }
    else if (senha.value !== confirmacaoSenha.value) {
        alert("A confirmação da senha está incompatível com a senha.")
        confirmacaoSenha.value = ""
    }
    else {
        validacaoSenha = true
    }

    if (validacaoUsuario === true && validacaoSenha === true) {

        dadosUsuario.usuario = user.value
        dadosUsuario.senha = senha.value

        usuarios.push(dadosUsuario);
        const usuariosString = JSON.stringify(usuarios);
        sessionStorage.setItem("usuarios", usuariosString);

        window.location.href = "main.html"
    }

}
