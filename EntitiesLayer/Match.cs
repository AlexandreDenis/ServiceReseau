using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Match : EntityObject
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
        private Equipe _equipeDomicile;
        public Equipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// Equipe visiteur du match
        /// </summary>
        private Equipe _equipeVisiteur;
        public Equipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
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
        private Stade _stade;
        public Stade Stade
        {
            get { return _stade; }
            set { _stade = value; }
        }

        /// <summary>
        /// Constructeur de la classe Match
        /// </summary>
        /// <param name="inId">Id du nouveau match</param>
        /// <param name="inCoupeID">Id de la coupe du nouveau match</param>
        /// <param name="inDate">Date du nouveau match</param>
        /// <param name="inDom">Equipe domicile du nouveau match</param>
        /// <param name="inVisiteur">Equipe visiteur du nouveau match</param>
        /// <param name="inPrix">Prix du nouveau match</param>
        /// <param name="inSED">Score de l'équipe domicile du nouveau match</param>
        /// <param name="inSEV">Score de l'équipe visiteur du nouveau match</param>
        /// <param name="inStade">Stade du nouveau match</param>
        public Match(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade) 
            : base(inId)
        {
            this.CoupeId = inCoupeID;
            this.Date = inDate;
            this.EquipeDomicile = inDom;
            this.EquipeVisiteur = inVisiteur;
            this.Prix = inPrix;
            this.ScoreEquipeDomicile = inSED;
            this.ScoreEquipeVisiteur = inSEV;
            this.Stade = inStade;
        }

        /// <summary>
        /// Chaîne de caractères du match
        /// </summary>
        /// <returns>Chaîne correspondante</returns>
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            /*res.Append("Match ");
            res.Append(Id);
            res.Append(" -> ");
            res.Append("Coupe ");
            res.Append(CoupeId);
            res.Append(" ( ");
            res.Append(Date);
            res.Append(" ) ");
            res.Append("\n");
            res.Append(EquipeDomicile.Nom);
            res.Append("(D) : ");
            res.Append(ScoreEquipeDomicile);
            res.Append(" VS ");
            res.Append(EquipeVisiteur.Nom);
            res.Append("(V) : ");
            res.Append(ScoreEquipeVisiteur);
            res.Append("\n");
            res.Append("Prix : ");
            res.Append(Prix);
            res.Append(" | Stade : ");
            res.Append(Stade.Id);
            res.Append("\n");
            res.Append("\n");*/

            res.Append("#");
            res.Append(Id);
            res.Append(" - ");
            res.Append(String.Format("{0:dd/MM/yy}", Date));
            /*res.Append(EquipeDomicile);
            res.Append(" VS ");
            res.Append(EquipeVisiteur);*/

            return res.ToString();
        }
    }
}
