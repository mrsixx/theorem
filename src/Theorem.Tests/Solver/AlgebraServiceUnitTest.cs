using Theorem.Solver.Interfaces;
using Theorem.Solver.Services;
using Xunit;

namespace Theorem.Tests.Solver
{
    public class AlgebraServiceUnitTest
    {
        private readonly IAlgebraService _algebraService;

        public AlgebraServiceUnitTest()
        {
            _algebraService = new AlgebraService();
        }

        [Theory]
        [Trait("Algebra", "Somar")]
        [InlineData(2.9, 3.1, 6)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Somar_DoisNumerosRelativos_DeveRetornarOValorCorreto(decimal num1, decimal num2, decimal valorEsperado)
        {
            // Act  
            var soma = _algebraService.Somar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, soma);
        }

        [Theory]
        [Trait("Algebra", "Multiplicar")]
        [InlineData(0.5, 0.5, 0.25)]
        [InlineData(4, -1, -4)]
        [InlineData(-2, 0, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Multiplicar_DoisNumerosRelativos_DeveRetornarOValorCorreto(decimal num1, decimal num2, decimal valorEsperado)
        {
            // Act  
            var multiplicacao = _algebraService.Multiplicar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, multiplicacao);
        }
    }
}
