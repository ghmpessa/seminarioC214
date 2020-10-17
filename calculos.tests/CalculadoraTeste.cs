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
       
        [Fact]
        public void TesteCirculo()
        {
            var resultado = calc.circulo(10);
            Assert.Equal(314.159, resultado, 3);
        }

        [Fact]    
        public void testeQuadrado(){
            var resultado = calc.quadrado(10);
            Assert.Equal(100, resultado, 3);
        }

        [Fact]
        public void testeCubo(){
            var resultado = calc.cubo(10);
            Assert.Equal(600, resultado, 3);
        }

        [Fact]
        public void testeTriangulo(){
            var resultado = calc.triangulo(10, 20);
            Assert.Equal(100, resultado, 3);
        }

        [Fact]
        public void testeTrapezio(){
            var resultado = calc.trapezio(20, 10, 8);
            Assert.Equal(120, resultado, 3);
        }

        [Theory]
        [InlineData(10, 20)]
        [InlineData(20, 10)]
        public void testeRetangulo(int num1, int num2){
            var resultado = calc.retangulo(num1, num2);
            Assert.Equal(200, resultado);
        }
    }
}
