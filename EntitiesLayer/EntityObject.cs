﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    abstract public class EntityObject
    {
        static public int nextId = 0;

        /// <summary>
        /// Id de l'entité
        /// </summary>
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Constructeur de la classe EntityObject
        /// </summary>
        /// <param name="inId">Id de la nouvelle entité</param>
        public EntityObject (int inId)
	    {
            this.Id = inId;
            nextId++;
	    }

        /// <summary>
        /// Méthode de comparaison entre deux entités
        /// </summary>
        /// <param name="obj">Entité à comparer avec l'instance courante</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is EntityObject)
                return this.Id == (obj as EntityObject).Id;
            else
                return false;
        }

        /// <summary>
        /// Méthode utilisée pour retourner un code unique identifiant une instance d'entité
        /// </summary>
        /// <returns>Hash Code unique pour l'entité courante</returns>
        public override int GetHashCode()
        {
            return Id;
        }
    }
}
