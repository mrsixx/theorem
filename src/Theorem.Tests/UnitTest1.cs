using System;
using Xunit;

namespace Theorem.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Class1_Soma_DeveRetornarOValorCorreto()
        {
            var theorem = new Class1();
            var resultado = theorem.Resolve("1+1");

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Class1_Multiplicacao_DeveRetornarOValorCorreto()
        {
            var theorem = new Class1();
            var resultado = theorem.Resolve("5*3");

            Assert.Equal(15, resultado);
        }
    }
}
