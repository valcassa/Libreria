using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class ListaLibri : IDBRepository<ListaLibri> {

        static List<ListaLibri> libri = new List<ListaLibri>();
        ListaLibriCarta lcr = new ListaLibriCarta();
        ListaLibriAudio lar = new ListaLibriAudio();
        ListaLibri lr = new ListaLibri();



        public List<ListaLibri> Fetch()
        {
            Dictionary<double, string> libricarta = new Dictionary<double, string>();

            Dictionary<double, string> libriaudio = new Dictionary<double, string>();

            libricarta.Add(12.00, "Promessi sposi");
            libricarta.Add(14.00, "Divina Commedia");
            libricarta.Add(6.50, "Decameron");
            libriaudio.Add(13.00, "Promessi sposi");
            libriaudio.Add(22.00, "Divina Commedia");
            libriaudio.Add(11.50, "Decameron");

            return null;
         
 }


    }
}
 

