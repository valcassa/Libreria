using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{

    class LibriCarta
    {

        public double Prezzo { get; set; }
        public int Quantita { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int NumeroPag { get; set; }



        public LibriCarta(double p, int qta, string tit, string aut, int npag)
        {

            Prezzo = p;
            Quantita = qta;
            Titolo = tit;
            Autore = aut;
            NumeroPag = npag;


        }

       
     
        
        }

    }
