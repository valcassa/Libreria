using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class ListaLibriCarta : IDBRepository<LibriCarta>
    {
        string NuovoLibroCartaceo { get; set; }

        static List<LibriCarta> libricarta = new List<LibriCarta>();
        public List<LibriCarta> Fetch()
        {
            libricarta.Add(new LibriCarta(20.00, 20, "Herman Hesse", "Siddharta", 10));
            libricarta.Add(new LibriCarta(10.00, 5, "Prova", "ProvaTitolo", 3));
            libricarta.Add(new LibriCarta(8.00, 200, "1984", "George Orwell", 10));

            return libricarta;
        }
        public static LibriCarta ModificaQuantita()
        {
            string Titolo = Console.ReadLine();

            Console.WriteLine("Inserisci il Titolo da Modificare:");
            string LibroRicerca = Console.ReadLine();

            bool ExistLibro = libricarta.Any(ac => ac.Titolo == LibroRicerca);

            if (ExistLibro)
            {
                Console.WriteLine("Il libro è già presente");
            }
            LibroRicerca = Console.ReadLine();


            Console.WriteLine("Inserisci nuove unità");
            string NuoveQta = Console.ReadLine();

            List<string> ListaLibri = new List<string>();
            ListaLibri.Add(NuoveQta);

            LibriCarta newc = new LibriCarta(LibroRicerca);

            return newc;


        }


        public static LibriCarta AddNew()
        {


            Console.WriteLine("Inserisci Nuovo Titolo:"); 

            string NuovoLibroCartaceo = Console.ReadLine();
            bool ExistLibrCart = libricarta.Any(lc => lc.Titolo == NuovoLibroCartaceo);
            if (ExistLibrCart)
            {
                Console.WriteLine("Il libro esiste già");

            }
            Console.WriteLine("Inserisci l'Autore");
            string NuovoAutore = Console.ReadLine();
            bool ExistAutCarta;

            do
            {
                ExistAutCarta = libricarta.Any(lc => lc.Autore == NuovoAutore);

            } while (!ExistAutCarta);

            Console.WriteLine("Inserisci prezzo");

            double prezzo;
            bool ifCorrect;

            do
            {
                ifCorrect = double.TryParse(Console.ReadLine(), out prezzo);
            }
            while (!ifCorrect);

            Console.WriteLine("Inserisci numero pagine");

            int npagine;

            int.TryParse(Console.ReadLine(), out npagine); 

            Console.WriteLine("Libro aggiunto!");

            LibriCarta newc = new LibriCarta(NuovoLibroCartaceo, NuovoAutore, prezzo, npagine);

            return newc;



        }
    }
}
