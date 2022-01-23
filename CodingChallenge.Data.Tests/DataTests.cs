using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.Classes.Idiomas;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3),
            };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }
         
        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenRectanguloEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(5,2)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectangulo | Area 10 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 10",
                resumen);
        }

        [TestCase]
        public void TestResumenRectangulosEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(5,2),
                new Rectangulo(1,3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Rectangulos | Area 13 | Perimetro 22 <br/>TOTAL:<br/>2 formas Perimetro 22 Area 13",
                resumen);
        }


        [TestCase]
        public void TestResumenRectanguloEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(5,2)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Rectangle | Area 10 | Perimeter 14 <br/>TOTAL:<br/>1 shapes Perimeter 14 Area 10",
                resumen);
        }

        [TestCase]
        public void TestResumenRectangulosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(5,2),
                new Rectangulo(1,3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Rectangles | Area 13 | Perimeter 22 <br/>TOTAL:<br/>2 shapes Perimeter 22 Area 13",
                resumen);
        }


        [TestCase]
        public void TestResumenTrapecioEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(3,5,2,3,4)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 16 | Perimetro 13 <br/>TOTAL:<br/>1 formas Perimetro 13 Area 16",
                resumen);
        }

        [TestCase]
        public void TestResumenTrapeciosEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(3,5,2,3,4),
                new Trapecio(1,2,4,2,3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Trapecios | Area 20,5 | Perimetro 22 <br/>TOTAL:<br/>2 formas Perimetro 22 Area 20,5",
                resumen);
        }


        [TestCase]
        public void TestResumenTrapecioEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                 new Trapecio(3,5,2,3,4)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Trapeze | Area 16 | Perimeter 13 <br/>TOTAL:<br/>1 shapes Perimeter 13 Area 16",
                resumen);
        }

        [TestCase]
        public void TestResumenTrapeciosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(3,5,2,3,4),
                new Trapecio(1,2,4,2,3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 trapezoids | Area 20,5 | Perimeter 22 <br/>TOTAL:<br/>2 shapes Perimeter 22 Area 20,5",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, new Frances());

            Assert.AreEqual(
                "<h1>Rapport de formes</h1>2 Carrés | Zone 29 | Périmètre 28 <br/>2 Cercles | Zone 13,01 | Périmètre 18,06 <br/>3 Triangles | Zone 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes Périmètre 97,66 Zone 91,65",
                resumen);
        }

    }
}
