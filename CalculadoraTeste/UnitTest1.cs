using System;
using Xunit;

namespace CalculadoraTeste
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)] 
        [InlineData(2,2,4)] 
        public void TesteSoma(float valor1, float valor2, float resultadoEsperado)
        {
           var calculadora = new Calculadora.Calculadora();
           var resultado = calculadora.Somar(valor1,valor2);
           Assert.Equal(resultadoEsperado,resultado);
        }

        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(2,2,0)] 
        public void TesteSubtracao(float valor1, float valor2, float resultadoEsperado)
        {
           var calculadora = new Calculadora.Calculadora();
           var resultado = calculadora.Subtrair(valor1,valor2);
           Assert.Equal(resultadoEsperado,resultado);
        }

        [Theory]
        [InlineData(1,2,2)]
        [InlineData(2,2,4)] 
        public void TesteMultiplicacao(float valor1, float valor2, float resultadoEsperado)
        {
           var calculadora = new Calculadora.Calculadora();
           var resultado = calculadora.Multiplicar(valor1,valor2);
           Assert.Equal(resultadoEsperado,resultado);
        }

        [Theory]
        [InlineData(1,2,0.5)]
        [InlineData(2,2,1)] 
        public void TesteDivisao(float valor1, float valor2, float resultadoEsperado)
        {
           var calculadora = new Calculadora.Calculadora();
           var resultado = calculadora.Dividir(valor1,valor2);
           Assert.Equal(resultadoEsperado,resultado);
        }
    }
}
