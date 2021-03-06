/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class FormaGeometrica
    {

        protected readonly decimal _lado;

        protected FormaGeometrica(decimal lado)
        {
            _lado = lado;
        }

        protected FormaGeometrica()
        { }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        public abstract string ObtenerFigura(ReporteIdioma idioma,int cantidad);
    }
}
