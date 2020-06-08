using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    public class ProductosFrescos : Productos
    {
        public string FechaDeEnvasado { get; set; }
        public string Pais { get; set; }


        public override string ToString()
        {
            return $"Numero de lote: {Numerolote}, Fecha de caducidad{FechaDeCaducidad}, Fecha de envasado { FechaDeEnvasado} ,Pais: { Pais}";

        }
    }
}