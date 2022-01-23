using CodingChallenge.Data.Classes.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public abstract class ReporteIdioma
    {
        public abstract string Titulo();
        public abstract string ListaVacia();

        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica forma);

        public abstract string FiguraTrianguloEquilatero(int cantidad);
        public abstract string FiguraCuadrado(int cantidad);
        public abstract string FiguraCirculo(int cantidad);
        public abstract string FiguraRectangulo(int cantidad);
        public abstract string FiguraTrapecio(int cantidad);

        public abstract string Footer(int cantidadTotal,decimal areaTotal,decimal perimetroTotal);

    }
}
