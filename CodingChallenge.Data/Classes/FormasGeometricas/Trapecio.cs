using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : FormaGeometrica
    {
        decimal _baseA;
        decimal _baseB;
        decimal _baseC;
        decimal _baseD;
        decimal _altura;
        public Trapecio(decimal _baseA,decimal _baseB, decimal _baseC, decimal _baseD, decimal _altura)
        {
            this._baseA = _baseA;
            this._baseB = _baseB;
            this._baseC = _baseC;
            this._baseD = _baseD;
            this._altura = _altura;
        }
        public override decimal CalcularArea()
        {
            return _altura * ((_baseB + _baseA) / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return _baseA + _baseB + _baseC + _baseD;
        }

        public override string ObtenerFigura(ReporteIdioma idioma, int cantidad)
        {
            return idioma.FiguraTrapecio(cantidad);
        }
    }
}
