// Rehaga el ejercicio n°4 de la guía n°1 para cumplir con lo siguiente: Si dicho promedio  calculado  es  mayor  o  igual  a  6,  mostrar  el  mensaje  “Usted aprobó la materia [x] con promedio [x]”. Si no es mayor a 6, mostrar el mensaje  “Usted desaprobó la materia [x] con promedio [x]”.
using System;

class Program {
    public static void Main(string[] args){
        Console.WriteLine("Nombre de su materia:");
        string materia = Console.ReadLine();
        Console.WriteLine("Primer nota de " + materia + ":");
        float nota = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Segunda nota de " + materia + ":");
        float nota1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("tercera nota de " + materia + ":");
        float nota2 = Convert.ToSingle(Console.ReadLine());
        float promedio = (nota1 + nota2 + nota) / 3;
        if(promedio >= 6){
            Console.WriteLine("Usted aprobo la materia " + materia + " con promedio: " + promedio);
        } else {
            Console.WriteLine("Usted desaprobo la materia " + materia + " con promedio: " + promedio);
        }
    }
}