using Xunit;

namespace Features.Tests
{
    [TestCaseOrderer("Features.Tests.PriorityOrderer", "Features.Tests")]
    public class OrdemTestes
    {
        private static bool _teste1Chamado;
        private static bool _teste2Chamado;
        private static bool _teste3Chamado;
        private static bool _teste4Chamado;

        [Fact(DisplayName = "Teste 04"), TestPriority(3)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste04()
        {
            _teste4Chamado = true;

            Assert.True(_teste3Chamado);
            Assert.True(_teste1Chamado);
            Assert.False(_teste2Chamado);
        }

        [Fact(DisplayName = "Teste 01"), TestPriority(2)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste01()
        {
            _teste1Chamado = true;

            Assert.True(_teste3Chamado);
            Assert.False(_teste4Chamado);
            Assert.False(_teste2Chamado);
        }

        [Fact(DisplayName = "Teste 03"), TestPriority(1)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste03()
        {
            _teste3Chamado = true;

            Assert.False(_teste1Chamado);
            Assert.False(_teste2Chamado);
            Assert.False(_teste4Chamado);
        }

        [Fact(DisplayName = "Teste 02"), TestPriority(4)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste02()
        {
            _teste2Chamado = true;

            Assert.True(_teste3Chamado);
            Assert.True(_teste4Chamado);
            Assert.True(_teste1Chamado);
        }
    }
}