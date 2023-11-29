using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_agence_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Appartement> ListeAppart = new List<Appartement>();
            List<Maison> ListeMaison= new List<Maison>();
            Agences agence1 = new Agences();
            Appartement appart1 = new Appartement("1a", "Rouen, 76000", 100, 5, "L", 450, true);
            Appartement appart2 = new Appartement("2b", "Rouen, 76000", 95, 4, "AL", 350, false);
            Maison mais1 = new Maison("1b", "Yville sur Seine, 76530", 550, 9, "AV", 150000, true);
            Maison mais2 = new Maison("2a", "Cean 14118", 350, 7, "V", 180000, false);

            agence1.ajoute(mais1);
            agence1.ajoute(mais2);
            agence1.ajoute(appart1);
            agence1.ajoute(appart2);
            agence1.afficheTouslesBiens();
            Console.ReadLine();
        }
    }
}
