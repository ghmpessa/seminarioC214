using System;

namespace calculos
{
    public class Calculadora
    {
        public double circulo(double raio) => Math.PI * Math.Pow(raio, 2);
        public double quadrado(double lado) => Math.Pow(lado, 2);
        public double cubo(double lado) => quadrado(lado) * 6;
        public double triangulo(double baze, double altura) => (baze*altura)/2;
        public double trapezio(double baseMaior, double baseMenor, double altura) => ((baseMaior + baseMenor)*altura)/2;
        public double retangulo(double lado1, double lado2) => lado1 * lado2;

    }
}
