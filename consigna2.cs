// Dados dos números ingresados por el usuario, dar la relación entre ellos. Mostrar por Consola “El número más grande es:” y el número correspondiente; “El número más chico es:” y el número correspondiente. En caso de ser iguales, mostrar un mensaje indicando eso mismo.
using System;

class Program {
    public static void Main(string[] args){
        Console.WriteLine("Ingresar su primer numero:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresar su segundo numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        if(num1 == num2){
            Console.WriteLine("Los dos numeros son iguales: " + num1 + " " + num2);
        } else if(num1 < num2){
            Console.WriteLine("El numero mas grande es: " + num2);
            Console.WriteLine("El numero mas chico es: " + num1);
        } else{
            Console.WriteLine("El numero mas grande es: " + num1);
            Console.WriteLine("El numero mas chico es: " + num2);
        }
    }
}