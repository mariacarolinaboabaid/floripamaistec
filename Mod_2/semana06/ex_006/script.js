export function gettingNames(url) {

    let listaNomes = document.createElement("ul")

    fetch(url)
        .then(response => {
            return response.json()
        })
        .then(result => {
            // Array de nomes
            let nomes = []
            let nomesPequenos;

            // Adicionando os nomes na array
            result.forEach(pessoa => {
                for (let item in pessoa) {
                    if (item === "nome") {
                        nomes.push(pessoa[item])
                    }
                }
            })

            // Filtrando os nomes com "A"
            nomesPequenos = nomes.filter(nome => {
                return nome.length < 6;
            })

            nomesPequenos.forEach(nome =>{
                let itemLista = document.createElement("li")
                itemLista.innerText = nome
                listaNomes.append(itemLista)
            })

            
        })
        return listaNomes
}