using System;

namespace IMC {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a altura"+ peso);
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso da pessoa: " + peso);
            Console.WriteLine($"Altura da pessoa: {altura}");

            float result = peso / altura * altura;

            if (result < 18) {
                Console.WriteLine("Magrinho");
            }
            else if (result > 18 && result < 25) {
                Console.WriteLine("Normal");
            } 

        }
    }
}
