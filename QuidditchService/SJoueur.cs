using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Joueur vu par le web service
    /// </summary>
    [DataContract]
    public class SJoueur : SPersonne
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
        /// Constructeur de la classe SJoueur
        /// </summary>
        /// <param name="inJoueur">Joueur original</param>
        public SJoueur(Joueur inJoueur)
            : base(inJoueur.Id, inJoueur.Nom, inJoueur.Prenom, inJoueur.DateDeNaissance)
        {
            this.Poste = inJoueur.Poste;
            this.NbSelection = inJoueur.NbSelection;
            this.Score = inJoueur.Score;
        }
    }
}