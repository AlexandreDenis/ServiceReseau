using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Match vu par le web service
    /// </summary>
    [DataContract]
    public class SMatch : SEntityObject
    {
        /// <summary>
        /// Id de la coupe à laquelle appartient le match
        /// </summary>
        private int _coupeId;
        public int CoupeId
        {
            get { return _coupeId; }
            set { _coupeId = value; }
        }

        /// <summary>
        /// Date du match
        /// </summary>
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// Equipe à domicile du match
        /// </summary>
        private int _equipeDomicileId;
        public int EquipeDomicileId
        {
            get { return _equipeDomicileId; }
            set { _equipeDomicileId = value; }
        }

        /// <summary>
        /// Equipe visiteur du match
        /// </summary>
        private int _equipeVisiteurId;
        public int EquipeVisiteurId
        {
            get { return _equipeVisiteurId; }
            set { _equipeVisiteurId = value; }
        }

        /// <summary>
        /// Prix des places pour le match
        /// </summary>
        private double _prix;
        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        /// <summary>
        /// Score de l'équipe à domicile pour le match
        /// </summary>
        private int _scoreEquipeDomicile;
        public int ScoreEquipeDomicile
        {
            get { return _scoreEquipeDomicile; }
            set { _scoreEquipeDomicile = value; }
        }

        /// <summary>
        /// Score de l'équipe visiteur pour le match
        /// </summary>
        private int _scoreEquipeVisiteur;
        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }

        /// <summary>
        /// Stade dans lequel se déroule le match
        /// </summary>
        private int _stadeId;
        public int StadeId
        {
            get { return _stadeId; }
            set { _stadeId = value; }
        }

        /// <summary>
        /// Constructeur de la classe SMatch
        /// </summary>
        /// <param name="inMatch">Match original</param>
        public SMatch(Match inMatch) 
            : base(inMatch.Id)
        {
            this.CoupeId = inMatch.CoupeId;
            this.Date = inMatch.Date;
            this.EquipeDomicileId = inMatch.EquipeDomicile.Id;
            this.EquipeVisiteurId = inMatch.EquipeVisiteur.Id;
            this.Prix = inMatch.Prix;
            this.ScoreEquipeDomicile = inMatch.ScoreEquipeDomicile;
            this.ScoreEquipeVisiteur = inMatch.ScoreEquipeVisiteur;
            this.StadeId = inMatch.Stade.Id;
        }
    }
}