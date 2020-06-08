using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    class CongeladosAgua : ProductosCongelados
    { 

        public string SalinidadAgua { get; set; }


        public override string ToString()
        {
            return
               $"Producto congelado con agua"
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
               + $"Temperatura recomendada: {TemperaturaRecomendada}"
               + System.Environment.NewLine
               + $"Salinidad del agua: {SalinidadAgua}"
               + System.Environment.NewLine;

        }

    }
}