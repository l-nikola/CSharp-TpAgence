using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_agence_2
{
    class Appartement : Bien
    {
        string _statut;
        double _loyer;
        bool _balcon;
        public Appartement(string reference, string adresse, int surface, int nombrePiece, string statut, double loyer, bool balcon)
            : base(reference, adresse, surface, nombrePiece)
        {
            _statut = statut;
            _loyer = loyer;
            _balcon = balcon;
        }
        public string Statut { get => _statut; set => _statut = value; }
        public double Loyer { get => _loyer; set => _loyer = value; }
        public bool Balcon { get => _balcon; set => _balcon = value; }
        public void affiche()
        {
            base.affiche();
            Console.WriteLine("Statut : " + _statut);
            Console.WriteLine("Loyer : " + _loyer);
            Console.WriteLine("Balcon : " + _balcon);
            Console.WriteLine("----------------------------------");
        }
    }
}
