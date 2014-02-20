using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Equipe : EntityObject
    {
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Pays de l'équipe
        /// </summary>
        private string _pays;
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }
        
        /// <summary>
        /// Liste des joueurs de l'équipe
        /// </summary>
        private List<Joueur> _joueurs;
        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="inId">Id de la nouvelle équipe</param>
        /// <param name="inNom">Nom de la nouvelle équipe</param>
        /// <param name="inPays">Pays de la nouvelle équipe</param>
        public Equipe(int inId, string inNom, string inPays) : base(inId)
        {
            this.Nom = inNom;
            this.Pays = inPays;
            this.Joueurs = new List<Joueur>();
        }

        /// <summary>
        /// Ajout d'un joueur à l'équipe
        /// </summary>
        /// <param name="joueur">Joueur à rajouter à l'équipe</param>
        public void AddJoueur(Joueur joueur)
        {
            _joueurs.Add(joueur);
        }

        /// <summary>
        /// Chaîne de caractères de l'équipe
        /// </summary>
        /// <returns>Chaîne correspondante</returns>
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
