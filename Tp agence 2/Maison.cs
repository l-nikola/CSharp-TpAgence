using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_agence_2
{
    class Maison : Bien
    {
        string _statut;
        double _prix;
        bool _jardin;

        public Maison(string reference, string adresse, int surface, int nombrePiece, string statut, double prix, bool jardin) 
        : base(reference, adresse, surface, nombrePiece)
        {
            _statut = statut;
            _prix = prix;
            _jardin = jardin;
        }

        public string Statut { get => _statut; set => _statut = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public bool Jardin { get => _jardin; set => _jardin = value; }
        public void affiche()
        {
            base.affiche();
            Console.WriteLine("Statut : " + _statut);
            Console.WriteLine("Prix : " + _prix);
            Console.WriteLine("Jardin : " + _jardin);
            Console.WriteLine("----------------------------------");
        }
    }
}
