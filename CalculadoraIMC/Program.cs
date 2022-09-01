using System;
using CalculadoraIMC.Entities;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual seu peso? ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Qual sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            string retorno = "none";
            if (imc <= 18.4)
            {
                retorno = "Abaixo do peso";
            }
            if (18.5 <= imc && imc <= 24.9)
            {
                retorno = "Peso normal";
            }
            if (25 <= imc && imc <= 29.9)
            {
                retorno = "Sobrepeso";
            }
            if (30 <= imc && imc <= 34.9)
            {
                retorno = "Obesidade grau I";
            }
            if (35 <= imc && imc <= 39.9)
            {
                retorno = "Obesidade grau II";
            }
            if (imc >= 40)
            {
                retorno = "Obesidade grau III";
            }

            Console.WriteLine($"Seu IMC é de = {imc.ToString("F2")} Sua situação: {retorno}"); 
        }
    }
}
