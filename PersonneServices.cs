using RembourseMoi.DAL;
using System.Collections.Generic;
using System.Linq;

namespace RembourseMoi
{
    public class PersonneServices : IPersonneServices
    {
        private Personne_DepotDAL depotPER = new Personne_DepotDAL();

        public void Insert_PER(Personne per)
        {
            var PER = new Personne_DAL(per.Nom, per.Prenom, per.Depense);
            depotPER.Insert(PER);
            per.Id = PER.Id;
        }

        public Personne GetPersonnebyID(int i)
        {
            var PER_DAL = depotPER.GetByID(i);
            var PER = new Personne(PER_DAL.Nom, PER_DAL.Prenom, PER_DAL.Depense);
            return PER;
        }

        public void Delete_PER(Personne per)
        {
            var PER = new Personne_DAL(per.Id, per.Nom, per.Prenom, per.Depense);
            depotPER.Delete(PER);
        }

        public Personne Update_PER(Personne per)
        {
            var PER = new Personne_DAL(per.Id, per.Nom, per.Prenom, per.Depense);
            var PERtmp = depotPER.Update(PER);
            return new Personne(PERtmp.Id, PERtmp.Nom, PERtmp.Prenom, PERtmp.Depense);
        }

        public List<Personne> GetAllPersonnes()
        {
            var liste_DAL = depotPER.GetAll();
            var liste = new List<Personne>();
            foreach (var per in liste_DAL)
            {
                liste.Add(new Personne(per.Nom, per.Prenom, per.Depense));
            }
            return liste;
        }

        public void CalculeDepense(Personne per)
        {
            var liste_Depense = depotPER.GetAllDepense();
            var liste_Personne = depotPER.GetAll();
            var listeDepense = new List<Personne_DAL>();

            foreach (var perDepense in liste_Depense)
            {
                listeDepense.Add(new Personne_DAL(per.Depense));
            }

            float sommeDesDepenses = listeDepense.Sum(depense => per.Depense);
            

            
        }

    }
}
