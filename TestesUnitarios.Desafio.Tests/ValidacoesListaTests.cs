using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests{

    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista(){

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista(){

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista(){

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        // Será "Falso" pois não há o número 10 na lista
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] {10, 14, 16, 18})] // criação de array para conter valores da lista multiplicados por 2
    public void DeveMultiplicarOsElementosDaListaPor2(int[] valores){

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var numeroParaMultiplicar = 2;
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, numeroParaMultiplicar);

        // Assert
        Assert.Equal(valores, resultado); // comparando a array criada no "InlineData" com o resultado (lista * 2)
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista(){

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(){

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}
