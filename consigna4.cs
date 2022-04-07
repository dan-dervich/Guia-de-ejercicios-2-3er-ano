using System;
// el usuario ingresa los 3 lados de un triangulo. Determinar si es equilatero, isoceles o escaleno.

class Program {
    public static void Main(string[] args){
        Console.WriteLine("Ingresar el primer lado del triangulo");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresar el segundo lado del triangulo");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresar el tercer lado del triangulo");
        double num3 = Convert.ToDouble(Console.ReadLine());
        // EQUILÁTERO. Sus tres lados miden lo mismo. 
        // ISÓSCELES. Dos lados miden lo mismo y el otro mide distinto.
        // El triángulo escaleno es aquella figura geométrica de tres lados, cada uno de los cuales mide una longitud distinta.
        if(num1 == num2 && num2 == num3){
            Console.WriteLine("Los tres lados son iguales asi que es equilatero");
        } else if(num1 == num2 || num1 == num3 || num2 == num3) {
            Console.WriteLine("Hay dos lados que son iguales asi que es un triangulo Isosceles");
        } else{
            Console.WriteLine("no hay ningun lado igual asi que es un triangulo escaleno");
        }
    }
}