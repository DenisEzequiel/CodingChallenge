using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : ReporteIdioma
    {
        public override string FiguraCirculo(int cantidad)
        {
            return cantidad == 1 ? "Circle" : "Circles";
        }

        public override string FiguraCuadrado(int cantidad)
        {
            return cantidad == 1 ? "Square" : "Squares";
        }

        public override string FiguraRectangulo(int cantidad)
        {
            return cantidad == 1 ? "Rectangle" : "Rectangles";
        }

        public override string FiguraTrapecio(int cantidad)
        {
            return cantidad == 1 ? "Trapeze" : "trapezoids";
        }

        public override string FiguraTrianguloEquilatero(int cantidad)
        {
            return cantidad == 1 ? "Triangle" : "Triangles";
        }

        public override string Footer(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            return "TOTAL:<br/>" + cantidadTotal + " shapes Perimeter " + perimetroTotal.ToString("#.##") + " Area " + areaTotal.ToString("#.##");
        }

        public override string ListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica forma)
        {
            return $"{cantidad} {forma.ObtenerFigura(this, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

        }

        public override string Titulo()
        {
            return "<h1>Shapes report</h1>";
        }
    }
}
