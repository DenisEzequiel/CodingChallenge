using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo : FormaGeometrica
    {
        decimal _base;
        decimal _altura;
        public Rectangulo(decimal _base,decimal _altura) 
        {
            this._base = _base;
            this._altura = _altura;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _base * 2 + _altura * 2;
        }

        public override string ObtenerFigura(ReporteIdioma idioma, int cantidad)
        {
            return idioma.FiguraRectangulo(cantidad);
        }
    }
}
