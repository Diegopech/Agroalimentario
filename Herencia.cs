using System;

namespace Agroalimentaria
{
    class Herencia
    {
        static void Main(string[] args)
        {
            CongeladosAire p = new CongeladosAire();
            p.Numerolote = "066";
            p.FechaDeCaducidad = "05-08-2021";
            p.FechaDeEnvasado = "15-06-2020";
            p.Pais = "Mexico";
            p.TemperaturaRecomendada = "-5";
            p.PorcentajeNitrogeno = "15";
            p.PorcentajeOxigeno = "5";
            p.PorcentajeDioxidoCarbono = "27";
            p.PorcentajeVapor = "-2";

            Console.WriteLine(p);



            CongeladosAgua p2 = new CongeladosAgua();
            p2.Numerolote = "09";
            p2.FechaDeCaducidad = "12-10-2021";
            p2.FechaDeEnvasado = "01-04-2020";
            p2.Pais = "España";
            p2.TemperaturaRecomendada = "-2";
            p2.SalinidadAgua = "XY";
          
            Console.WriteLine(p2);


            CongeladosNitrogeno p3 = new CongeladosNitrogeno();
            p3.Numerolote = "716";
            p3.FechaDeCaducidad = "02-11-2024";
            p3.FechaDeEnvasado = "22-06-2020";
            p3.Pais = "Argentina";
            p3.TemperaturaRecomendada = "-35";
            p3.MetodoCongelacion = "Ultra";
            p3.TiempoExposicion = "8 hrs";

            Console.WriteLine(p3);


        }
    }
}