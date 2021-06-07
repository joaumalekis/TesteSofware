using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringTolls_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("João", "Alex");

            // Assert 
            Assert.Equal("João Alex", nomeCompleto);
        }

        [Fact]
        public void StringTolls_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("João", "Alex");

            // Assert 
            Assert.Equal("JOÃO ALEX", nomeCompleto, true);
        }

        [Fact]
        public void StringTolls_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("João", "Alex");

            // Assert 
            Assert.Contains("Alex", nomeCompleto);
        }

        [Fact]
        public void StringTolls_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("João", "Alex");

            // Assert 
            Assert.StartsWith("Joã", nomeCompleto);
        }

        [Fact]
        public void StringTolls_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("João", "Alex");

            // Assert 
            Assert.EndsWith("lex", nomeCompleto);
        }

        [Fact]
        public void StringTolls_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Joao", "Alex");

            // Assert 
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]", nomeCompleto);
        }
    }
}