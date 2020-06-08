using System;
using System.Collections.Generic;
using System.Text;

namespace Agroalimentaria
{
    class CongeladosAire : ProductosCongelados    
    {

        public string PorcentajeNitrogeno { get; set; }
        public string PorcentajeOxigeno { get; set; }
        public string PorcentajeDioxidoCarbono { get; set; }
        public string PorcentajeVapor { get; set; }


        public override string ToString()
        {
            return
                $"Producto congelado con aire"
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
                + $"Temperatura recomendada{TemperaturaRecomendada}"
                + System.Environment.NewLine
                + $"Porcentaje de nigrogeno: % {PorcentajeNitrogeno} "
                + System.Environment.NewLine
                + $"Porcentaje de Oxigeno: %{PorcentajeOxigeno} "
                + System.Environment.NewLine
                + $"Porcentaje de Dioxido de Carbono: % {PorcentajeDioxidoCarbono}"
                + System.Environment.NewLine
                + $"Porcentaje de vapor: % { PorcentajeVapor}"
                + System.Environment.NewLine ;

        }   

    }
}