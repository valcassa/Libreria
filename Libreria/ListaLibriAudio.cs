using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria
{

    class ListaLibriAudio : IDBRepository<AudioLibri>
    {
        static List<AudioLibri> libriaudio = new List<AudioLibri>();

        public List<AudioLibri> Fetch()
        {


            libriaudio.Add(new AudioLibri(20.00, "Herman Hesse", "Siddharta", 02.10));
            libriaudio.Add(new AudioLibri(10.00, "George Orwell", "1984", 03.34));
            libriaudio.Add(new AudioLibri(13.00, "Jane Austen", "Orgoglio e Pregiudizio", 02.58));


            return libriaudio;

        }

        public static AudioLibri AddNewAudio()
        {


            Console.WriteLine("Inserisci Nuovo Titolo:");
            string NuovoAudioLibro = Console.ReadLine();
            bool ExistAudLibr = libriaudio.Any(al => al.Titolo == NuovoAudioLibro);
            if (ExistAudLibr)
            {
                Console.WriteLine("L'audiolibro esiste già");

            }
            Console.WriteLine("Inserisci l'Autore");
            string NuovoAutore = Console.ReadLine();
            bool ExistAutAudio;

            do
            {
                ExistAutAudio = libriaudio.Any(al => al.Autore == NuovoAutore);

            } while (!ExistAutAudio);

            Console.WriteLine("Inserisci prezzo");

            double prezzo;
            bool ifCorrect;

            do
            {
                ifCorrect = double.TryParse(Console.ReadLine(), out prezzo);
            }
            while (!ifCorrect);

            Console.WriteLine("Inserisci durata");

            double durata;
            bool ifDurata;

            do
            {
                ifDurata = double.TryParse(Console.ReadLine(), out durata);

            }
            while (!ifDurata);

            AudioLibri al = new AudioLibri(prezzo, NuovoAudioLibro, NuovoAutore, durata);

            return al;
        }

 
        public static AudioLibri FindAudio()
        {


            double FindAudioLibri;
            bool Find;
            double durata;

            Console.WriteLine("Inserisci la durata che desideri");
              Find = double.TryParse(Console.ReadLine(), out FindAudioLibri);

            //50.00 
            Find = (AudioLibri.Durata <= FindAudioLibri);

            AudioLibri dur = new AudioLibri.Durata(FindAudioLibri);

            return dur;
        }
    }
}