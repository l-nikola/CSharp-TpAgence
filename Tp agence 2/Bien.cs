using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_agence_2
{
    class Bien
    {
        string _reference;
        string _adresse;
        int _surface;
        int _nombrePiece;

        public Bien(string reference, string adresse, int surface, int nombrePiece)
        {
            _reference = reference;
            _adresse = adresse;
            _surface = surface;
            _nombrePiece = nombrePiece;
        }

        public string Reference { get => _reference; set => _reference = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public int Surface { get => _surface; set => _surface = value; }
        public int NombrePiece { get => _nombrePiece; set => _nombrePiece = value; }
        public string getReference()
        {
            return _reference;
        }
        public string getAdresse()
        {
            return _adresse;
        }
        public int getSurface()
        {
            return _surface;
        }
        public int getNbPiece()
        {
            return _nombrePiece;
        }

        public void affiche()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Numéro de bien : " + _reference);
            Console.WriteLine("Adresse : " + _adresse);
            Console.WriteLine("Surface habitable : " + _surface);
            Console.WriteLine("Nombre de piece : " + _nombrePiece);
        }
    }
}
