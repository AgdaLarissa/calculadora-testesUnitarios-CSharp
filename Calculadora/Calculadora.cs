using System;

namespace Calculadora
{
   public class Calculadora
    {
        public float Somar(float valor1, float valor2){
            return valor1 + valor2;
        }

        public float Subtrair(float valor1, float valor2){
            return valor1 - valor2;
        }

        public float Multiplicar(float valor1, float valor2){
            return valor1 * valor2;
        }

        public float Dividir(float valor1, float valor2){
            return valor1 / valor2;
        }

       public string GerarResultado (float valor1, float valor2, float resultado, string operacao){
            return $"O resultado de {valor1} {operacao} {valor2} é: {resultado}";
        } 

    }
}