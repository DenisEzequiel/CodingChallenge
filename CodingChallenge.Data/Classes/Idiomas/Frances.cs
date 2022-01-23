using CodingChallenge.Data.Classes.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Frances : ReporteIdioma
    {
        public override string FiguraCirculo(int cantidad)
        {
            return cantidad == 1 ? "Cercle" : "Cercles";
        }

        public override string FiguraCuadrado(int cantidad)
        {
            return cantidad == 1 ? "Carré" : "Carrés";
        }

        public override string FiguraRectangulo(int cantidad)
        {
            return cantidad == 1 ? "Rectangle" : "Rectangles";
        }

        public override string FiguraTrapecio(int cantidad)
        {
            return cantidad == 1 ? "Trapèze" : "Trapèzes";
        }

        public override string FiguraTrianguloEquilatero(int cantidad)
        {
            return cantidad == 1 ? "Triangle" : "Triangles";
        }

        public override string Footer(int cantidadTotal, decimal areaTotal, decimal perimetroTotal)
        {
            return "TOTAL:<br/>" + cantidadTotal + " formes Périmètre " + perimetroTotal.ToString("#.##") + " Zone " + areaTotal.ToString("#.##");
        }

        public override string ListaVacia()
        {
            return "<h1>Liste vide de formes!</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica forma)
        {
            return $"{cantidad} {forma.ObtenerFigura(this, cantidad)} | Zone {area:#.##} | Périmètre {perimetro:#.##} <br/>";
        }

        public override string Titulo()
        {
            return "<h1>Rapport de formes</h1>";
        }
    }
}
