using System;
namespace _Deber1Clases
{
    partial class Program
    {
        class LosAvengers
        {
            public string personajesPrincipales;
            public string personajesSecundarios;
            public string tipoDeSerie;
            public string duracionCapitulos;
            public string tiraComica;
            public string tipoSerie;
            public int traducciones;
            public int capitulos;
            public string creador;
            public DateTime fechaDePublicacion;

            public void mostrarPersonajesPrincipales()
            {
                Console.Write("los personajes principales son: Thor, Thanos, SpiderMan, IronMan, Capitan America \n");

            }
            public void mostrarPersonajesSecundarios()
            {
                Console.Write("los personajes secundarios son: DeadPool, Nova, Wakanda, Loki \n");
            }
            public void mostrarTipoDeSerie()
            {
                Console.Write("Es una serie de ciencia ficcion  \n");
            }
            public void mostrarDuracionCapitulos()
            {
                Console.Write("Por lo general cada capitulo esta alrededor de los 45 minutos \n");

            }
            public void mostrarTipoSerie()
            {
                Console.Write(" Es una serie apta para todo publico \n");

            }
            public void mostrarCapitulos()
            {
                Console.Write("Cuenta con aproximadamente 1000 capitulos inlcuidas sus peliculas  \n");

            }
            public void mostrarCreador()
            {
                Console.Write(" Marvel Comics \n");

            }
            public void mostrarFechaPublicacion()
            {
                Console.Write("El 2 de julio de 1963 pasaría a la historia como la fecha en la que el mundo conoció a los héroes más poderosos de la Tierra. \n");
            }


        }




    }
}