using System;

// Realizar  un  programa  que,  dado  un  año  ingresado  por  el  usuario,  diga  si  es bisiesto  o  no.   Nota :  Un  año  es  bisiesto  si  es  múltiplo  de  4  salvo  el  caso  en que  sea  múltiplo  de  100,  que  no  es  bisiesto,  y  no  sea  múltiplo  de  400.  Por ejemplo,  el   año   1900   no   fue   bisiesto,   el   2000   sí   y   el   2100   no

// mientras que el año sea divisible por 4 es un año bisiesto

class Program{
    public static void Main(string[] args){
        Console.WriteLine("Ingresar año para fijarse si es bisiesto:");
        float año = Convert.ToSingle(Console.ReadLine());
        // fijarse si el año es divisible por 100 y que no de un numero con decimal
            if((año % 100) == 0){
                // si es divisible por 100 nos fijamos si es divisible por 400.
                if((año % 400) == 0){
                    // año bisiesto
                    Console.WriteLine("Año bisiesto");
                } else{
                    Console.WriteLine("Año no es bisiesto");
                }
            } else{
                // en el caso de que el año no sea divisible por 100 lo dividimos por 4 como nos fijariamos un año bisiesto normal
                if(((año / 4) % 1) == 0){
                    Console.WriteLine("Año bisiesto");
            } else{
                    Console.WriteLine("Año no es bisiesto");
            }
        }
    }
}