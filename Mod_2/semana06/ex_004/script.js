export function gettingNames(url) {

    let listaNomes = document.createElement("ul")

    fetch(url)
        .then(response => {
            return response.json()
        })
        .then(result => {
            // Array de nomes
            let nomes = []
            let nomesComA;

            // Adicionando os nomes na array
            result.forEach(pessoa => {
                for (let item in pessoa) {
                    if (item === "nome") {
                        nomes.push(pessoa[item])
                    }
                }
            })

            // Filtrando os nomes com "A"
            nomesComA = nomes.filter(nome => {
                return nome.includes("A") === true;
            })

            nomesComA.forEach(nome =>{
                let itemLista = document.createElement("li")
                itemLista.innerText = nome
                listaNomes.append(itemLista)
            })

            
        })
        return listaNomes
}