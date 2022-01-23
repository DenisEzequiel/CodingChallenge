using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReporteFormaGeometrica
    {
        public static string Imprimir(List<FormaGeometrica> formas, ReporteIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                 sb.Append(idioma.ListaVacia());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.Titulo());

                var types = formas.GroupBy(x => x.GetType()).Select(g => new { Type = g.Key, Count = g.Count() }).ToList();

                decimal totalArea = 0;
                decimal totalPerimetro = 0;
                foreach (var result in types)
                {
                    decimal areaDelTipo = formas.Where(x =>x.GetType() == result.Type).Sum(x => x.CalcularArea());  
                    decimal perimetroDelTipo = formas.Where(x => x.GetType() == result.Type).Sum(x => x.CalcularPerimetro());
                    int cantidadDelTipo = formas.Where(x => x.GetType() == result.Type).Count();
                    sb.Append(ObtenerLinea(cantidadDelTipo, areaDelTipo, perimetroDelTipo, idioma, formas.Where(x => x.GetType() == result.Type).First()));
                    totalArea += areaDelTipo;
                    totalPerimetro += perimetroDelTipo;
                }

                // FOOTER                   
                sb.Append(idioma.Footer(formas.Count,totalArea,totalPerimetro));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, ReporteIdioma idioma,FormaGeometrica forma)
        {
            if (cantidad > 0)
            {
                return idioma.ObtenerLinea(cantidad, area, perimetro, forma);
            }
            return string.Empty;
        }
    }
}
