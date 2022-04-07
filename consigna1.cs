// El usuario ingresa un número por Consola. Determinar si es positivo o negativo e indicarlo en un mensaje por pantalla.\
using System;

class Program {
    public static void Main(string[] args){
        Console.WriteLine("ingresar su numero porfavor");
        double numero = Convert.ToDouble(Console.ReadLine());
        if(numero < 0){
            Console.WriteLine("Numero negativo :(");
        } else{
            Console.WriteLine("Numero positivo :)");
        }
    }
}