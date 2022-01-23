using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : FormaGeometrica
    {
        decimal _baseMenor;
        decimal _baseMayor;
        decimal _ladoA;
        decimal _LadoB;
        decimal _altura;
        public Trapecio(decimal _baseMenor,decimal _baseMayor, decimal _ladoA, decimal _LadoB, decimal _altura)
        {
            this._baseMenor = _baseMenor;
            this._baseMayor = _baseMayor;
            this._ladoA = _ladoA;
            this._LadoB = _LadoB;
            this._altura = _altura;
        }
        public override decimal CalcularArea()
        {
            return _altura * ((_baseMenor + _baseMayor) / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMenor + _baseMayor + _ladoA + _LadoB;
        }

        public override string ObtenerFigura(ReporteIdioma idioma, int cantidad)
        {
            return idioma.FiguraTrapecio(cantidad);
        }
    }
}
