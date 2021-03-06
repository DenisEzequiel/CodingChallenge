using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public override string ObtenerFigura(ReporteIdioma idioma, int cantidad)
        {
            return idioma.FiguraCirculo(cantidad);
        }
    }
}
