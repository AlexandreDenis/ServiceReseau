using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Enumération des différents postes de joueur dans une équipe de Quidditch
    /// </summary>
    public enum PosteJoueur
    {
        None,
        Poursuiveur,
        Batteur,
        Gardien,
        Attrapeur
    }

    public class Joueur : Personne
    {
        /// <summary>
        /// Poste occupé par le joueur
        /// </summary>
        private PosteJoueur _poste;
        public PosteJoueur Poste
        {
            get { return _poste; }
            set { _poste = value; }
        }

        /// <summary>
        /// Nombre de sélection du joueur
        /// </summary>
        private int _nbSelection;
        public int NbSelection
        {
            get { return _nbSelection; }
            set { _nbSelection = value; }
        }
        
        /// <summary>
        /// Nombre de points du joueur
        /// </summary>
        private int _score;
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        /// Constructeur de la classe Joueur
        /// </summary>
        /// <param name="inId">Id du nouveau joueur</param>
        /// <param name="inNom">Nom du nouveau joueur</param>
        /// <param name="inPrenom">Prénom du nouveau joueur</param>
        /// <param name="inDateNaiss">Date de naissance du nouveau joueur</param>
        /// <param name="inPoste">Poste du nouveau joueur</param>
        /// <param name="inSelection">Nombre de sélection du nouveau joueur</param>
        /// <param name="inScore">Score du nouveau joueur</param>
        public Joueur(int inId, string inNom, string inPrenom, DateTime inDateNaiss, PosteJoueur inPoste, int inSelection, int inScore)
            : base(inId, inNom, inPrenom, inDateNaiss)
        {
            this.Poste = inPoste;
            this.NbSelection = inSelection;
            this.Score = inScore;
        }

        /// <summary>
        /// Chaîne de caractères du joueur
        /// </summary>
        /// <returns>Chaîne correspondante</returns>
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append("Joueur ");
            res.Append(Id);
            res.Append(" -> ");
            res.Append(Nom);
            res.Append(" ");
            res.Append(Prenom);
            res.Append(" ( ");
            res.Append(DateDeNaissance);
            res.Append(" ) ");
            res.Append("\n");
            res.Append("Poste : ");
            res.Append(Poste);
            res.Append(" | Nb selections : ");
            res.Append(NbSelection);
            res.Append(" | Score : ");
            res.Append(Score);
            res.Append("\n");
            res.Append("\n");

            return res.ToString();
        }
    }
}
