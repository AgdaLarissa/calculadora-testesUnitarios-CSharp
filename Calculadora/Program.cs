using System;

namespace Calculadora
{
    class Program
    {        
        static void Main(string[] args)
        {       
            var calculadora = new Calculadora(); 
            string operacao = "";    
            float valor1 = 0;
            float valor2 = 0;  
            string textoResultado = "";
            float resultado;     

            while(operacao != "E"){   

                Console.WriteLine(
                    @"Informe a operação que deseja realizar: 
                    - Digite + para somar;
                    - Digite - para subtrair; 
                    - Digite * para multiplicar; 
                    - Digite / para dividir; 
                    - Digite E para sair.");
                operacao = Console.ReadLine();

                if(operacao == "E"){
                    Console.WriteLine("Saindo...");
                    break;
                }

                Console.WriteLine("Informe os dois valores da operação:");
                valor1 = float.Parse(Console.ReadLine());
                valor2 = float.Parse(Console.ReadLine());              

                switch (operacao)
                {
                    case "+":                        
                        resultado = calculadora.Somar(valor1, valor2);                        
                        textoResultado = calculadora.GerarResultado(valor1,valor2,resultado,operacao);
                        break;
                    case "-":
                        resultado = calculadora.Subtrair(valor1, valor2);
                        textoResultado = calculadora.GerarResultado(valor1,valor2,resultado,operacao);
                        break;
                    case "*":
                        resultado = calculadora.Multiplicar(valor1, valor2);
                        textoResultado = calculadora.GerarResultado(valor1,valor2,resultado,operacao);
                        break;
                    case "/":
                        if(valor2 == 0){
                            textoResultado = "Erro: Não existe divisão por zero.";
                            break;
                        }
                        resultado = calculadora.Dividir(valor1, valor2);
                        textoResultado = calculadora.GerarResultado(valor1,valor2,resultado,operacao);
                        break;                
                    default:
                        textoResultado = "Erro: Operação inválida"; 
                        break;              
                }
                Console.WriteLine(textoResultado);
            }            
        }
    }
}
