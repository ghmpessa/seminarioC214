using System;

namespace calculos
{
    public class Calculadora
    {
        public double areaCirculo(double raio) => Math.PI * Math.Pow(raio, 2);
        public double areaQuadrado(double lado) => Math.Pow(lado, 2);
        public double areaCubo(double lado) => areaQuadrado(lado) * 6;
        public double areaTriangulo(double baze, double altura) => (baze*altura)/2;
        public double areaTrapezio(double baseMaior, double baseMenor, double altura) => 
        ((baseMaior + baseMenor)*altura)/2;
        public double areaRetangulo(double lado1, double lado2) => lado1 * lado2;

    }
}
