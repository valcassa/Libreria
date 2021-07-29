using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class AudioLibri 
    {
        public double Prezzo { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public static double Durata { get; set; }


        public AudioLibri(double p, string tit, string aut, double dur)
        {
            Prezzo = p;
            Titolo = tit;
            Autore = aut;
            Durata = dur;

        }
         
    }
    
}