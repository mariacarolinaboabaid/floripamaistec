import { dados } from "./dados.js";

let container = document.getElementById("containerCards")

window.onload = function () {

    for (let dado in dados) {
        let card = document.createElement("div")
        card.classList.add("card")
        console.log(dados[dado])
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


