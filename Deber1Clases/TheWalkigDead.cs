using System;
namespace _Deber1Clases
{
    partial class Program
    {
        class TheWalkingDead
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
            public DateTime fechaDeEmisión;
            public void mostrarPersonajesPrincipales()
            {
                Console.Write("los personajes principales son: Rick, Carol, Michonne, Maggy, Carl, Daryl  \n");

            }
            public void mostrarPersonajesSecundarios()
            {
                Console.Write("los personajes secundarios son:Hersheel, Sofia, Shein, Perro, Lucille \n");
            }
            public void mostrarTipoDeSerie()
            {
                Console.Write("Sere de ciencia ficcion, basada en el apocalisis \n");
            }
            public void mostrarDuracionCapitulos()
            {
                Console.Write("Duracion por capitulo alrededor de los 45 min a 60 min \n");

            }
            public void mostrarCapitulos()
            {
                Console.Write("Cuenta con aproximadamente 10 capitulos por temporada \n");

            }
            public void mostrarCreador()
            {
                Console.Write("Frank Darabont es un director de cine, productor y guionista estadounidense de origen húngaro. \n");

            }
            public void mostrarFechaPublicacion()
            {
                Console.Write("Fue publicado en EE.UU en el año 2010 \n");
            }


        }




    }
}