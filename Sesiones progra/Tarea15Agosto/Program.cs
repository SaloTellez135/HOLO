using System;


namespace Tarea15Agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            //artistas
            Artista art1 = new Artista();
            art1.nombre = "DaftPunk";
            art1.nacionalidad = "Francia";
            art1.oyentes = 20518623;
            art1.albumes = 4;

            Artista art2 = new Artista();
            art2.nombre = "Parcels";
            art2.nacionalidad = "Australia";
            art2.oyentes = 3063512;
            art2.albumes = 4;

            Artista art3 = new Artista();
            art3.nombre = "Carly Rae Jepsen";
            art3.nacionalidad = "Canada";
            art3.oyentes = 18700000;
            art3.oyentes = 6;

            Artista art4 = new Artista();
            art4.nombre = "Kanye West";
            art4.nacionalidad = "USA";
            art4.oyentes = 56700000;
            art4.albumes = 12;

            Artista art5 = new Artista();
            art5.nombre = "Lil Yatchi";
            art5.nacionalidad = "USA";
            art5.oyentes = 12500000;
            art5.albumes = 10;

            //Albumes 
            Album Alb1 = new Album();
            Alb1.nombre = "Graduation";
            Alb1.Canciones = 14;
            Alb1.duracion = 54.29;
            Alb1.AnoLanz = 2007;

            Album Alb2 = new Album();
            Alb2.nombre = "Discovery";
            Alb2.Canciones = 14;
            Alb2.duracion = 1.01;
            Alb2.AnoLanz = 2001;

            Album Alb3 = new Album();
            Alb3.nombre = "Emotion";
            Alb3.Canciones = 15;
            Alb3.duracion = 54.10;
            Alb3.AnoLanz = 2015;

            Album Alb4 = new Album();
            Alb4.nombre = "Lets Start Here";
            Alb4.Canciones = 14;
            Alb4.duracion = 54.16;
            Alb4.AnoLanz = 2023;

            Album Alb5 = new Album();
            Alb5.nombre = "Parcels";
            Alb5.Canciones = 12;
            Alb5.duracion = 51.45;
            Alb5.AnoLanz = 2018;

            //Cancion
            Cancion Can1 = new Cancion();
            Can1.titulo = "Stronger";
            Can1.artista = "Kanye west";
            Can1.album = "Graduation";
            Can1.duracion = 5.11;

            Cancion Can2 = new Cancion();
            Can2.titulo = "Runaway with me";
            Can2.artista = "Carly Rae Jepsen";
            Can2.album = "Emotion";
            Can2.duracion = 4.11;

            Cancion Can3 = new Cancion();
            Can3.titulo = "Myenemy";
            Can3.artista = "Parcels";
            Can3.album = "Parcels";
            Can3.duracion = 3.29;

            Cancion Can4 = new Cancion();
            Can4.titulo = "Voyager";
            Can4.artista = "Daft Punk";
            Can4.duracion = 3.47;
            Can4.album = "Discovery";

            Cancion Can5 = new Cancion();
            Can5.titulo = "the ride-";
            Can5.artista = "Lil Yatchy";
            Can5.album = "Lets Start Here";
            Can5.duracion = 3.10;

        }
    }
}
