using System;

namespace _Deber1Clases
{
    partial class Program
    {
        private const string Value = "A continuacion se presentan diferentes caracteristicas en base a series, videojuegos, tira comidas etc.";

        static void Main(string[] args)
        {
            var avengers = new LosAvengers();
            var doreamon = new Doraemon();
            var increibles = new LosIncreibles();
            var twd = new TheWalkingDead();
            var marioWorld = new MarioWorld();
            while (true)
            {
                Console.WriteLine("Bienvenido a continuacion te presentamos nuestras opciones: \n 1.avengers \n 2.increibles \n 3.MarioWorld \n 4.The Walkind Dead \n 5. Doraemon ");
                var opcion = Console.ReadLine();
                int opcion1 = int.Parse(opcion);
                if (opcion1 == 1)
                Console.WriteLine(Value);
                {

                    avengers.mostrarPersonajesPrincipales();

                    avengers.mostrarPersonajesSecundarios();

                    avengers.mostrarCreador();

                    avengers.mostrarFechaPublicacion();

                    avengers.mostrarCapitulos();

                }
                if (opcion1 == 2)
                {
                    increibles.mostrarPersonajesPrincipales();

                    increibles.mostrarPersonajesSecundarios();

                    increibles.mostrarTipoDeSerie();

                    increibles.mostrarFechaPublicacion();

                    increibles.mostrarCreador();

                }
                if (opcion1 == 3)
                {
                    marioWorld.mostrarPersonajesPrincipales();

                    marioWorld.mostrarCreador();

                    marioWorld.mostrarEnemigo();

                    marioWorld.mostrarMundoWorld();

                    marioWorld.mostrarTipoDeVideoJuego();


                }

                if (opcion1 == 4)
                {
                    twd.mostrarPersonajesPrincipales();

                    twd.mostrarPersonajesSecundarios();

                    twd.mostrarCreador();

                    twd.mostrarFechaPublicacion();

                    twd.mostrarCapitulos();;

                }

                if (opcion1 == 5)
                {
                   doreamon.mostrarCreador();

                   doreamon.mostrarFechaPublicacion();

                   doreamon.mostrarTipoDeAnime();

                   doreamon.mostrarPersonajesSecundarios();

                   doreamon.mostrarPersonajesPrincipales();

                }
                
            }
        }
    }
}

