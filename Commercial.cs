using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Commercial
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Categories categorie;

        public Commercial(string nom, string prenom, int anneeNaissance, Categories categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance;
            this.categorie = categorie;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int AnneeNaissance
        {
            get { return anneeNaissance; }
            set { anneeNaissance = value; }
        }

        public Categories Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public int CalculAge()
        {
            return DateTime.Now.Year - anneeNaissance;
        }

        public override string ToString()
        {
            return $"Nom: {nom}, Prénom: {prenom}, Age: {CalculAge()}, Catégorie: {categorie.ToString()}";
        }

        public void Compare(Commercial c)
        {
            if (this.nom.Split(' ')[1] == c.nom.Split(' ')[1])
            {
                Console.WriteLine($"{this.nom} et {c.nom} ont le même nom de famille.");
            }
            else
            {
                Console.WriteLine($"{this.nom} et {c.nom} n'ont pas le même nom de famille.");
            }
        }
    }


}

