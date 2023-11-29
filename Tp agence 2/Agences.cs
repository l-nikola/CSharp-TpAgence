using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_agence_2
{
    class Agences
    {
        public List<Bien> _lesBiens = new List<Bien>();
        public Agences()
        {
            _lesBiens = new List<Bien>();
        }
        public void ajoute(Bien b)
        {
            _lesBiens.Add(b);
        }
        public void afficheTouslesBiens()
        {
            foreach (Bien unBien in _lesBiens)
            {
                unBien.affiche();
            }
        }
    }
}
