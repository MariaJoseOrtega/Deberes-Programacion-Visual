using System;
namespace _Deber1Clases
{
    partial class Program
    {
        class MarioWorld
        {
            public string personajesPrincipales;
            public string personajesSecundarios;
            public string tipoDeVideoJuego;
            public string premios;
            public string enemigos;
            public string mundoWorld;
            public int numeroVideojuegos;
            public string creador;
            public DateTime fechaDeEmisión;
            public void mostrarPersonajesPrincipales()
            {
                Console.Write("los personajes principales son: Mario, Luigi, Browser, Princesa Peach  \n");

            }
            public void mostrarPersonajesSecundarios()
            {
                Console.Write("los personajes principales son: Princesa Rosalina, Toad, Huesitos \n");
            }
            public void mostrarTipoDeVideoJuego()
            {
                Console.Write("Es un videojuego de plataforma o consola virtual   \n");
            }
            public void mostrarPremio()
            {
                Console.Write("Los premios que se obtienen al culminar el mundo es alargar el nivel de vida, puntuacion como jugador \n");

            }
            public void mostrarEnemigo()
            {
                Console.Write("Los enemigos son: Browser, Turtles Fly, Dunki Kong \n");

            }
            public void mostrarMundoWorld()
            {
                Console.Write("El videojuego consta de varios mundos, entre ellos el de carreras y suprvivencia \n");

            }
            public void mostrarCreador()
            {
                Console.Write(" Fujio Fujiko fue el seudónimo de un dúo de mangakas japoneses compuesto por Hiroshi Fujimoto y Motoo Abiko \n");

            }
            public void mostrarFechaPublicacion()
            {
                Console.Write("Fue publicado en el año 1992 como juego de consola \n");
            }


        }




    }
}