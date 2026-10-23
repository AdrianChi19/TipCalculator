using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Maui.Models
{
    public class ConsumoCompartido
    {

        //Propuedades necesarias para realizar los calculos
        public decimal ImporteDelConsumo { get; set; }
        public int NumeroDePersonas { get; set; }
        public decimal PorcentajeDePropina { get; set; }

        //Propiedades que guardan los calculos resultantes
        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m;

        public decimal ImporteDeLaPropinaPorPersona => ImporteDeLaPropina / NumeroDePersonas;

        public decimal ImporteTotalConPropina => ImporteDelConsumo + ImporteDeLaPropina;

        public decimal ImporteTotalConPropinaPorPersona => ImporteTotalConPropina / NumeroDePersonas;




        public ConsumoCompartido(decimal importeDelConsumo, int numeroDePersona, decimal porcentajeDePropina)
        {
            ImporteDelConsumo = importeDelConsumo;
            NumeroDePersonas = numeroDePersona;
            PorcentajeDePropina = porcentajeDePropina;
        }
    }
}
