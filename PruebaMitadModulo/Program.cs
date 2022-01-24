using System;
using System.Collections.Generic;
using Modelo.Peliculas;
using ModeloDB;
namespace PruebaMitadModulo
{
    public class Program
    {
        static void Main(string[] args)
        {
           //CREAR PELICULA
            film Matrix = new film {
            title = "Matrix",
            description = "Accion",
            relase_year = 2022,
            rental_duration =  "1 semana",
            length = 2,
            replacement_cost =  15 ,
            last_update = DateTime.Now,
            special_fectures = "none",
            fulltext =  "yes"

            };

            //CREAR PELICULA
            film Rocky = new film
            {
                title = "Rocky 3",
                description = "Accion",
                relase_year = 1989,
                rental_duration = "2 semana",
                length = 2,
                replacement_cost = 15,
                last_update = DateTime.Now,
                special_fectures = "none",
                fulltext = "yes"
            };
            //CREAR PELICULA
            film Credd = new film
            {
                title = "Creed",
                description = "Accion",
                relase_year = 2019,
                rental_duration = "3 semana",
                length = 1,
                replacement_cost = 15,
                last_update = DateTime.Now,
                special_fectures = "none",
                fulltext = "yes"
            };
            //CREAR PELICULA
            film Rocky1 = new film
            {
                title = "Rocky 1",
                description = "Accion",
                relase_year = 1980,
                rental_duration = "4 semana",
                length = 1,
                replacement_cost = 15,
                last_update = DateTime.Now,
                special_fectures = "none",
                fulltext = "yes"
            };
            film Rocky2 = new film
            {
                title = "Rocky 2",
                description = "Accion",
                relase_year = 1982,
                rental_duration = "5 semana",
                length = 1,
                replacement_cost = 15,
                last_update = DateTime.Now,
                special_fectures = "none",
                fulltext = "yes"
            };
            film Rocky4 = new film
            {
                title = "Rocky 4",
                description = "Accion",
                relase_year = 1989,
                rental_duration = "2 semana",
                length = 1,
                replacement_cost = 15,
                last_update = DateTime.Now,
                special_fectures = "none",
                fulltext = "yes"
            };
            //lista peliculas
            List<film> Lstfilm = new List<film> { Rocky, Credd, Matrix };
            //crear lenguaje
            language español = new language
            {
                name = "Español",
                last_update = DateTime.Now,
                films = new List<film>() { Rocky , Rocky1 ,Rocky2 , Rocky4 , Matrix , Credd}

            };
            language english = new language
            {
                name = "English",
                last_update = DateTime.Now,
                films = new List<film>() { Rocky, Rocky1, Rocky2, Rocky4, Matrix, Credd }

            };
            language french = new language
            {
                name = "French",
                last_update = DateTime.Now ,
                films = new List<film>() { Rocky, Rocky1, Rocky2, Rocky4, Matrix, Credd }

            };
            List<language> Lstlanguaje = new List<language> { english , español , french };
            //añadimos peliculas al inventario
            inventory iv1 = new inventory
            {
                id = 1,
                last_update = DateTime.Now,

            };




            //Insertamos los datos
            using (ModeloDB.Class1 contex = new ModeloDB.Class1())
            {
                contex.films.AddRange(Lstfilm);
                contex.languages.AddRange(Lstlanguaje);

                contex.SaveChanges();
            }
        }

    }
}
