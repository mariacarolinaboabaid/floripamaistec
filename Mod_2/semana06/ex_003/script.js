export function gettingNames(url) {

    let container = document.createElement("div")
    container.id = "container"

    fetch(url)
        .then(response => {
            return response.json()
        })
        .then(result => {
            for (let iterador = result.length - 1; iterador >= 0; iterador--) {

                let pessoa = document.createElement("div")
                pessoa.classList.add("containerPessoa")

                for (let item in result[iterador]) {

                    let dados = document.createElement("p")
                    dados.innerText += `${item}: ${result[iterador][item]}`

                    pessoa.append(dados)

                }
                container.append(pessoa)
            }
        })

    return container
}