using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Match : EntityObject
    {
        private int _coupeId;
        public int CoupeId
        {
            get { return _coupeId; }
            set { _coupeId = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private Equipe _equipeDomicile;
        public Equipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        private Equipe _equipeVisiteur;
        public Equipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        private double _prix;
        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private int _scoreEquipeDomicile;
        public int ScoreEquipeDomicile
        {
            get { return _scoreEquipeDomicile; }
            set { _scoreEquipeDomicile = value; }
        }

        private int _scoreEquipeVisiteur;
        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }

        private Stade _stade;
        public Stade Stade
        {
            get { return _stade; }
            set { _stade = value; }
        }

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
