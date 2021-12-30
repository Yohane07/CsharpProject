using System;
using ProjetCsharp;
using RembourseMoi.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RembourseMoi
{
    public interface IPersonneServices
    {
        public void Insert_PER(Personne per);
        public Personne Update_PER(Personne per);
        public Personne GetPersonnebyID(int i);
        public void Delete_PER(Personne per);
        public List<Personne> GetAllPersonnes();

        public void CalculeDepense(Personne per);

    }
}
