using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Equipe : EntityObject
    {
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        private string _pays;
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        private List<Joueur> _joueurs;
        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        public Equipe(int inId, string inNom, string inPays) : base(inId)
        {
            this.Nom = inNom;
            this.Pays = inPays;
            this.Joueurs = new List<Joueur>();
        }

        public void AddJoueur(Joueur joueur)
        {
            _joueurs.Add(joueur);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            /*res.Append("Equipe ");
            res.Append(Id);
            res.Append(" | Nom : ");
            res.Append(Nom);
            res.Append(" | Pays : ");
            res.Append(Pays);
            res.Append("\n");

            foreach (Joueur pl in Joueurs)
            {
                res.Append("- ");
                res.Append(pl.Prenom);
                res.Append(" ");
                res.Append(pl.Nom);
                res.Append("\n");
            }*/

            res.Append(Nom);
            res.Append(" (");
            res.Append(Pays);
            res.Append(")");

            //res.Append("\n");

            return res.ToString();
        }
    }
}
