using ex_001;

Cliente cliente = new Cliente("Fernando da Silva", DateTime.Parse("1980-10-20"), "Dentista", "casado", TipoPessoa.FISICA);


Console.WriteLine($"Nome: {cliente.Nome} \n" +
    $"Data de nascimento: {cliente.Nascimento} \n" +
    $"Profissão: {cliente.Profissao} \n" +
    $"Estado civil: {cliente.EstadoCivil} \n" +
    $"Tipo de pessoa: {cliente.tipoPessoa}") ;
