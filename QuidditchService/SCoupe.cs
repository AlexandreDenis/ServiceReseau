using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Coupe vu par le web service
    /// </summary>
    [DataContract]
    public class SCoupe : SEntityObject
    {
        /// <summary>
        /// Année de la coupe
        /// </summary>
        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        /// <summary>
        /// Libellé de la coupe
        /// </summary>
        private string _libelle;
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        /// <summary>
        /// Constructeur de la classe SCoupe
        /// </summary>
        /// <param name="inCoupe">Coupe originale</param>
        public SCoupe(Coupe inCoupe) : base(inCoupe.Id)
        {
            this.Id = inCoupe.Id;
            this.Year = inCoupe.Year;
            this.Libelle = inCoupe.Libelle;
        }

        /// <summary>
        /// Chaîne de caractères de la coupe
        /// </summary>
        /// <returns>Chaîne correspondante</returns>
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