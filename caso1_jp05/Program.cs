using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso1_jp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir los datos de la tabla en un arreglo
            int[] demandaEsperada = { 900, 700, 800, 1200, 1500, 1100 };
            int MayorDemanda = demandaEsperada[0];
            int MenorDemanda = demandaEsperada[0];
            int[] DiasProduccion = { 22, 18, 21, 21, 22, 20 };

            // Nombres de los meses
            string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };

            // Declarar un arreglo para almacenar los porcentajes
            double[] porcentajes = new double[demandaEsperada.Length];
            // Declarar un arreglo para almacenar el total de demanda por día
            double[] totalDemandaPorDia = new double[demandaEsperada.Length];

            // Calcular el total de demanda esperada
            int totalDemanda = 0;
            for (int i = 0; i < demandaEsperada.Length; i++)
            {
                totalDemanda += demandaEsperada[i];
            }
            // Calcular el total de días de producción de los 6 meses
            int TotalDiasProduccion = 0;
            for (int i = 0; i < DiasProduccion.Length; i++)
            {
                TotalDiasProduccion += DiasProduccion[i];
            }
            // Calcular el promedio de demanda esperada
            double promedioDemanda = (double)totalDemanda / demandaEsperada.Length;

            // Encontrar el mayor y el menor valor de demanda
            for (int i = 1; i < demandaEsperada.Length; i++)
            {
                if (demandaEsperada[i] > MayorDemanda)
                {
                    MayorDemanda = demandaEsperada[i];
                }
                if (demandaEsperada[i] < MenorDemanda)
                {
                    MenorDemanda = demandaEsperada[i];
                }
            }

            // Calcular los porcentajes de demanda esperada para cada mes
            for (int i = 0; i < demandaEsperada.Length; i++)
            {
                porcentajes[i] = Math.Round(((double)demandaEsperada[i] / totalDemanda) * 100, 2);
            }
            // Calcular el total de demanda esperada por día
            for (int i = 0; i < demandaEsperada.Length; i++)
            {
                totalDemandaPorDia[i] = (double)demandaEsperada[i] / DiasProduccion[i];
            }

            // Calcular el total de la demanda esperada por día para todos los meses
            double totalDemandaTotal = totalDemandaPorDia.Sum();

            // Mostrar el total, promedio, mayor y menor de demanda esperada
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Total de demanda esperada de los 6 meses: " + totalDemanda);
            Console.WriteLine("Promedio de demanda esperada de los 6 meses: " + promedioDemanda);
            Console.WriteLine("Mayor demanda: " + MayorDemanda);
            Console.WriteLine("Menor demanda: " + MenorDemanda);
            Console.WriteLine("------------------------");
            Console.WriteLine("Porcentaje de demanda esperada por mes:");

            // Mostrar los porcentajes y la demanda por día con nombres de meses
            for (int i = 0; i < demandaEsperada.Length; i++)
            {
                double demandaPorDia = Math.Round((double)demandaEsperada[i] / DiasProduccion[i]);
                Console.WriteLine($"{nombresMeses[i]}: {porcentajes[i]}%, Demanda por día: {demandaPorDia}");
            }
            Console.WriteLine("------------------------");
            // Mostrar total de los días de producción
            Console.WriteLine("Total de los días de producción de los 6 meses: " + TotalDiasProduccion);
            // Mostrar el total de la demanda por día para todos los meses
            Console.WriteLine("Total de la demanda por día para todos los meses: " + totalDemandaTotal);

            Console.ReadKey();
        }
    }
}
