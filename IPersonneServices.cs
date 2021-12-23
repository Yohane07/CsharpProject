using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RembourseMoi
{
    interface IPersonneServices
    {
        public List<Personne> GetAllPersonnes();
        public Personne GetPersonneById(int id);
        public Personne Insert(Personne p);
        public Personne Update(Personne p);
        public Personne CalculeDepenses(int depense); //Du coup c'est ici que se passe le plus gros du bouleau, implémenter le calcul quoiqu'avec le getAllPersonne je pourrai avoir le nb de personne et calculer la mopyenne
        public void Delete(Personne p);
    }
}
