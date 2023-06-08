import { dados } from "./dados.js";

// Carregamento das informações das cards
const container = document.getElementById("containerCards")

function carregarCards() {

    for (let dado in dados) {
        let card = document.createElement("div")
        card.classList.add("card")

        for (let item in dados[dado]) {
            if (item === "titulo") {
                let title = document.createElement("h2")
                title.innerText = dados[dado][item]
                card.append(title)
            }
            else if (item === "imagem") {
                let imagem = document.createElement("img")
                imagem.src = dados[dado][item]
                card.append(imagem)
            }
            else {
                let subtitle = document.createElement("p")
                subtitle.innerText = dados[dado][item]
                card.append(subtitle)
            }
        }
        container.append(card)
    }
}

window.onload = carregarCards

// Função buscar
const btnBuscar = document.getElementById("btnSearch")

btnBuscar.onclick = function () {

    let cards = document.getElementsByClassName("card")
    console.log(cards)

    if (cards.length < 9){
        carregarCards()
    }
   
    let valorBuscar = document.getElementById("search").value.toUpperCase()

    let match = []

    if (valorBuscar === ""){
       return alert("Busca vazia!")
    }
    else {
        for (var i = cards.length - 1; i >= 0; i--) {
            console.log(i)
            let card = cards[i]
    
            let titulo = card.firstElementChild.innerText.toUpperCase()
    
            let subtitulo = card.lastElementChild.innerText.toUpperCase()
    
            if (titulo.includes(valorBuscar) === true || subtitulo.includes(valorBuscar) === true) {
                match.push(card)
            }
            card.remove()
        }

        for (let item in match) {
            container.append(match[item])
        }
    }
}
