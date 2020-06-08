using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    class CongeladosNitrogeno : ProductosCongelados
    {
        public string MetodoCongelacion { get; set; }
        public string TiempoExposicion { get; set; }


        public override string ToString()
        {
            return
                 $"Producto congelado con Nitrogeno"
                 + System.Environment.NewLine
                 + System.Environment.NewLine
                 + $"Numero de lote: {Numerolote}"
                 + System.Environment.NewLine
                 + $"Fecha de caducidad:{FechaDeCaducidad}"
                 + System.Environment.NewLine
                 + $"Fecha de envasado :{FechaDeEnvasado}"
                 + System.Environment.NewLine
                 + $"Pais: { Pais} "
                 + System.Environment.NewLine
                 + $"Metodo de congelación: {MetodoCongelacion}"
                 + System.Environment.NewLine
                 + $"Tiempo de exposición: {TiempoExposicion} "
                 + System.Environment.NewLine;
        }
    }
}