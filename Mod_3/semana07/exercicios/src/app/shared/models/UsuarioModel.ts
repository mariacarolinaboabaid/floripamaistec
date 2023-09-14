export interface UsuarioModelCreate {
    nomeCompleto: string,
    emailInformado: string, 
    dataDeNascimento: string
}

export interface UsuarioModelList {
    nome: string,
    email: string, 
    dataNascimento: string
}