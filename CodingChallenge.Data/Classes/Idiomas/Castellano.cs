using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : ReporteIdioma
    {
        public override string FiguraCirculo(int cantidad)
        {
            return cantidad == 1 ? "Círculo" : "Círculos";
        }

        public override string FiguraCuadrado(int cantidad)
        {
            return cantidad == 1 ? "Cuadrado" : "Cuadrados";
        }

        public override string FiguraRectangulo(int cantidad)
        {
            return cantidad == 1 ? "Rectangulo" : "Rectangulos";
        }

        public override string FiguraTrapecio(int cantidad)
        {
            return cantidad == 1 ? "Trapecio" : "Trapecios";
        }

        public override string FiguraTrianguloEquilatero(int cantidad)
        {
            return cantidad == 1 ? "Triángulo" : "Triángulos";
        }

        public override string Footer(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            return "TOTAL:<br/>" + cantidadTotal + " formas Perimetro "+perimetroTotal.ToString("#.##") + " Area "+areaTotal.ToString("#.##");
        }

        public override string ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro,FormaGeometrica forma)
        {
            return $"{cantidad} {forma.ObtenerFigura(this,cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }

        public override string Titulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }
    }
}
