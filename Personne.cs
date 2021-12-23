using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RembourseMoi
{
    class Personne
    {
        public int Id;
        public string Nom;
        public string Prenom;
        public int Depense;

        public Personne(string nom, string prenom, int depense)
        {
            Nom = nom;
            Prenom = prenom;
            Depense = depense;
        }

    }
}

