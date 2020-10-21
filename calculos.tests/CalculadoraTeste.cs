using System;
using Xunit;

namespace calculos.tests
{
    public class CalculadoraTeste
    {
        Calculadora calc;

        public CalculadoraTeste(){
            calc = new Calculadora();
        }
       
        [Fact(DisplayName = "Teste 1")]
        [Trait("Calculo", "Área Círculo")]
        public void TesteCirculo()
        {
            var resultado = calc.areaCirculo(10);
            Assert.Equal(314.159, resultado, 3);
        }

        [Fact(DisplayName = "Teste 2")]
        [Trait("Calculo", "Área Quadrado")]    
        public void testeQuadrado(){
            var resultado = calc.areaQuadrado(10);
            Assert.Equal(100, resultado, 3);
        }

        [Fact(DisplayName = "Teste 3")]
        [Trait("Calculo", "Área Cubo")]
        public void testeCubo(){
            var resultado = calc.areaCubo(10);
            Assert.Equal(600, resultado, 3);
        }

        [Fact(DisplayName = "Teste 4")]
        [Trait("Calculo", "Área Triangulo")]
        public void testeTriangulo(){
            var resultado = calc.areaTriangulo(10, 20);
            Assert.Equal(100, resultado, 3);
        }

        [Fact(DisplayName = "Teste 5")]
        [Trait("Calculo", "Área Trapézio")]
        public void testeTrapezio(){
            var resultado = calc.areaTrapezio(20, 10, 8);
            Assert.Equal(120, resultado, 3);
        }

        [Theory]
        [InlineData(10, 20)]
        [InlineData(20, 10)]
        public void testeRetangulo(int num1, int num2){
            var resultado = calc.areaRetangulo(num1, num2);
            Assert.Equal(200, resultado);
        }

        [Fact(Skip = "Método ainda não implementado")]
        public void testeEsfera(){
            Assert.True(false);
        }
    }
}
