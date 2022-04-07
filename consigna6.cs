using System;

// El  Gobierno  ha  decidido  establecer  impuestos  a  las  ganancias  en  forma             escalonada:  los  ciudadanos  con  ingresos  hasta  $10000  no  pagarán           impuestos;  aquellos  con  ingresos  entre  $10000  y  $30000,  deberán  pagar            10%  de  impuestos;  aquellos  cuyos  ingresos  sean  de  $30000  a  $50000            deberán  pagar  20%  de  impuestos,  y  los  que  tengan  ingresos  mayores  a              $50000   deberán   pagar   35%   de   impuestos.

class Program {
    public static void Main(string[] args){
        Console.WriteLine("Porfavor ingrese sus ingresos:");
        double ingresos = Convert.ToDouble(Console.ReadLine());
        if (ingresos < 10000){
            // no impuestos
            Console.WriteLine("Usted no tiene que pagar impuestos :)");
        } else if(ingresos < 30000) {
            // 10%
            double impuestos = ingresos * .1;
            double valorNeto = ingresos - impuestos;
            Console.WriteLine("Usted debe pagar: $" + impuestos + " de impuestos");
            Console.WriteLine("Su valor neto es: $" + valorNeto);
        } else if(ingresos < 50000){
            // 20%
            double impuestos = ingresos * .2;
            double valorNeto = ingresos - impuestos;
            Console.WriteLine("Usted debe pagar: $" + impuestos + " de impuestos");
            Console.WriteLine("Su valor neto es: $" + valorNeto);
        } else {
            // 35%
            double impuestos = ingresos * .35;
            double valorNeto = ingresos - impuestos;
            Console.WriteLine("Usted debe pagar: $" + impuestos + " de impuestos");
            Console.WriteLine("Su valor neto es: $" + valorNeto);
        }
    }
}