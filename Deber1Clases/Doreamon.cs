using System;
namespace _Deber1Clases
{
    partial class Program
    {
        class Doraemon
        {
            public string personajesPrincipales;
            public string personajesSecundarios;
            public string tipoDeAnime;
            public string duracionCapitulos;
            public string tiraComica;
            public string tipoSerie;
            public int traducciones;
            public int capitulos;
            public string creador;
            public DateTime fechaDeEmisión;
            public void mostrarPersonajesPrincipales()
            {
                Console.Write("los personajes principales son: Nobita, Doreamon,Zuneo,Takeshi,Shizuka \n");

            }
            public void mostrarPersonajesSecundarios()
            {
                Console.Write("los personajes principales son: Tamako, Nobisuke, Dorami, Jaiko, Hidetoshi \n");         
            }
            public void mostrarTipoDeAnime()
            {
                Console.Write("Doraemon es un manga escrito e ilustrado \n");
            }
            public void mostrarDuracionCapitulos()
            {
                Console.Write("Por lo general, según la serie y el año en el que se produjo, cada episodio de 30 minutos está compuesto por dos o tres segmentos y en cada uno se narra historias de corta duración \n");

            }
            public void mostrarTipoSerie()
            {
                Console.Write(" Es una serie apta para todo publico \n");

            }
            public void mostrarCapitulos()
            {
                Console.Write("Cuenta con aproximadamente +600 capitulos \n");

            }
            public void mostrarCreador()
            {
                Console.Write(" Fujio Fujiko fue el seudónimo de un dúo de mangakas japoneses compuesto por Hiroshi Fujimoto y Motoo Abiko \n");

            }
            public void mostrarFechaPublicacion()
            {
                Console.Write("Fue publicado en Japón desde diciembre de 1969 hasta abril de 1996 en diversas revistas de la editorial Shogakukan. \n");
            }

        }

    }
}