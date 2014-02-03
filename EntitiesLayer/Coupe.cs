using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Coupe : EntityObject
    {
        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _libelle;
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        public Coupe(int inId, int inYear, string inLibelle) : base(inId)
        {
            this.Year = inYear;
            this.Libelle = inLibelle;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append(Year);
            res.Append(" - ");
            res.Append(Libelle);
            
            res.Append("\n");

            return res.ToString();
        }
    }
}
