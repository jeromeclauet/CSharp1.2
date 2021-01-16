using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez deux nombres !");

            int firstNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber;
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("J'ajoute 33 au premier nombre ");
            Console.WriteLine(firstNumber + 33);
            Console.WriteLine("J'ajoute 1 au deuxième nombre ");
            Console.WriteLine(++secondNumber);
            Console.WriteLine("Je divise le premier nombre par le deuxième ");
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
