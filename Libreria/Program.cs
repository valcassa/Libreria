using System;
using System.Collections.Generic;

namespace Libreria
{
    class Program
    {

        static void Main(string[] args)
        {

         ListaLibriCarta lcr = new ListaLibriCarta();
         ListaLibriAudio lar = new ListaLibriAudio();
         ListaLibri lr = new ListaLibri();

        

            Console.WriteLine("*** Programma eseguito ***");
            Console.WriteLine("Scegli tra le seguenti opzioni:");
            Console.WriteLine("1- Visualizza tutti i Libri");
            Console.WriteLine("2- Visualizza tutti gli AudioLibri");
            Console.WriteLine("3- Visualizza tutti i Libri");
            Console.WriteLine("4- Aggiungi un AudioLibro");
            Console.WriteLine("5- Modifica Quantita Libro in Magazzino");
            Console.WriteLine("6- Trova AudioLibri per Durata");

            while (true)
            {
                int scelta;
                Console.WriteLine("Cosa scegli?");

                while (int.TryParse(Console.ReadLine(), out scelta)) ;



                switch (scelta)
                {
                    case 1:
                        List<LibriCarta> libriCartacei = lcr.Fetch();

                        break;
                    case 2:
                        List<AudioLibri> libriAudio = lar.Fetch();
                        break;
                    case 3:

                        List<ListaLibri> libri = lr.Fetch();
                        break;
                    case 4:
                     ListaLibriCarta.AddNew();   
                        break;

                    case 5:
                        ListaLibriCarta.ModificaQuantita();
                        break;

                    case 6:
                      ListaLibriAudio.AddNewAudio();
                        break;

                    case 7:


                    case 8:
// data un prezzo visualizzare i libri cartacei con prezzo > del prezzo inserito



                        break;
                    default:
                        Console.WriteLine("Inserisci scelta valida");
                        break;
                    case 0:
                        break;
                }

                LibriCarta libricarta = new LibriCarta(13.4, 150, "Come le Cicale", "Fiore Manni", 20);
                AudioLibri libriaudio = new AudioLibri(10.3, "I promessi sposi", "Alessandro Manzoni", 03.02);

            }
        }
    }
}
