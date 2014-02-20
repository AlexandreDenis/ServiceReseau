using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using EntitiesLayer;
using System.Collections.Generic;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test de test Unitaire
        /// </summary>
        [TestMethod]
        public void TestUtilisateur()
        {
            string toto = "toto";

            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);
            Utilisateur usr = data.GetUtilsateurByLogin(toto, toto);

            Assert.IsTrue(usr.Login.Equals(toto));
        }

        /// <summary>
        /// Test Unitaire pour l'accès à un match à partir de la BDD
        /// </summary>
        [TestMethod]
        public void TestGetMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);
            List<Match> matchs = data.GetAllMatchs();

            Assert.AreNotEqual(matchs.Count, 0);
        }

        /// <summary>
        /// Test Unitaire pour l'ajout d'un match à la BDD
        /// </summary>
        [TestMethod]
        public void TestAddMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);

            int taille1 = data.GetAllMatchs().Count;

            Equipe equipe1 = data.GetAllEquipes()[0];
            Equipe equipe2 = data.GetAllEquipes()[1];
            Stade stade = data.GetAllStades()[0];
            Coupe coupe = data.GetAllCoupes()[0];

            data.AjouterMatch(coupe.Id, DateTime.Now, equipe1, equipe2, 10, 10, 10, stade);

            int taille2 = data.GetAllMatchs().Count;

            Assert.AreEqual(taille1, taille2 - 1);
        }

        /// <summary>
        /// Test Unitaire pour la suppression d'un match de la BDD
        /// </summary>
        [TestMethod]
        public void TestDelMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);

            List<Match> matchs = data.GetAllMatchs();
            int taille1 = matchs.Count;
            Match m = matchs[0];

            data.SupprimerMatch(m.Id);

            int taille2 = data.GetAllMatchs().Count;

            Assert.AreEqual(taille1, taille2 + 1);
        }

        /// <summary>
        /// Test Unitaire pour la modification d'un match de la BDD
        /// </summary>
        [TestMethod]
        public void TestModifMatch()
        {
            DalManager data = DalManager.GetInstance(DALProvider.SQLSERVER);

            List<Match> matchs = data.GetAllMatchs();
            Match m = matchs[0];
            int oldScoreDom = m.ScoreEquipeDomicile;
            int id = m.Id;

            data.UpdateMatch(m.Id, m.CoupeId,
                m.Date,
                m.EquipeDomicile,
                m.EquipeVisiteur,
                m.Prix,
                m.ScoreEquipeDomicile + 100,
                m.ScoreEquipeVisiteur,
                m.Stade);

            matchs = data.GetAllMatchs();

            m = matchs[0];

            Assert.AreEqual(m.ScoreEquipeDomicile, oldScoreDom + 100);

        }
    }
}
