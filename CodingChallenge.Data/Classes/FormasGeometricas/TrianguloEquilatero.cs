using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string ObtenerFigura(ReporteIdioma idioma, int cantidad)
        {
            return idioma.FiguraTrianguloEquilatero(cantidad);
        }
    }
}
