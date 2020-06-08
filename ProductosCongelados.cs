using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
   public class ProductosCongelados : Productos
    {

       
        public string FechaDeEnvasado { get; set; }
        public string Pais { get; set; }
        public string TemperaturaRecomendada { get; set; }

        public override string ToString()
        {
            return $"Numero de lote: {Numerolote}, Fecha de caducidad: {FechaDeCaducidad}, Fecha de envasado: { FechaDeEnvasado} "
                   + $", Pais: { Pais} Temperatura recomendada: {TemperaturaRecomendada}";

        }

    }

}